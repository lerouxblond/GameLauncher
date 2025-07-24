using GameLauncher.Controllers.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher.Views.Auth.Control
{
    public partial class LoginControl : UserControl
    {
        public event EventHandler? SwitchToRegister, CloseAuthPage, UserLogged;
        private AuthController _authController;

        public LoginControl(AuthController authController = null!)
        {
            _authController = authController;
            InitializeComponent();
        }


        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SwitchToRegister?.Invoke(this, e);
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            CloseAuthPage?.Invoke(this, e);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var identifier = UsernameInputField.Text;
            var password = PasswordInput.Text;
            var stayConnected = StaySignedCheckBox.Checked;

            var result = _authController.Login(identifier, password, stayConnected);

            if(!result.Success)
            {
                MessageBox.Show(result.Message);
                return;
            }

            UserLogged?.Invoke(this, e);
        }

    }
}
