using GameLauncher.Models.Utils;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GameLauncher.Services
{
    public class SessionService
    {
        private readonly string _sessionFilePath;
        public SessionService(IConfiguration configuration)
        {
            _sessionFilePath = Path.Combine(
                configuration["AppSettings:SessionPath"]!,
                "session.json"
                );
        }

        public void SaveSession(SessionModel session)
        {
            var json = JsonSerializer.Serialize(session);
            File.WriteAllText( _sessionFilePath, json );
        }

        public SessionModel? LoadSession()
        {
            if(!File.Exists( _sessionFilePath ))
                return null;

            var json = File.ReadAllText( _sessionFilePath );

            return JsonSerializer.Deserialize<SessionModel>( json );
        }

        public void ClearSession()
        {
            if(File.Exists(_sessionFilePath))
                File.Delete(_sessionFilePath);
        }

    }
}
