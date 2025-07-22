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
        NavBarPanel = new Panel();
        LeftPanel = new Panel();
        RightPanel = new Panel();
        MiddleContentPanel = new Panel();
        TestLabel = new Label();
        MiddleContentPanel.SuspendLayout();
        SuspendLayout();
        // 
        // NavBarPanel
        // 
        NavBarPanel.BackColor = Color.FromArgb(204, 213, 174);
        NavBarPanel.Dock = DockStyle.Bottom;
        NavBarPanel.Location = new Point(0, 861);
        NavBarPanel.Name = "NavBarPanel";
        NavBarPanel.Size = new Size(1584, 100);
        NavBarPanel.TabIndex = 0;
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
        MiddleContentPanel.Controls.Add(TestLabel);
        MiddleContentPanel.Dock = DockStyle.Fill;
        MiddleContentPanel.Location = new Point(125, 0);
        MiddleContentPanel.Name = "MiddleContentPanel";
        MiddleContentPanel.Size = new Size(1334, 861);
        MiddleContentPanel.TabIndex = 3;
        // 
        // TestLabel
        // 
        TestLabel.AutoSize = true;
        TestLabel.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
        TestLabel.Location = new Point(603, 403);
        TestLabel.Name = "TestLabel";
        TestLabel.Size = new Size(214, 46);
        TestLabel.TabIndex = 0;
        TestLabel.Text = "This is a test";
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
        MiddleContentPanel.ResumeLayout(false);
        MiddleContentPanel.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel NavBarPanel;
    private Panel LeftPanel;
    private Panel RightPanel;
    private Panel MiddleContentPanel;
    private Label TestLabel;
}
