namespace Kartverket_group2.Models
{
    /// <summary>
    /// View model for the admin dashboard containing submission data and filtering/pagination parameters.
    /// </summary>
    public class AdminViewModel
    {
        /// <summary>
        /// Collection of submissions to display on the current page.
        /// </summary>
        public IEnumerable<Submission> Submissions { get; set; }

        /// <summary>
        /// Current page number in the pagination.
        /// </summary>
        public int CurrentPage { get; set; }

        /// <summary>
        /// Number of items to display per page.
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Total number of items across all pages.
        /// </summary>
        public int TotalItems { get; set; }

        /// <summary>
        /// Column name currently being used for sorting.
        /// </summary>
        public string? CurrentSortColumn { get; set; }

        /// <summary>
        /// Indicates whether sorting is in descending order.
        /// </summary>
        public bool SortDescending { get; set; }

        /// <summary>
        /// Array of status values to filter submissions by.
        /// </summary>
        public string[]? StatusFilter { get; set; }

        /// <summary>
        /// Minimum municipality number for range filtering.
        /// </summary>
        public int? MunicipalityMin { get; set; }

        /// <summary>
        /// Maximum municipality number for range filtering.
        /// </summary>
        public int? MunicipalityMax { get; set; }

        /// <summary>
        /// Calculated total number of pages based on total items and page size.
        /// </summary>
        public int TotalPages => (int)Math.Ceiling(TotalItems / (double)PageSize);

        /// <summary>
        /// Single municipality number for exact matching.
        /// </summary>
        public int? MunicipalitySingle { get; set; }

        /// <summary>
        /// Type of municipality search ('single' or 'range').
        /// </summary>
        public string MunicipalitySearchType { get; set; }
    }
}