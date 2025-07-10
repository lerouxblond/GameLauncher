using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Icon { get; set; } = "game_default.png";

        public string Executable { get; set; } = string.Empty;

        [ForeignKey(nameof(Genre))]
        public int GenreID { get; set; }
        public Genre Genre { get; set; } = null!;

        public List<GamePlatform> GamePlatforms { get; set; } = [];
        public List<GameStoreLink> GameStoreLinks { get; set; } = [];

        public List<Note> Notes { get; set; } = [];

        public List<LibraryEntry> LibraryEntries { get; set; } = [];

        // Game out date
        public DateTime OutDate { get; set; } = DateTime.Now;

        #endregion
        // Empty Constructor
        public Game() { }

        // Creation Contructor for DB insertion and Shelf Game Creation
        public Game(string gamename, string gamedescription, DateTime outDate ,int genreId)
        {
            Name = gamename;
            Description = gamedescription;
            GenreID = genreId;
            OutDate = outDate;
        }
    }
}
