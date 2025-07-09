using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Models
{
    public class LibraryEntry
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(User))]
        public int UserID { get; set; }
        public User User { get; set; } = null!;

        [ForeignKey(nameof(Game))]
        public int GameID { get; set; }
        public Game Game { get; set; } = null!;

        [Range(0, 20)]
        public int Rating { get; set; } = 0;
        public GameStatus Status { get; set; } = GameStatus.Default;
        public bool Privacy { get; set; } = true;

        public List<Note> Notes { get; set; } = [];

        public LibraryEntry() { }

        public LibraryEntry(int userId, int gameID)
        {
            UserID = userId;
            GameID = gameID;
        }
    }


    public enum GameStatus
    {
        Default,
        Playing,
        Planning,
        Complete,
        Dropped
    }
}