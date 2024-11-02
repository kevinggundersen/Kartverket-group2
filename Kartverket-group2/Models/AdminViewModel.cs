namespace Kartverket_group2.Models
{
    public class AdminViewModel
    {
        public IEnumerable<Submission> Submissions { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
        public string CurrentSortColumn { get; set; }
        public bool SortDescending { get; set; }
        public string[] StatusFilter { get; set; }
        public int? MunicipalityMin { get; set; }
        public int? MunicipalityMax { get; set; }
        public int TotalPages => (int)Math.Ceiling(TotalItems / (double)PageSize);
    }
}
