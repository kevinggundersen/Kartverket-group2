using Kartverket_group2.Models;

namespace Kartverket_group2.Services
{
    public interface IEmailService
    {
        ValueTask QueueEmailAsync(EmailQueueMessage email);
        Task SendEmailAsync(EmailQueueMessage email);
    }
}