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
    public partial class RegisterControl : UserControl
    {
        public event EventHandler? SwitchToLogin, CloseAuthPage, UserRegister;
        private readonly AuthController _authController;

        public RegisterControl(AuthController authController = null!)
        {
            _authController = authController;
            InitializeComponent();
        }

        private void LoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SwitchToLogin?.Invoke(this, e);
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            CloseAuthPage?.Invoke(this, e);
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var username = UsernameInputField.Text;
            var email = EmailFieldInput.Text;
            var password = PasswordInput.Text;

            var result = _authController.Register(username, email, password);

            if(!result.Success)
            {
                MessageBox.Show(result.Message);
                return;
            }

            UserRegister?.Invoke(sender, e);
        }
    }
}
