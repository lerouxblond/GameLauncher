using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Models
{
    public class GameStoreLink
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Game))]
        public int GameId { get; set; }
        public Game Game { get; set; } = null!;
        
        [Url]
        [MaxLength(2048)]
        public string StoreUrl { get; set; } = string.Empty;


        public GameStoreLink() { }

        public GameStoreLink(int gameId, string storeUrl)
        {
            GameId = gameId;
            StoreUrl = storeUrl;
        }
    }
}
