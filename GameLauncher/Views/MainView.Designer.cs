namespace GameLauncher;

partial class MainView
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
        NavBarPanel = new Panel();
        LogoutButton = new Button();
        LeftPanel = new Panel();
        RightPanel = new Panel();
        MiddleContentPanel = new Panel();
        NavBarPanel.SuspendLayout();
        SuspendLayout();
        // 
        // NavBarPanel
        // 
        NavBarPanel.BackColor = Color.FromArgb(204, 213, 174);
        NavBarPanel.Controls.Add(LogoutButton);
        NavBarPanel.Dock = DockStyle.Bottom;
        NavBarPanel.Location = new Point(0, 861);
        NavBarPanel.Name = "NavBarPanel";
        NavBarPanel.Size = new Size(1584, 100);
        NavBarPanel.TabIndex = 0;
        // 
        // LogoutButton
        // 
        LogoutButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        LogoutButton.AutoSize = true;
        LogoutButton.BackColor = Color.Transparent;
        LogoutButton.BackgroundImage = (Image)resources.GetObject("LogoutButton.BackgroundImage");
        LogoutButton.BackgroundImageLayout = ImageLayout.Center;
        LogoutButton.FlatAppearance.BorderSize = 0;
        LogoutButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
        LogoutButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
        LogoutButton.FlatStyle = FlatStyle.Flat;
        LogoutButton.Location = new Point(1490, 10);
        LogoutButton.Name = "LogoutButton";
        LogoutButton.Size = new Size(85, 85);
        LogoutButton.TabIndex = 0;
        LogoutButton.UseVisualStyleBackColor = false;
        LogoutButton.Click += LogoutButton_Click;
        // 
        // LeftPanel
        // 
        LeftPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        LeftPanel.Dock = DockStyle.Left;
        LeftPanel.Location = new Point(0, 0);
        LeftPanel.Name = "LeftPanel";
        LeftPanel.Size = new Size(125, 861);
        LeftPanel.TabIndex = 1;
        // 
        // RightPanel
        // 
        RightPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        RightPanel.Dock = DockStyle.Right;
        RightPanel.Location = new Point(1459, 0);
        RightPanel.Name = "RightPanel";
        RightPanel.Size = new Size(125, 861);
        RightPanel.TabIndex = 2;
        // 
        // MiddleContentPanel
        // 
        MiddleContentPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        MiddleContentPanel.BackColor = Color.FromArgb(254, 250, 224);
        MiddleContentPanel.Dock = DockStyle.Fill;
        MiddleContentPanel.Location = new Point(125, 0);
        MiddleContentPanel.Name = "MiddleContentPanel";
        MiddleContentPanel.Size = new Size(1334, 861);
        MiddleContentPanel.TabIndex = 3;
        // 
        // MainView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(212, 163, 115);
        ClientSize = new Size(1584, 961);
        Controls.Add(MiddleContentPanel);
        Controls.Add(RightPanel);
        Controls.Add(LeftPanel);
        Controls.Add(NavBarPanel);
        FormBorderStyle = FormBorderStyle.None;
        Name = "MainView";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        NavBarPanel.ResumeLayout(false);
        NavBarPanel.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel NavBarPanel;
    private Panel LeftPanel;
    private Panel RightPanel;
    private Panel MiddleContentPanel;
    private Button LogoutButton;
}
