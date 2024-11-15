using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Kartverket_group2.Models
{
    /// <summary>
    /// View model for creating new users with role assignments.
    /// </summary>
    public class CreateUserViewModel
    {
        /// <summary>
        /// User's email address. Must be a valid email format.
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// Username for the new account.
        /// </summary>
        [Required]
        public string Username { get; set; }

        /// <summary>
        /// Password for the new account. Hidden in UI.
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        /// <summary>
        /// Password confirmation field to ensure accurate password entry.
        /// Must match Password field.
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        /// <summary>
        /// List of available roles for selection in the UI.
        /// </summary>
        public List<SelectListItem> Roles { get; set; } = new List<SelectListItem>();

        /// <summary>
        /// Collection of role names assigned to the new user.
        /// </summary>
        public List<string> SelectedRoles { get; set; } = new List<string>();
    }


}
