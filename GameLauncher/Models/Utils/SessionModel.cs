using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Models.Utils
{
    public class SessionModel
    {
        public int UserId { get; set; }
        public string Username { get; set; } = string.Empty;
        public DateTime LoginTime { get; set; } = DateTime.Now;
        public bool StaySignedIn { get; set; }
    }
}
