using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Models
{
    public class Note
    {
        #region Note Properties
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        public Users User { get; set; } = null!;

        public int GameId { get; set; }
        public Game Game { get; set; } = null!;

        public int LibraryEntryId { get; set; }
        public LibraryEntry LibraryEntry { get; set; } = null!;

        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public bool Privacy { get; set; } = false;

        // Creation and Lasted edit Date
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime? LastEditAt { get; set; }

        #endregion
        // Empty Constructor
        public Note() { }

        public Note(string  noteTitle, string noteContent, bool privacy)
        {
            Title = noteTitle;
            Content = noteContent;
            Privacy = privacy;
        }
    }
}
