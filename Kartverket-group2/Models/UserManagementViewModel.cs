using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Kartverket_group2.Models
{
    public class UserManagementViewModel
    {
        // Properties for creating new user
        [Required]
        [EmailAddress]
        public string NewUserEmail { get; set; }

        [Required]
        public string NewUsername { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public List<SelectListItem> AvailableRoles { get; set; } = new List<SelectListItem>();
        public List<string> SelectedRoles { get; set; } = new List<string>();

        // Properties for user list
        public List<ApplicationUserModel> Users { get; set; } = new List<ApplicationUserModel>();
        public List<string> Roles { get; set; } = new List<string>();
        public string SelectedRole { get; set; }
        public UserManager<ApplicationUserModel> UserManager { get; set; }

        // Additional properties for UI state
        public bool ShowCreateForm { get; set; } = false;
        public string StatusMessage { get; set; }
    }
}