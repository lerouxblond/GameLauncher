using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Models
{
    public class GamePlatform
    {
        [Key]
        public int GameId { get; set; }
        public Game Game { get; set; } = null!;

        [Key]
        public int PlatformId { get; set; }
        public Platform Platform { get; set; } = null!;

        public GamePlatform() { }
    }
}
