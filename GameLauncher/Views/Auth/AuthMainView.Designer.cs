namespace GameLauncher.Views.Auth
{
    partial class AuthMainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pagePanel = new Panel();
            loginControlForm = new GameLauncher.Views.Auth.Control.LoginControl();
            registerControlForm = new GameLauncher.Views.Auth.Control.RegisterControl();
            pagePanel.SuspendLayout();
            SuspendLayout();
            // 
            // pagePanel
            // 
            pagePanel.Controls.Add(loginControlForm);
            pagePanel.Controls.Add(registerControlForm);
            pagePanel.Dock = DockStyle.Fill;
            pagePanel.Location = new Point(0, 0);
            pagePanel.Name = "pagePanel";
            pagePanel.Size = new Size(1184, 761);
            pagePanel.TabIndex = 0;
            // 
            // loginControlForm
            // 
            loginControlForm.Dock = DockStyle.Fill;
            loginControlForm.Location = new Point(0, 0);
            loginControlForm.Name = "loginControlForm";
            loginControlForm.Size = new Size(1184, 761);
            loginControlForm.TabIndex = 1;
            // 
            // registerControlForm
            // 
            registerControlForm.Dock = DockStyle.Fill;
            registerControlForm.Location = new Point(0, 0);
            registerControlForm.Name = "registerControlForm";
            registerControlForm.Size = new Size(1184, 761);
            registerControlForm.TabIndex = 0;
            // 
            // AuthMainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(pagePanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AuthMainView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AuthMainView";
            pagePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pagePanel;
        private Control.RegisterControl registerControlForm;
        private Control.LoginControl loginControlForm;
    }
}