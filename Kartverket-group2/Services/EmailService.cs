using Kartverket_group2.Models;
using Kartverket_group2.Services;
using System.Net.Mail;
using System.Threading.Channels;

/// <summary>
/// Service for handling email operations including queueing and sending emails.
/// Implements a producer-consumer pattern using channels for email queue management.
/// </summary>
public class EmailService : IEmailService
{
    private readonly IConfiguration _configuration;
    private readonly ILogger<EmailService> _logger;
    private readonly Channel<EmailQueueMessage> _emailQueue;

    /// <summary>
    /// Initializes the email service with configuration and logging capabilities.
    /// Sets up a bounded channel for email queue with a capacity of 100 messages.
    /// </summary>
    /// <param name="configuration">Application configuration for email settings.</param>
    /// <param name="logger">Logger for email operations.</param>
    public EmailService(IConfiguration configuration, ILogger<EmailService> logger)
    {
        _configuration = configuration;
        _logger = logger;
        var options = new BoundedChannelOptions(100)
        {
            FullMode = BoundedChannelFullMode.Wait
        };
        _emailQueue = Channel.CreateBounded<EmailQueueMessage>(options);
        _ = ProcessEmailQueueAsync();
    }

    /// <summary>
    /// Queues an email message for asynchronous processing.
    /// </summary>
    /// <param name="email">Email message to be queued.</param>
    /// <exception cref="ArgumentNullException">Thrown when email is null.</exception>
    public async ValueTask QueueEmailAsync(EmailQueueMessage email)
    {
        if (email == null)
        {
            throw new ArgumentNullException(nameof(email));
        }
        await _emailQueue.Writer.WriteAsync(email);
        _logger.LogInformation("Email queued for sending to {UserEmail}", email.UserEmail);
    }

    /// <summary>
    /// Sends an email using configured SMTP settings.
    /// </summary>
    /// <param name="email">Email message to be sent.</param>
    /// <exception cref="ArgumentException">Thrown for unsupported email types.</exception>
    public async Task SendEmailAsync(EmailQueueMessage email)
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
                IsBodyHtml = true,
            };
            mailMessage.To.Add(email.UserEmail);

            // Set subject and body based on email type
            switch (email.EmailType)
            {
                case EmailType.StatusUpdate:
                    mailMessage.Subject = "Oppdatert status for innmelding";
                    mailMessage.Body = GenerateStatusUpdateEmailBody(email);
                    break;

                case EmailType.PasswordReset:
                    mailMessage.Subject = "Tilbakestill passord";
                    mailMessage.Body = GeneratePasswordResetEmailBody(email);
                    break;

                default:
                    throw new ArgumentException($"Unsupported email type: {email.EmailType}");
            }

            await smtpClient.SendMailAsync(mailMessage);
            _logger.LogInformation("Email sent successfully to {UserEmail}", email.UserEmail);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to send email to {UserEmail}", email.UserEmail);
            throw;
        }
    }

    /// <summary>
    /// Generates HTML body for status update emails.
    /// </summary>
    /// <param name="email">Email message containing status update information.</param>
    /// <returns>HTML formatted email body.</returns>
    private string GenerateStatusUpdateEmailBody(EmailQueueMessage email)
    {
        return $@"
        <html>
        <body>
            <h2>Status Oppdatering</h2>
            <p>Hei,</p>
            <p>Din innmelding (ID: {email.SubmissionId}) har fått oppdatert sin status til: <strong>{email.NewStatus}</strong></p>
            <p>Du kan følge status for dine innmeldinger på profilsiden din.</p>
            {(!string.IsNullOrEmpty(email.AdminComment) ? $"<p>Kommentar fra behandler: {email.AdminComment}</p>" : "")}
            <p>Med vennlig hilsen,<br>Kartverket</p>
        </body>
        </html>";
    }

    /// <summary>
    /// Generates HTML body for password reset emails.
    /// </summary>
    /// <param name="email">Email message containing password reset information.</param>
    /// <returns>HTML formatted email body.</returns>
    private string GeneratePasswordResetEmailBody(EmailQueueMessage email)
    {
        return $@"
        <html>
        <body>
            <h2>Tilbakestill Passord</h2>
            <p>Hei,</p>
            <p>Vi har mottatt en forespørsel om å tilbakestille passordet ditt.</p>
            <p>Klikk på lenken under for å tilbakestille passordet:</p>
            <p><a href='{email.ResetLink}'>Tilbakestill passord</a></p>
            <p>Hvis du ikke har bedt om å tilbakestille passordet ditt, kan du se bort fra denne e-posten.</p>
            <p>Med vennlig hilsen,<br>Kartverket</p>
        </body>
        </html>";
    }

    /// <summary>
    /// Continuously processes the email queue in a background task.
    /// Attempts to send each queued email and handles any failures.
    /// </summary>
    private async Task ProcessEmailQueueAsync()
    {
        while (true)
        {
            try
            {
                var email = await _emailQueue.Reader.ReadAsync();
                await SendEmailAsync(email);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing email queue");
                await Task.Delay(1000);
            }
        }
    }
}