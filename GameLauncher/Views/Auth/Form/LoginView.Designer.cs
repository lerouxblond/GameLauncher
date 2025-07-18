namespace GameLauncher.Views.Auth
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            backgroundPicture = new PictureBox();
            FormGroup = new GroupBox();
            FieldLayout = new TableLayoutPanel();
            PasswordFieldLayout = new TableLayoutPanel();
            PasswordInput = new TextBox();
            PasswordLabel = new Label();
            UsernameFieldLayout = new TableLayoutPanel();
            UsernameInputField = new TextBox();
            UsernameInputLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ForgotPasswordLinkLabel = new LinkLabel();
            StaySignedCheckBox = new CheckBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            LoginButton = new Button();
            RegisterLink = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)backgroundPicture).BeginInit();
            FormGroup.SuspendLayout();
            FieldLayout.SuspendLayout();
            PasswordFieldLayout.SuspendLayout();
            UsernameFieldLayout.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // backgroundPicture
            // 
            backgroundPicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            backgroundPicture.Image = (Image)resources.GetObject("backgroundPicture.Image");
            backgroundPicture.Location = new Point(-7, -30);
            backgroundPicture.Name = "backgroundPicture";
            backgroundPicture.Size = new Size(1200, 800);
            backgroundPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            backgroundPicture.TabIndex = 0;
            backgroundPicture.TabStop = false;
            // 
            // FormGroup
            // 
            FormGroup.AutoSize = true;
            FormGroup.BackColor = Color.White;
            FormGroup.BackgroundImageLayout = ImageLayout.None;
            FormGroup.Controls.Add(FieldLayout);
            FormGroup.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FormGroup.Location = new Point(800, 225);
            FormGroup.Name = "FormGroup";
            FormGroup.Padding = new Padding(0);
            FormGroup.Size = new Size(300, 320);
            FormGroup.TabIndex = 1;
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
            FieldLayout.Controls.Add(tableLayoutPanel1, 0, 2);
            FieldLayout.Controls.Add(tableLayoutPanel2, 0, 3);
            FieldLayout.Location = new Point(34, 19);
            FieldLayout.Name = "FieldLayout";
            FieldLayout.Padding = new Padding(5);
            FieldLayout.RowCount = 4;
            FieldLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 49.6598625F));
            FieldLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50.3401375F));
            FieldLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            FieldLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            FieldLayout.Size = new Size(238, 282);
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
            PasswordFieldLayout.TabIndex = 3;
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
            UsernameFieldLayout.TabIndex = 2;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(ForgotPasswordLinkLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(StaySignedCheckBox, 0, 0);
            tableLayoutPanel1.Location = new Point(8, 155);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(120, 60);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // ForgotPasswordLinkLabel
            // 
            ForgotPasswordLinkLabel.AutoSize = true;
            ForgotPasswordLinkLabel.Location = new Point(8, 35);
            ForgotPasswordLinkLabel.Margin = new Padding(3, 5, 3, 0);
            ForgotPasswordLinkLabel.Name = "ForgotPasswordLinkLabel";
            ForgotPasswordLinkLabel.Size = new Size(104, 15);
            ForgotPasswordLinkLabel.TabIndex = 0;
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(LoginButton, 0, 0);
            tableLayoutPanel2.Location = new Point(8, 224);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(216, 46);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.WhiteSmoke;
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LoginButton.Location = new Point(3, 3);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(210, 40);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "LOGIN";
            LoginButton.UseVisualStyleBackColor = false;
            // 
            // RegisterLink
            // 
            RegisterLink.AutoSize = true;
            RegisterLink.Location = new Point(800, 548);
            RegisterLink.Name = "RegisterLink";
            RegisterLink.Size = new Size(81, 15);
            RegisterLink.TabIndex = 2;
            RegisterLink.TabStop = true;
            RegisterLink.Text = "Go to Register";
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(RegisterLink);
            Controls.Add(FormGroup);
            Controls.Add(backgroundPicture);
            Name = "LoginView";
            Text = "LoginView";
            ((System.ComponentModel.ISupportInitialize)backgroundPicture).EndInit();
            FormGroup.ResumeLayout(false);
            FormGroup.PerformLayout();
            FieldLayout.ResumeLayout(false);
            FieldLayout.PerformLayout();
            PasswordFieldLayout.ResumeLayout(false);
            PasswordFieldLayout.PerformLayout();
            UsernameFieldLayout.ResumeLayout(false);
            UsernameFieldLayout.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox backgroundPicture;
        private GroupBox FormGroup;
        private TextBox UsernameInputField;
        private TableLayoutPanel UsernameFieldLayout;
        private Label UsernameInputLabel;
        private TableLayoutPanel PasswordFieldLayout;
        private TextBox PasswordInput;
        private Label PasswordLabel;
        private TableLayoutPanel FieldLayout;
        private TableLayoutPanel tableLayoutPanel1;
        private LinkLabel ForgotPasswordLinkLabel;
        private CheckBox StaySignedCheckBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Button LoginButton;
        private LinkLabel RegisterLink;
    }
}