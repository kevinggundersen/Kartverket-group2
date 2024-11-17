namespace Kartverket_group2.Models
{
    /// <summary>
    /// View model for user login form submission.
    /// </summary>
    public class LoginViewModel
    {
        /// <summary>
        /// User's email address or username for authentication.
        /// </summary>
        public string EmailOrUsername { get; set; }

        /// <summary>
        /// User's password for authentication.
        /// </summary>
        public string Password { get; set; }
    }
}