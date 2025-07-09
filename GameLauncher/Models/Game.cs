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

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Icon { get; set; } = "game_default.png";

        public string Executable { get; set; } = string.Empty;

        [ForeignKey(nameof(Genre))]
        public int GenreID { get; set; }

        // Game out date
        public DateTime OutDate { get; set; } = DateTime.Now;

        #endregion
        // Empty Constructor
        public Game() { }

        // Creation Contructor for DB insertion and Shelf Game Creation
        public Game(string gamename, string gamedescription, int genreId)
        {
            Name = gamename;
            Description = gamedescription;
            GenreID = genreId;
        }
    }
}
