using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Models
{
    public class Platform
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        public List<GamePlatform> GamePlatforms { get; set; } = [];

        public Platform() { }

        public Platform(string name)
        {
            Name = name;
        }
    }
}
