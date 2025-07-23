using GameLauncher.Models;
using GameLauncher.Models.Utils;
using GameLauncher.Services;
using GameLauncher.Services.Auth;
using GameLauncher.Views.Auth;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Controllers.Auth
{
    public class AuthController
    {
        private readonly AuthService _authService;
        private readonly SessionService _sessionService;
        private readonly IServiceProvider _provider;


        public AuthController(AuthService authService, SessionService sessionService, IServiceProvider provider)
        {
            _authService = authService;
            _sessionService = sessionService;
            _provider = provider;

            CheckExistingSession();
        }

        private void CheckExistingSession()
        {
            var session = _sessionService.LoadSession();
            if (session?.StaySignedIn == true)
            {
                var home = _provider.GetRequiredService<MainView>();
                home.Show();
            }
        }

        public ServiceResult<SessionModel> Login(string identifient, string password, bool staySignedIn)
        {
            var result = _authService.Login(identifient, password);

            if(!result.Success)
            {
                return ServiceResult<SessionModel>.Fail(result.Message);
            }

            SessionModel session;
            if(staySignedIn)
            {
                session = new SessionModel
                {
                    UserId = result.Data!.Id,
                    Username = result.Data.Username,
                    StaySignedIn = true
                };
                _sessionService.SaveSession(session);
                return ServiceResult<SessionModel>.Ok(session);
            }

            var home = _provider.GetRequiredService<MainView>();
            home.Show();
            return ServiceResult<SessionModel>.Successful();
        }

        public ServiceResult<Users> Register(string username, string Email, string password)
        {
            var result = _authService.Register(username, Email, password);

            if(!result.Success)
            {
                return ServiceResult<Users>.Fail(result.Message);
            }

            MessageBox.Show("Account created succesfully. Please log in.");
            return ServiceResult<Users>.Successful();
        }

        public void LogOut()
        {

        }

    }
}
