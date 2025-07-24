using GameLauncher.Controllers.Auth;
using GameLauncher.Views.Auth.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher.Views.Auth
{
    public partial class AuthMainView : Form
    {
        private readonly AuthController _authController;

        public AuthMainView(AuthController authController)
        {
            _authController = authController;
            InitializeComponent(authController);

            InitializeFormEvents();
        }

        private void InitializeFormEvents()
        {
            loginControlForm.SwitchToRegister += SwitchToRegister;
            registerControlForm.SwitchToLogin += SwitchToLogin;
            loginControlForm.CloseAuthPage += CloseAuthPage;
            registerControlForm.CloseAuthPage += CloseAuthPage;
            registerControlForm.UserRegister += SwitchToLogin;
            loginControlForm.UserLogged += HideAuthPage;
            ShowLogin();
        }

        private void ShowLogin()
        {
            loginControlForm.Visible = true;
            registerControlForm.Visible = false;
        }

        private void ShowRegister()
        {
            loginControlForm.Visible = false;
            registerControlForm.Visible = true;
        }

        private void SwitchToRegister(object? sender, EventArgs e) => ShowRegister();
        private void SwitchToLogin(object? sender, EventArgs e) => ShowLogin();

        
        private void CloseAuthPage(object? sender, EventArgs e) => Close();
        private void HideAuthPage(object? sender, EventArgs e) => Hide();

    }
}
