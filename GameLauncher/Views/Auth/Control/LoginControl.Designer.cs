﻿namespace GameLauncher.Views.Auth.Control
{
    partial class LoginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginControl));
            backgroundPicture = new PictureBox();
            FormGroup = new GroupBox();
            FieldLayout = new TableLayoutPanel();
            PasswordFieldLayout = new TableLayoutPanel();
            PasswordInput = new TextBox();
            PasswordLabel = new Label();
            UsernameFieldLayout = new TableLayoutPanel();
            UsernameInputField = new TextBox();
            UsernameInputLabel = new Label();
            HelpPanel = new TableLayoutPanel();
            ForgotPasswordLinkLabel = new LinkLabel();
            StaySignedCheckBox = new CheckBox();
            buttonLayoutPanel = new TableLayoutPanel();
            LoginButton = new Button();
            RegisterLink = new LinkLabel();
            CloseBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)backgroundPicture).BeginInit();
            FormGroup.SuspendLayout();
            FieldLayout.SuspendLayout();
            PasswordFieldLayout.SuspendLayout();
            UsernameFieldLayout.SuspendLayout();
            HelpPanel.SuspendLayout();
            buttonLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // backgroundPicture
            // 
            backgroundPicture.Dock = DockStyle.Fill;
            backgroundPicture.Image = (Image)resources.GetObject("backgroundPicture.Image");
            backgroundPicture.Location = new Point(0, 0);
            backgroundPicture.Name = "backgroundPicture";
            backgroundPicture.Size = new Size(1200, 800);
            backgroundPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            backgroundPicture.TabIndex = 1;
            backgroundPicture.TabStop = false;
            // 
            // FormGroup
            // 
            FormGroup.AutoSize = true;
            FormGroup.BackColor = Color.White;
            FormGroup.BackgroundImageLayout = ImageLayout.None;
            FormGroup.Controls.Add(FieldLayout);
            FormGroup.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FormGroup.Location = new Point(822, 214);
            FormGroup.Name = "FormGroup";
            FormGroup.Padding = new Padding(0);
            FormGroup.Size = new Size(300, 320);
            FormGroup.TabIndex = 2;
            FormGroup.TabStop = false;
            FormGroup.Text = "LOGIN FORM";
            // 
            // FieldLayout
            // 
            FieldLayout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FieldLayout.AutoSize = true;
            FieldLayout.ColumnCount = 1;
            FieldLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            FieldLayout.Controls.Add(PasswordFieldLayout, 0, 1);
            FieldLayout.Controls.Add(UsernameFieldLayout, 0, 0);
            FieldLayout.Controls.Add(HelpPanel, 0, 2);
            FieldLayout.Controls.Add(buttonLayoutPanel, 0, 3);
            FieldLayout.Location = new Point(31, 16);
            FieldLayout.Name = "FieldLayout";
            FieldLayout.Padding = new Padding(5);
            FieldLayout.RowCount = 4;
            FieldLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 49.6598625F));
            FieldLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50.3401375F));
            FieldLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            FieldLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            FieldLayout.Size = new Size(344, 282);
            FieldLayout.TabIndex = 4;
            // 
            // PasswordFieldLayout
            // 
            PasswordFieldLayout.AutoSize = true;
            PasswordFieldLayout.BackColor = Color.Transparent;
            PasswordFieldLayout.ColumnCount = 1;
            PasswordFieldLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PasswordFieldLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PasswordFieldLayout.Controls.Add(PasswordInput, 0, 1);
            PasswordFieldLayout.Controls.Add(PasswordLabel, 0, 0);
            PasswordFieldLayout.Location = new Point(8, 81);
            PasswordFieldLayout.Name = "PasswordFieldLayout";
            PasswordFieldLayout.Padding = new Padding(5);
            PasswordFieldLayout.RowCount = 1;
            PasswordFieldLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 35.7142868F));
            PasswordFieldLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 64.28571F));
            PasswordFieldLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            PasswordFieldLayout.Size = new Size(216, 63);
            PasswordFieldLayout.TabIndex = 2;
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(8, 26);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PlaceholderText = "Enter Password";
            PasswordInput.Size = new Size(200, 23);
            PasswordInput.TabIndex = 1;
            PasswordInput.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            PasswordLabel.Location = new Point(8, 5);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(73, 18);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Password";
            PasswordLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // UsernameFieldLayout
            // 
            UsernameFieldLayout.AutoSize = true;
            UsernameFieldLayout.BackColor = Color.Transparent;
            UsernameFieldLayout.ColumnCount = 1;
            UsernameFieldLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            UsernameFieldLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            UsernameFieldLayout.Controls.Add(UsernameInputField, 0, 1);
            UsernameFieldLayout.Controls.Add(UsernameInputLabel, 0, 0);
            UsernameFieldLayout.Location = new Point(8, 8);
            UsernameFieldLayout.Name = "UsernameFieldLayout";
            UsernameFieldLayout.Padding = new Padding(5);
            UsernameFieldLayout.RowCount = 1;
            UsernameFieldLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 35.7142868F));
            UsernameFieldLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 64.28571F));
            UsernameFieldLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            UsernameFieldLayout.Size = new Size(216, 63);
            UsernameFieldLayout.TabIndex = 1;
            // 
            // UsernameInputField
            // 
            UsernameInputField.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            UsernameInputField.Location = new Point(8, 26);
            UsernameInputField.Name = "UsernameInputField";
            UsernameInputField.PlaceholderText = "Enter Username";
            UsernameInputField.Size = new Size(200, 23);
            UsernameInputField.TabIndex = 1;
            // 
            // UsernameInputLabel
            // 
            UsernameInputLabel.AutoSize = true;
            UsernameInputLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            UsernameInputLabel.Location = new Point(8, 5);
            UsernameInputLabel.Name = "UsernameInputLabel";
            UsernameInputLabel.Size = new Size(76, 18);
            UsernameInputLabel.TabIndex = 2;
            UsernameInputLabel.Text = "Username";
            UsernameInputLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // HelpPanel
            // 
            HelpPanel.AutoSize = true;
            HelpPanel.ColumnCount = 1;
            HelpPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            HelpPanel.Controls.Add(ForgotPasswordLinkLabel, 0, 1);
            HelpPanel.Controls.Add(StaySignedCheckBox, 0, 0);
            HelpPanel.Location = new Point(8, 155);
            HelpPanel.Name = "HelpPanel";
            HelpPanel.Padding = new Padding(5);
            HelpPanel.RowCount = 2;
            HelpPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            HelpPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            HelpPanel.Size = new Size(120, 60);
            HelpPanel.TabIndex = 4;
            // 
            // ForgotPasswordLinkLabel
            // 
            ForgotPasswordLinkLabel.AutoSize = true;
            ForgotPasswordLinkLabel.Location = new Point(8, 35);
            ForgotPasswordLinkLabel.Margin = new Padding(3, 5, 3, 0);
            ForgotPasswordLinkLabel.Name = "ForgotPasswordLinkLabel";
            ForgotPasswordLinkLabel.Size = new Size(104, 15);
            ForgotPasswordLinkLabel.TabIndex = 2;
            ForgotPasswordLinkLabel.TabStop = true;
            ForgotPasswordLinkLabel.Text = "Forgot password?";
            ForgotPasswordLinkLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StaySignedCheckBox
            // 
            StaySignedCheckBox.AutoSize = true;
            StaySignedCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            StaySignedCheckBox.Location = new Point(8, 8);
            StaySignedCheckBox.Name = "StaySignedCheckBox";
            StaySignedCheckBox.Size = new Size(97, 19);
            StaySignedCheckBox.TabIndex = 1;
            StaySignedCheckBox.Text = "Stay signed ?";
            StaySignedCheckBox.UseVisualStyleBackColor = true;
            // 
            // buttonLayoutPanel
            // 
            buttonLayoutPanel.AutoSize = true;
            buttonLayoutPanel.BackColor = Color.Transparent;
            buttonLayoutPanel.ColumnCount = 1;
            buttonLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            buttonLayoutPanel.Controls.Add(LoginButton, 0, 0);
            buttonLayoutPanel.Location = new Point(8, 224);
            buttonLayoutPanel.Name = "buttonLayoutPanel";
            buttonLayoutPanel.RowCount = 1;
            buttonLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            buttonLayoutPanel.Size = new Size(216, 46);
            buttonLayoutPanel.TabIndex = 4;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.WhiteSmoke;
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LoginButton.Location = new Point(3, 3);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(210, 40);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "LOGIN";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // RegisterLink
            // 
            RegisterLink.AutoSize = true;
            RegisterLink.Location = new Point(822, 537);
            RegisterLink.Name = "RegisterLink";
            RegisterLink.Size = new Size(81, 15);
            RegisterLink.TabIndex = 5;
            RegisterLink.TabStop = true;
            RegisterLink.Text = "Go to Register";
            RegisterLink.LinkClicked += RegisterLink_LinkClicked;
            // 
            // CloseBTN
            // 
            CloseBTN.AutoSize = true;
            CloseBTN.BackColor = Color.White;
            CloseBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CloseBTN.Location = new Point(1122, 3);
            CloseBTN.Name = "CloseBTN";
            CloseBTN.Size = new Size(75, 31);
            CloseBTN.TabIndex = 6;
            CloseBTN.Text = "Close";
            CloseBTN.UseVisualStyleBackColor = false;
            CloseBTN.Click += CloseBTN_Click;
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CloseBTN);
            Controls.Add(RegisterLink);
            Controls.Add(FormGroup);
            Controls.Add(backgroundPicture);
            Name = "LoginControl";
            Size = new Size(1200, 800);
            ((System.ComponentModel.ISupportInitialize)backgroundPicture).EndInit();
            FormGroup.ResumeLayout(false);
            FormGroup.PerformLayout();
            FieldLayout.ResumeLayout(false);
            FieldLayout.PerformLayout();
            PasswordFieldLayout.ResumeLayout(false);
            PasswordFieldLayout.PerformLayout();
            UsernameFieldLayout.ResumeLayout(false);
            UsernameFieldLayout.PerformLayout();
            HelpPanel.ResumeLayout(false);
            HelpPanel.PerformLayout();
            buttonLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox backgroundPicture;
        private GroupBox FormGroup;
        private TableLayoutPanel FieldLayout;
        private TableLayoutPanel PasswordFieldLayout;
        private TextBox PasswordInput;
        private Label PasswordLabel;
        private TableLayoutPanel UsernameFieldLayout;
        private TextBox UsernameInputField;
        private Label UsernameInputLabel;
        private TableLayoutPanel HelpPanel;
        private LinkLabel ForgotPasswordLinkLabel;
        private CheckBox StaySignedCheckBox;
        private TableLayoutPanel buttonLayoutPanel;
        private Button LoginButton;
        private LinkLabel RegisterLink;
        private Button CloseBTN;
    }
}
