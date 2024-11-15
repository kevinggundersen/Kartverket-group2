using Kartverket_group2.Models;

namespace Kartverket_group2.Services
{
    /// <summary>
    /// Interface for email service operations including queueing and sending emails.
    /// </summary>
    public interface IEmailService
    {
        /// <summary>
        /// Queues an email message for asynchronous processing.
        /// </summary>
        /// <param name="email">Email message to be queued.</param>
        /// <returns>A ValueTask representing the asynchronous operation.</returns>
        ValueTask QueueEmailAsync(EmailQueueMessage email);

        /// <summary>
        /// Sends an email immediately using configured SMTP settings.
        /// </summary>
        /// <param name="email">Email message to be sent.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        Task SendEmailAsync(EmailQueueMessage email);
    }
}