using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Models
{
    public class User
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
        public DateTime LatestUserModified { get; set; }

        // List of games added, owned or not by the user added to their Shelf 
        public List<Game> GameList { get; set; } = [];
        public bool AdminPermition { get; set; }

        #endregion
        // Empty Constructor
        public User() { }

        // Register Constructor for DB insertion and Register Auth
        public User(string username, string email, string password, bool adminPermition = false)
        {
            Username = username;
            Email = email;
            Password = password;
            AdminPermition = adminPermition;
            LatestUserModified = DateTime.Now;
        }
    }
}
