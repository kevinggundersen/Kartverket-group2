using System.ComponentModel.DataAnnotations;

namespace Kartverket_group2.Models
{
    /// <summary>
    /// View model for the forgot password form submission.
    /// </summary>
    public class ForgotPasswordViewModel
    {
        /// <summary>
        /// User's email address for password recovery.
        /// Must be a valid email format.
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }

    /// <summary>
    /// View model for the password reset form submission.
    /// </summary>
    public class ResetPasswordViewModel
    {
        /// <summary>
        /// Security token for password reset verification.
        /// </summary>
        [Required]
        public string Token { get; set; }

        /// <summary>
        /// User's email address to confirm identity.
        /// Must be a valid email format.
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// New password for the account.
        /// Must be 6-100 characters long.
        /// </summary>
        [Required]
        [StringLength(100, ErrorMessage = "{0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        /// <summary>
        /// Confirmation of the new password.
        /// Must match the Password field exactly.
        /// </summary>
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}