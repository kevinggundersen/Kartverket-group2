namespace Kartverket_group2.Models
{
    public class EmailQueueMessage
    {
        public string UserEmail { get; set; }
        public string SubmissionId { get; set; }
        public string NewStatus { get; set; }
    }
}
