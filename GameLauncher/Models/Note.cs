using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string NoteTitle { get; set; } = string.Empty;
        public string NoteContent { get; set; } = string.Empty;
        // Creation and Lasted edit Date
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime LastedEditTimeDate { get; set; }

        #endregion
        // Empty Constructor
        public Note() { }

        public Note(string  noteTitle, string noteContent)
        {
            NoteTitle = noteTitle;
            NoteContent = noteContent;
            LastedEditTimeDate = DateTime.Now;
        }
    }
}
