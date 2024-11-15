using Microsoft.AspNetCore.Identity;

namespace Kartverket_group2.Models
{
    /// <summary>
    /// View model for managing user lists and roles in the admin interface.
    /// </summary>
    public class UserListViewModel
    {
        /// <summary>
        /// Collection of all application users.
        /// </summary>
        public List<ApplicationUserModel> Users { get; set; }

        /// <summary>
        /// List of available roles in the application.
        /// </summary>
        public List<string> Roles { get; set; }

        /// <summary>
        /// Currently selected role for filtering or assignment.
        /// </summary>
        public string SelectedRole { get; set; }

        /// <summary>
        /// UserManager instance for handling user-related operations.
        /// Provides functionality for managing users and their roles.
        /// </summary>
        public UserManager<ApplicationUserModel> UserManager { get; set; } // Add this property
    }
}
