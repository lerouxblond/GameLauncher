namespace GameLauncher.Views.Auth
{
    partial class RegisterView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterView));
            BackgroundPicture = new PictureBox();
            FormGroup = new GroupBox();
            FieldLayout = new TableLayoutPanel();
            EmailLayout = new TableLayoutPanel();
            EmailFieldInput = new TextBox();
            EmailFieldLabel = new Label();
            UsernameFieldLayout = new TableLayoutPanel();
            UsernameInputField = new TextBox();
            UsernameInputLabel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            RegisterButton = new Button();
            PasswordFieldLayout = new TableLayoutPanel();
            PasswordInput = new TextBox();
            PasswordLabel = new Label();
            LoginLink = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)BackgroundPicture).BeginInit();
            FormGroup.SuspendLayout();
            FieldLayout.SuspendLayout();
            EmailLayout.SuspendLayout();
            UsernameFieldLayout.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            PasswordFieldLayout.SuspendLayout();
            SuspendLayout();
            // 
            // BackgroundPicture
            // 
            BackgroundPicture.Image = (Image)resources.GetObject("BackgroundPicture.Image");
            BackgroundPicture.Location = new Point(-7, -31);
            BackgroundPicture.Name = "BackgroundPicture";
            BackgroundPicture.Size = new Size(1200, 800);
            BackgroundPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            BackgroundPicture.TabIndex = 0;
            BackgroundPicture.TabStop = false;
            // 
            // FormGroup
            // 
            FormGroup.AutoSize = true;
            FormGroup.BackColor = Color.White;
            FormGroup.BackgroundImageLayout = ImageLayout.None;
            FormGroup.Controls.Add(FieldLayout);
            FormGroup.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FormGroup.Location = new Point(80, 245);
            FormGroup.Name = "FormGroup";
            FormGroup.Padding = new Padding(0);
            FormGroup.Size = new Size(289, 320);
            FormGroup.TabIndex = 2;
            FormGroup.TabStop = false;
            FormGroup.Text = "REGISTER FORM";
            // 
            // FieldLayout
            // 
            FieldLayout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FieldLayout.AutoSize = true;
            FieldLayout.ColumnCount = 1;
            FieldLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            FieldLayout.Controls.Add(EmailLayout, 0, 1);
            FieldLayout.Controls.Add(UsernameFieldLayout, 0, 0);
            FieldLayout.Controls.Add(tableLayoutPanel2, 0, 3);
            FieldLayout.Controls.Add(PasswordFieldLayout, 0, 2);
            FieldLayout.Location = new Point(31, 16);
            FieldLayout.Name = "FieldLayout";
            FieldLayout.Padding = new Padding(5);
            FieldLayout.RowCount = 4;
            FieldLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 49.6598625F));
            FieldLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50.3401375F));
            FieldLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            FieldLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            FieldLayout.Size = new Size(235, 282);
            FieldLayout.TabIndex = 4;
            // 
            // EmailLayout
            // 
            EmailLayout.AutoSize = true;
            EmailLayout.BackColor = Color.Transparent;
            EmailLayout.ColumnCount = 1;
            EmailLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            EmailLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            EmailLayout.Controls.Add(EmailFieldInput, 0, 1);
            EmailLayout.Controls.Add(EmailFieldLabel, 0, 0);
            EmailLayout.Location = new Point(8, 81);
            EmailLayout.Name = "EmailLayout";
            EmailLayout.Padding = new Padding(5);
            EmailLayout.RowCount = 1;
            EmailLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 35.7142868F));
            EmailLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 64.28571F));
            EmailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            EmailLayout.Size = new Size(216, 63);
            EmailLayout.TabIndex = 6;
            // 
            // EmailFieldInput
            // 
            EmailFieldInput.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EmailFieldInput.Location = new Point(8, 26);
            EmailFieldInput.Name = "EmailFieldInput";
            EmailFieldInput.PlaceholderText = "Enter Email";
            EmailFieldInput.Size = new Size(200, 23);
            EmailFieldInput.TabIndex = 1;
            // 
            // EmailFieldLabel
            // 
            EmailFieldLabel.AutoSize = true;
            EmailFieldLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            EmailFieldLabel.Location = new Point(8, 5);
            EmailFieldLabel.Name = "EmailFieldLabel";
            EmailFieldLabel.Size = new Size(45, 18);
            EmailFieldLabel.TabIndex = 2;
            EmailFieldLabel.Text = "Email";
            EmailFieldLabel.TextAlign = ContentAlignment.BottomCenter;
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(RegisterButton, 0, 0);
            tableLayoutPanel2.Location = new Point(8, 224);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(216, 46);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.WhiteSmoke;
            RegisterButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            RegisterButton.Location = new Point(3, 3);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(210, 40);
            RegisterButton.TabIndex = 0;
            RegisterButton.Text = "REGISTER";
            RegisterButton.UseVisualStyleBackColor = false;
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
            PasswordFieldLayout.Location = new Point(8, 155);
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
            // LoginLink
            // 
            LoginLink.AutoSize = true;
            LoginLink.Location = new Point(300, 568);
            LoginLink.Name = "LoginLink";
            LoginLink.Size = new Size(69, 15);
            LoginLink.TabIndex = 3;
            LoginLink.TabStop = true;
            LoginLink.Text = "Go to Login";
            // 
            // RegisterView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(LoginLink);
            Controls.Add(FormGroup);
            Controls.Add(BackgroundPicture);
            Name = "RegisterView";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "RegisterView";
            ((System.ComponentModel.ISupportInitialize)BackgroundPicture).EndInit();
            FormGroup.ResumeLayout(false);
            FormGroup.PerformLayout();
            FieldLayout.ResumeLayout(false);
            FieldLayout.PerformLayout();
            EmailLayout.ResumeLayout(false);
            EmailLayout.PerformLayout();
            UsernameFieldLayout.ResumeLayout(false);
            UsernameFieldLayout.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            PasswordFieldLayout.ResumeLayout(false);
            PasswordFieldLayout.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox BackgroundPicture;
        private GroupBox FormGroup;
        private TableLayoutPanel FieldLayout;
        private TableLayoutPanel PasswordFieldLayout;
        private TextBox PasswordInput;
        private Label PasswordLabel;
        private TableLayoutPanel UsernameFieldLayout;
        private TextBox UsernameInputField;
        private Label UsernameInputLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private Button RegisterButton;
        private TableLayoutPanel EmailLayout;
        private TextBox EmailFieldInput;
        private Label EmailFieldLabel;
        private LinkLabel LoginLink;
    }
}