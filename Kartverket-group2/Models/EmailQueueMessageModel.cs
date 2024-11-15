namespace Kartverket_group2.Models
{
    /// <summary>
    /// Defines the types of emails that can be sent through the system.
    /// </summary>
    public enum EmailType
    {
        /// <summary>
        /// Email notification for status changes in submissions.
        /// </summary>
        StatusUpdate,

        /// <summary>
        /// Email containing password reset information.
        /// </summary>
        PasswordReset
    }

    /// <summary>
    /// Represents a message in the email queue containing all necessary information for sending emails.
    /// </summary>
    public class EmailQueueMessage
    {
        /// <summary>
        /// The recipient's email address.
        /// </summary>
        public string UserEmail { get; set; }

        /// <summary>
        /// The type of email to be sent (StatusUpdate or PasswordReset).
        /// </summary>
        public EmailType EmailType { get; set; }

        /// <summary>
        /// The unique identifier of the submission being updated.
        /// Only used for StatusUpdate emails.
        /// </summary>
        public string SubmissionId { get; set; }

        /// <summary>
        /// The new status of the submission.
        /// Only used for StatusUpdate emails.
        /// </summary>
        public string NewStatus { get; set; }

        /// <summary>
        /// Additional comments provided by the administrator.
        /// Applicable for both StatusUpdate and PasswordReset emails.
        /// </summary>
        public string AdminComment { get; set; }

        /// <summary>
        /// The URL link for password reset.
        /// Only used for PasswordReset emails.
        /// </summary>
        public string ResetLink { get; set; }
    }
}