using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Models
{
    public class Users
    {
        #region User Properties
        // Primary Key for db purpose
        [Key]
        public int Id { get; set; }

        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string ProfilePicture { get; set; } = "default.png";

        // Creation and Lasted edit Date
        public DateTime UserCreated { get; set; } = DateTime.Now;
        public DateTime? LastEditAt { get; set; }

        // List of games added, owned or not by the user added to their Shelf 
        public List<LibraryEntry> LibraryEntries { get; set; } = [];
        public List<Note> Notes { get; set; } = [];

        public bool AdminPermission { get; set; }
        public bool PrivateAccount { get; set; } = false;

        #endregion
        // Empty Constructor
        public Users() { }

        // Register Constructor for DB insertion and Register Auth
        public Users(string username, string email, string password, bool adminPermission = false)
        {
            Username = username;
            Email = email;
            Password = password;
            AdminPermission = adminPermission;
        }
    }
}
