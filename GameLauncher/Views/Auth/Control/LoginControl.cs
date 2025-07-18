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
        public event EventHandler? SwitchToRegister;

        public LoginControl()
        {
            InitializeComponent();
        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SwitchToRegister?.Invoke(this, e);
        }
    }
}
