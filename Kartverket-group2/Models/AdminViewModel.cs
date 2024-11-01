namespace Kartverket_group2.Models
{
    public class AdminViewModel
    {
        public List<Submission> Submissions { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; } // Tracks user-selected page size
        public int TotalPages => (int)Math.Ceiling((double)TotalItems / PageSize);
    }
}
