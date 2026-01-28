namespace Sitecore.GLI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            topbar = new PictureBox();
            logo = new PictureBox();
            leftbar = new PictureBox();
            rightbar = new PictureBox();
            bottombar = new PictureBox();
            name = new Label();
            logotopbar = new PictureBox();
            exit = new Button();
            minimize = new Button();
            author = new Label();
            ((System.ComponentModel.ISupportInitialize)topbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bottombar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logotopbar).BeginInit();
            SuspendLayout();
            // 
            // topbar
            // 
            topbar.BackColor = SystemColors.ActiveCaptionText;
            topbar.Location = new Point(-1, -1);
            topbar.Name = "topbar";
            topbar.Size = new Size(801, 34);
            topbar.TabIndex = 0;
            topbar.TabStop = false;
            topbar.MouseDown += topbar_MouseDown;
            topbar.MouseMove += topbar_MouseMove;
            topbar.MouseUp += topbar_MouseUp;
            // 
            // logo
            // 
            logo.BackgroundImage = (Image)resources.GetObject("logo.BackgroundImage");
            logo.BackgroundImageLayout = ImageLayout.Stretch;
            logo.Location = new Point(598, 347);
            logo.Name = "logo";
            logo.Size = new Size(219, 129);
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // leftbar
            // 
            leftbar.BackColor = SystemColors.ActiveCaptionText;
            leftbar.Location = new Point(-8, 24);
            leftbar.Name = "leftbar";
            leftbar.Size = new Size(10, 503);
            leftbar.TabIndex = 2;
            leftbar.TabStop = false;
            // 
            // rightbar
            // 
            rightbar.BackColor = SystemColors.ActiveCaptionText;
            rightbar.Location = new Point(798, 24);
            rightbar.Name = "rightbar";
            rightbar.Size = new Size(10, 503);
            rightbar.TabIndex = 3;
            rightbar.TabStop = false;
            // 
            // bottombar
            // 
            bottombar.BackColor = SystemColors.ActiveCaptionText;
            bottombar.Location = new Point(-1, 448);
            bottombar.Name = "bottombar";
            bottombar.Size = new Size(801, 18);
            bottombar.TabIndex = 4;
            bottombar.TabStop = false;
            // 
            // name
            // 
            name.AutoSize = true;
            name.BackColor = SystemColors.ActiveCaptionText;
            name.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            name.ForeColor = SystemColors.ButtonHighlight;
            name.Location = new Point(26, 9);
            name.Name = "name";
            name.Size = new Size(76, 15);
            name.TabIndex = 6;
            name.Text = "Sitecore GLI";
            // 
            // logotopbar
            // 
            logotopbar.BackColor = SystemColors.ActiveCaptionText;
            logotopbar.BackgroundImage = (Image)resources.GetObject("logotopbar.BackgroundImage");
            logotopbar.BackgroundImageLayout = ImageLayout.Stretch;
            logotopbar.Location = new Point(7, 8);
            logotopbar.Name = "logotopbar";
            logotopbar.Size = new Size(18, 17);
            logotopbar.TabIndex = 7;
            logotopbar.TabStop = false;
            // 
            // exit
            // 
            exit.BackColor = SystemColors.ActiveCaptionText;
            exit.BackgroundImage = (Image)resources.GetObject("exit.BackgroundImage");
            exit.BackgroundImageLayout = ImageLayout.None;
            exit.Cursor = Cursors.Hand;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Location = new Point(770, 4);
            exit.Name = "exit";
            exit.Size = new Size(30, 29);
            exit.TabIndex = 8;
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            exit.MouseEnter += exit_MouseEnter;
            exit.MouseLeave += exit_MouseLeave;
            // 
            // minimize
            // 
            minimize.BackColor = SystemColors.ActiveCaptionText;
            minimize.BackgroundImage = (Image)resources.GetObject("minimize.BackgroundImage");
            minimize.BackgroundImageLayout = ImageLayout.None;
            minimize.Cursor = Cursors.Hand;
            minimize.FlatStyle = FlatStyle.Flat;
            minimize.Location = new Point(745, 4);
            minimize.Name = "minimize";
            minimize.Size = new Size(26, 29);
            minimize.TabIndex = 9;
            minimize.UseVisualStyleBackColor = false;
            minimize.Click += minimize_Click;
            // 
            // author
            // 
            author.AutoSize = true;
            author.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            author.ForeColor = SystemColors.ControlDarkDark;
            author.Location = new Point(674, 421);
            author.Name = "author";
            author.Size = new Size(105, 13);
            author.TabIndex = 10;
            author.Text = "Damian Czerwiński";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(author);
            Controls.Add(minimize);
            Controls.Add(exit);
            Controls.Add(logotopbar);
            Controls.Add(name);
            Controls.Add(bottombar);
            Controls.Add(rightbar);
            Controls.Add(leftbar);
            Controls.Add(logo);
            Controls.Add(topbar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)topbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)bottombar).EndInit();
            ((System.ComponentModel.ISupportInitialize)logotopbar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private PictureBox topbar;
        private PictureBox logo;
        private PictureBox leftbar;
        private PictureBox rightbar;
        private PictureBox bottombar;
        private Label name;
        private PictureBox logotopbar;
        private Button exit;
        private Button minimize;
        private Label author;
    }
}
