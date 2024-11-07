using Kartverket_group2.Models;

namespace Kartverket_group2.Services
{
    public interface IEmailService
    {
        Task SendStatusUpdateEmailAsync(string userEmail, string submissionId, string newStatus);
        ValueTask QueueEmailAsync(EmailQueueMessage email);
    }
}
