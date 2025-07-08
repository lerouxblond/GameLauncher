using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Models
{
    public class Game
    {
        #region Game Properties
        [Key]
        public int Id { get; set; }
        public string GameName { get; set; } = string.Empty;
        public string GameDescription { get; set; } = string.Empty;
        public string GameProfilePicture { get; set; } = "game_default.png";

        // Game added date
        public DateTime GameAddedDate { get; set; } = DateTime.Now;

        public bool GameOwned { get; set; }
        public string GameLaunchPath { get; set; } = string.Empty;

        public List<Note> GameNoteList { get; set; } = [];

        #endregion
        // Empty Constructor
        public Game() { }

        // Creation Contructor for DB insertion and Shelf Game Creation
        public Game(string gamename, string gamedescription)
        {
            GameName = gamename;
            GameDescription = gamedescription;
        }
    }
}
