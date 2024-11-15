using Microsoft.AspNetCore.Identity;

namespace Kartverket_group2.Models
{
    public class UserListViewModel
    {
        public List<ApplicationUserModel> Users { get; set; }
        public List<string> Roles { get; set; }
        public string SelectedRole { get; set; }
        public UserManager<ApplicationUserModel> UserManager { get; set; } // Add this property
    }
}
