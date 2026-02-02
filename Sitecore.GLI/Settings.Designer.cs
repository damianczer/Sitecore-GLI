namespace Sitecore.GLI
{
    partial class Settings
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            minimize = new Button();
            exit = new Button();
            logotopbar = new PictureBox();
            name = new Label();
            topbar = new PictureBox();
            logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logotopbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)topbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // minimize
            // 
            minimize.BackColor = SystemColors.ActiveCaptionText;
            minimize.BackgroundImage = (Image)resources.GetObject("minimize.BackgroundImage");
            minimize.BackgroundImageLayout = ImageLayout.None;
            minimize.Cursor = Cursors.Hand;
            minimize.FlatStyle = FlatStyle.Flat;
            minimize.Location = new Point(734, 2);
            minimize.Name = "minimize";
            minimize.Size = new Size(26, 29);
            minimize.TabIndex = 14;
            minimize.UseVisualStyleBackColor = false;
            minimize.Click += minimize_Click;
            // 
            // exit
            // 
            exit.BackColor = SystemColors.ActiveCaptionText;
            exit.BackgroundImage = (Image)resources.GetObject("exit.BackgroundImage");
            exit.BackgroundImageLayout = ImageLayout.None;
            exit.Cursor = Cursors.Hand;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Location = new Point(758, 2);
            exit.Name = "exit";
            exit.Size = new Size(30, 29);
            exit.TabIndex = 13;
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            exit.MouseEnter += exit_MouseEnter;
            exit.MouseLeave += exit_MouseLeave;
            // 
            // logotopbar
            // 
            logotopbar.BackColor = SystemColors.ActiveCaptionText;
            logotopbar.BackgroundImage = (Image)resources.GetObject("logotopbar.BackgroundImage");
            logotopbar.BackgroundImageLayout = ImageLayout.Stretch;
            logotopbar.Location = new Point(-117, 217);
            logotopbar.Name = "logotopbar";
            logotopbar.Size = new Size(18, 17);
            logotopbar.TabIndex = 12;
            logotopbar.TabStop = false;
            // 
            // name
            // 
            name.AutoSize = true;
            name.BackColor = SystemColors.ActiveCaptionText;
            name.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            name.ForeColor = SystemColors.ButtonHighlight;
            name.Location = new Point(26, 8);
            name.Name = "name";
            name.Size = new Size(133, 15);
            name.TabIndex = 11;
            name.Text = "Sitecore GLI [Settings]";
            // 
            // topbar
            // 
            topbar.BackColor = SystemColors.ActiveCaptionText;
            topbar.Location = new Point(-1, -3);
            topbar.Name = "topbar";
            topbar.Size = new Size(788, 34);
            topbar.TabIndex = 10;
            topbar.TabStop = false;
            topbar.MouseDown += topbar_MouseDown;
            topbar.MouseMove += topbar_MouseMove;
            topbar.MouseUp += topbar_MouseUp;
            // 
            // logo
            // 
            logo.BackColor = SystemColors.ActiveCaptionText;
            logo.BackgroundImage = (Image)resources.GetObject("logo.BackgroundImage");
            logo.BackgroundImageLayout = ImageLayout.Stretch;
            logo.Location = new Point(7, 6);
            logo.Name = "logo";
            logo.Size = new Size(18, 17);
            logo.TabIndex = 15;
            logo.TabStop = false;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(785, 538);
            Controls.Add(logo);
            Controls.Add(minimize);
            Controls.Add(exit);
            Controls.Add(logotopbar);
            Controls.Add(name);
            Controls.Add(topbar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)logotopbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)topbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button minimize;
        private Button exit;
        private PictureBox logotopbar;
        private Label name;
        private PictureBox topbar;
        private PictureBox logo;
    }
}