using Kartverket_group2.Models;
using Kartverket_group2.Services;
using System.Net.Mail;
using System.Threading.Channels;


public class EmailService : IEmailService
{
    private readonly IConfiguration _configuration;
    private readonly ILogger<EmailService> _logger;
    private readonly Channel<EmailQueueMessage> _emailQueue;

    public EmailService(IConfiguration configuration, ILogger<EmailService> logger)
    {
        _configuration = configuration;
        _logger = logger;

        var options = new BoundedChannelOptions(100) // Maximum capacity
        {
            FullMode = BoundedChannelFullMode.Wait
        };
        _emailQueue = Channel.CreateBounded<EmailQueueMessage>(options);

        // Start processing emails in background
        _ = ProcessEmailQueueAsync();
    }

    public async ValueTask QueueEmailAsync(EmailQueueMessage email)
    {
        if (email == null)
        {
            throw new ArgumentNullException(nameof(email));
        }

        await _emailQueue.Writer.WriteAsync(email);
        _logger.LogInformation("Email queued for sending to {UserEmail}", email.UserEmail);
    }

    public async Task SendStatusUpdateEmailAsync(string userEmail, string submissionId, string newStatus)
    {
        try
        {
            using var smtpClient = new SmtpClient(_configuration["Email:SmtpServer"])
            {
                Port = int.Parse(_configuration["Email:Port"]),
                Credentials = new System.Net.NetworkCredential(
                    _configuration["Email:Username"],
                    _configuration["Email:Password"]
                ),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(_configuration["Email:FromAddress"], "Kartverket"),
                Subject = "Oppdatert status for innmelding",
                Body = $@"Hei,

Din innmelding (ID: {submissionId}) har fått oppdatert sin status til: {newStatus}

Du kan følge status for dine innmeldinger på profilsiden din.

Med vennlig hilsen,
Kartverket",
                IsBodyHtml = false,
            };
            mailMessage.To.Add(userEmail);

            await smtpClient.SendMailAsync(mailMessage);
            _logger.LogInformation("Email sent successfully to {UserEmail}", userEmail);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to send email to {UserEmail}", userEmail);
            throw;
        }
    }
    private async Task ProcessEmailQueueAsync()
    {
        while (true)
        {
            try
            {
                var email = await _emailQueue.Reader.ReadAsync();
                await SendStatusUpdateEmailAsync(
                    email.UserEmail,
                    email.SubmissionId,
                    email.NewStatus);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing email queue");
                // Add delay before next attempt
                await Task.Delay(1000);
            }
        }
    }
}