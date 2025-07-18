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
        public event EventHandler? SwitchToLogin;
        public RegisterControl()
        {
            InitializeComponent();
        }

        private void LoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SwitchToLogin?.Invoke(this, e);
        }
    }
}
