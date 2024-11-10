namespace Kartverket_group2.Models
{
    public enum EmailType
    {
        StatusUpdate,
        PasswordReset
    }

    public class EmailQueueMessage
    {
        public string UserEmail { get; set; }
        public EmailType EmailType { get; set; }
        // Status update specific properties
        public string SubmissionId { get; set; }
        public string NewStatus { get; set; }
        // Common property for both types
        public string AdminComment { get; set; }
        // Password reset specific properties
        public string ResetLink { get; set; }
    }
}