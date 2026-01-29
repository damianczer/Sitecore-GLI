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
            components = new System.ComponentModel.Container();
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
            console = new TextBox();
            settings = new Button();
            consoletopbar = new PictureBox();
            consoletopbarlabel = new Label();
            pictureBox1 = new PictureBox();
            pull = new Button();
            push = new Button();
            rights = new Label();
            help = new Button();
            delete = new Button();
            pullall = new Button();
            pushall = new Button();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            install = new Button();
            toolsrestore = new Button();
            commands = new Button();
            login = new Button();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            textBox2 = new TextBox();
            tooltip = new ToolTip(components);
            powershell = new Button();
            ((System.ComponentModel.ISupportInitialize)topbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bottombar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logotopbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)consoletopbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // topbar
            // 
            topbar.BackColor = SystemColors.ActiveCaptionText;
            topbar.Location = new Point(-1, -1);
            topbar.Name = "topbar";
            topbar.Size = new Size(1050, 34);
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
            logo.Cursor = Cursors.Hand;
            logo.Location = new Point(840, 539);
            logo.Name = "logo";
            logo.Size = new Size(219, 129);
            logo.TabIndex = 1;
            logo.TabStop = false;
            logo.Click += logo_Click;
            // 
            // leftbar
            // 
            leftbar.BackColor = SystemColors.ActiveCaptionText;
            leftbar.Location = new Point(-8, 24);
            leftbar.Name = "leftbar";
            leftbar.Size = new Size(10, 636);
            leftbar.TabIndex = 2;
            leftbar.TabStop = false;
            // 
            // rightbar
            // 
            rightbar.BackColor = SystemColors.ActiveCaptionText;
            rightbar.Location = new Point(1045, 4);
            rightbar.Name = "rightbar";
            rightbar.Size = new Size(10, 651);
            rightbar.TabIndex = 3;
            rightbar.TabStop = false;
            // 
            // bottombar
            // 
            bottombar.BackColor = SystemColors.ActiveCaptionText;
            bottombar.Location = new Point(-1, 648);
            bottombar.Name = "bottombar";
            bottombar.Size = new Size(1056, 18);
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
            exit.Location = new Point(1017, 4);
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
            minimize.Location = new Point(992, 4);
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
            author.Location = new Point(916, 613);
            author.Name = "author";
            author.Size = new Size(105, 13);
            author.TabIndex = 10;
            author.Text = "Damian Czerwiński";
            // 
            // console
            // 
            console.BackColor = SystemColors.InactiveCaptionText;
            console.BorderStyle = BorderStyle.None;
            console.Enabled = false;
            console.HideSelection = false;
            console.Location = new Point(8, 58);
            console.Multiline = true;
            console.Name = "console";
            console.ScrollBars = ScrollBars.Vertical;
            console.Size = new Size(960, 280);
            console.TabIndex = 11;
            // 
            // settings
            // 
            settings.BackColor = Color.FromArgb(254, 41, 17);
            settings.BackgroundImage = (Image)resources.GetObject("settings.BackgroundImage");
            settings.BackgroundImageLayout = ImageLayout.Center;
            settings.Cursor = Cursors.Hand;
            settings.FlatAppearance.BorderSize = 0;
            settings.FlatStyle = FlatStyle.Flat;
            settings.ForeColor = SystemColors.ActiveCaptionText;
            settings.Location = new Point(974, 147);
            settings.Name = "settings";
            settings.Size = new Size(65, 48);
            settings.TabIndex = 12;
            tooltip.SetToolTip(settings, "Application Settings");
            settings.UseVisualStyleBackColor = false;
            // 
            // consoletopbar
            // 
            consoletopbar.BackColor = Color.FromArgb(254, 41, 17);
            consoletopbar.Location = new Point(8, 39);
            consoletopbar.Name = "consoletopbar";
            consoletopbar.Size = new Size(960, 19);
            consoletopbar.TabIndex = 13;
            consoletopbar.TabStop = false;
            // 
            // consoletopbarlabel
            // 
            consoletopbarlabel.AutoSize = true;
            consoletopbarlabel.BackColor = Color.FromArgb(254, 41, 17);
            consoletopbarlabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Pixel);
            consoletopbarlabel.ForeColor = SystemColors.ButtonHighlight;
            consoletopbarlabel.Location = new Point(11, 41);
            consoletopbarlabel.Name = "consoletopbarlabel";
            consoletopbarlabel.Size = new Size(155, 12);
            consoletopbarlabel.TabIndex = 14;
            consoletopbarlabel.Text = "Command Line Interface Output";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(254, 41, 17);
            pictureBox1.Location = new Point(8, 338);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(960, 19);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pull
            // 
            pull.BackColor = Color.FromArgb(254, 41, 17);
            pull.BackgroundImage = (Image)resources.GetObject("pull.BackgroundImage");
            pull.BackgroundImageLayout = ImageLayout.Center;
            pull.Cursor = Cursors.Hand;
            pull.FlatAppearance.BorderSize = 0;
            pull.FlatStyle = FlatStyle.Flat;
            pull.ForeColor = SystemColors.ActiveCaptionText;
            pull.Location = new Point(7, 363);
            pull.Name = "pull";
            pull.Size = new Size(65, 48);
            pull.TabIndex = 16;
            tooltip.SetToolTip(pull, "Pull - Single Project");
            pull.UseVisualStyleBackColor = false;
            // 
            // push
            // 
            push.BackColor = Color.FromArgb(254, 41, 17);
            push.BackgroundImage = (Image)resources.GetObject("push.BackgroundImage");
            push.BackgroundImageLayout = ImageLayout.Center;
            push.Cursor = Cursors.Hand;
            push.FlatAppearance.BorderSize = 0;
            push.FlatStyle = FlatStyle.Flat;
            push.ForeColor = SystemColors.ActiveCaptionText;
            push.Location = new Point(149, 363);
            push.Name = "push";
            push.Size = new Size(65, 48);
            push.TabIndex = 17;
            tooltip.SetToolTip(push, "Push - Single Project");
            push.UseVisualStyleBackColor = false;
            // 
            // rights
            // 
            rights.AutoSize = true;
            rights.BackColor = Color.FromArgb(254, 41, 17);
            rights.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Pixel);
            rights.ForeColor = SystemColors.ButtonHighlight;
            rights.Location = new Point(11, 341);
            rights.Name = "rights";
            rights.Size = new Size(614, 12);
            rights.TabIndex = 18;
            rights.Text = "This project is not affiliated with, endorsed by, or sponsored by Sitecore®. Related icons are trademarks of Sitecore® Corporation.";
            // 
            // help
            // 
            help.BackColor = Color.FromArgb(254, 41, 17);
            help.BackgroundImage = (Image)resources.GetObject("help.BackgroundImage");
            help.BackgroundImageLayout = ImageLayout.Center;
            help.Cursor = Cursors.Hand;
            help.FlatAppearance.BorderSize = 0;
            help.FlatStyle = FlatStyle.Flat;
            help.ForeColor = SystemColors.ActiveCaptionText;
            help.Location = new Point(974, 201);
            help.Name = "help";
            help.Size = new Size(65, 48);
            help.TabIndex = 19;
            tooltip.SetToolTip(help, "Help & Sitecore documentation");
            help.UseVisualStyleBackColor = false;
            help.Click += help_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.FromArgb(254, 41, 17);
            delete.BackgroundImage = (Image)resources.GetObject("delete.BackgroundImage");
            delete.BackgroundImageLayout = ImageLayout.Center;
            delete.Cursor = Cursors.Hand;
            delete.FlatAppearance.BorderSize = 0;
            delete.FlatStyle = FlatStyle.Flat;
            delete.ForeColor = SystemColors.ActiveCaptionText;
            delete.Location = new Point(291, 363);
            delete.Name = "delete";
            delete.Size = new Size(65, 48);
            delete.TabIndex = 20;
            tooltip.SetToolTip(delete, "Clear Console");
            delete.UseVisualStyleBackColor = false;
            // 
            // pullall
            // 
            pullall.BackColor = Color.FromArgb(254, 41, 17);
            pullall.BackgroundImage = (Image)resources.GetObject("pullall.BackgroundImage");
            pullall.BackgroundImageLayout = ImageLayout.Center;
            pullall.Cursor = Cursors.Hand;
            pullall.FlatAppearance.BorderSize = 0;
            pullall.FlatStyle = FlatStyle.Flat;
            pullall.ForeColor = SystemColors.ActiveCaptionText;
            pullall.Location = new Point(78, 363);
            pullall.Name = "pullall";
            pullall.Size = new Size(65, 48);
            pullall.TabIndex = 21;
            tooltip.SetToolTip(pullall, "Pull - All Projects");
            pullall.UseVisualStyleBackColor = false;
            // 
            // pushall
            // 
            pushall.BackColor = Color.FromArgb(254, 41, 17);
            pushall.BackgroundImage = (Image)resources.GetObject("pushall.BackgroundImage");
            pushall.BackgroundImageLayout = ImageLayout.Center;
            pushall.Cursor = Cursors.Hand;
            pushall.FlatAppearance.BorderSize = 0;
            pushall.FlatStyle = FlatStyle.Flat;
            pushall.ForeColor = SystemColors.ActiveCaptionText;
            pushall.Location = new Point(220, 363);
            pushall.Name = "pushall";
            pushall.Size = new Size(65, 48);
            pushall.TabIndex = 22;
            tooltip.SetToolTip(pushall, "Push - All Projects");
            pushall.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            textBox1.ForeColor = SystemColors.WindowFrame;
            textBox1.Location = new Point(166, 417);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(349, 25);
            textBox1.TabIndex = 23;
            textBox1.Text = "https://local.dc-platform-sitecore.pl";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(254, 41, 17);
            pictureBox2.Location = new Point(7, 417);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(159, 25);
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // install
            // 
            install.BackColor = Color.FromArgb(254, 41, 17);
            install.BackgroundImage = (Image)resources.GetObject("install.BackgroundImage");
            install.BackgroundImageLayout = ImageLayout.Center;
            install.Cursor = Cursors.Hand;
            install.FlatAppearance.BorderSize = 0;
            install.FlatStyle = FlatStyle.Flat;
            install.ForeColor = SystemColors.ActiveCaptionText;
            install.Location = new Point(974, 39);
            install.Name = "install";
            install.Size = new Size(65, 48);
            install.TabIndex = 25;
            tooltip.SetToolTip(install, "Install Sitecore.CLI with prerequisites");
            install.UseVisualStyleBackColor = false;
            // 
            // toolsrestore
            // 
            toolsrestore.BackColor = Color.FromArgb(254, 41, 17);
            toolsrestore.BackgroundImage = (Image)resources.GetObject("toolsrestore.BackgroundImage");
            toolsrestore.BackgroundImageLayout = ImageLayout.Center;
            toolsrestore.Cursor = Cursors.Hand;
            toolsrestore.FlatAppearance.BorderSize = 0;
            toolsrestore.FlatStyle = FlatStyle.Flat;
            toolsrestore.ForeColor = SystemColors.ActiveCaptionText;
            toolsrestore.Location = new Point(974, 93);
            toolsrestore.Name = "toolsrestore";
            toolsrestore.Size = new Size(65, 48);
            toolsrestore.TabIndex = 26;
            tooltip.SetToolTip(toolsrestore, "Command: dotnet tool restore");
            toolsrestore.UseVisualStyleBackColor = false;
            // 
            // commands
            // 
            commands.BackColor = Color.FromArgb(254, 41, 17);
            commands.BackgroundImage = (Image)resources.GetObject("commands.BackgroundImage");
            commands.BackgroundImageLayout = ImageLayout.Center;
            commands.Cursor = Cursors.Hand;
            commands.FlatAppearance.BorderSize = 0;
            commands.FlatStyle = FlatStyle.Flat;
            commands.ForeColor = SystemColors.ActiveCaptionText;
            commands.Location = new Point(974, 255);
            commands.Name = "commands";
            commands.Size = new Size(65, 48);
            commands.TabIndex = 27;
            tooltip.SetToolTip(commands, "Available Commands");
            commands.UseVisualStyleBackColor = false;
            commands.Click += commands_Click;
            // 
            // login
            // 
            login.BackColor = Color.FromArgb(254, 41, 17);
            login.BackgroundImage = (Image)resources.GetObject("login.BackgroundImage");
            login.BackgroundImageLayout = ImageLayout.Center;
            login.Cursor = Cursors.Hand;
            login.FlatAppearance.BorderSize = 0;
            login.FlatStyle = FlatStyle.Flat;
            login.ForeColor = SystemColors.ActiveCaptionText;
            login.Location = new Point(974, 309);
            login.Name = "login";
            login.Size = new Size(65, 48);
            login.TabIndex = 28;
            tooltip.SetToolTip(login, "Login & Authorize");
            login.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(254, 41, 17);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(10, 422);
            label1.Name = "label1";
            label1.Size = new Size(155, 15);
            label1.TabIndex = 29;
            label1.Text = "Content Management URL";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(254, 41, 17);
            pictureBox3.Location = new Point(7, 448);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(159, 25);
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(254, 41, 17);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(28, 453);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 31;
            label2.Text = "Identity Server URL";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            textBox2.ForeColor = SystemColors.WindowFrame;
            textBox2.Location = new Point(166, 448);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(349, 25);
            textBox2.TabIndex = 32;
            textBox2.Text = "https://identity.dc-platform-sitecore.pl";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // powershell
            // 
            powershell.BackColor = Color.FromArgb(254, 41, 17);
            powershell.BackgroundImage = (Image)resources.GetObject("powershell.BackgroundImage");
            powershell.BackgroundImageLayout = ImageLayout.Center;
            powershell.Cursor = Cursors.Hand;
            powershell.FlatAppearance.BorderSize = 0;
            powershell.FlatStyle = FlatStyle.Flat;
            powershell.ForeColor = SystemColors.ActiveCaptionText;
            powershell.Location = new Point(362, 363);
            powershell.Name = "powershell";
            powershell.Size = new Size(65, 48);
            powershell.TabIndex = 33;
            tooltip.SetToolTip(powershell, "Open PowerShell CommandLine Administrator Mode");
            powershell.UseVisualStyleBackColor = false;
            powershell.Click += powershell_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1047, 650);
            Controls.Add(powershell);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(login);
            Controls.Add(commands);
            Controls.Add(toolsrestore);
            Controls.Add(install);
            Controls.Add(pictureBox2);
            Controls.Add(textBox1);
            Controls.Add(pushall);
            Controls.Add(pullall);
            Controls.Add(delete);
            Controls.Add(help);
            Controls.Add(rights);
            Controls.Add(push);
            Controls.Add(pull);
            Controls.Add(pictureBox1);
            Controls.Add(consoletopbarlabel);
            Controls.Add(consoletopbar);
            Controls.Add(settings);
            Controls.Add(console);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sitecore GLI";
            ((System.ComponentModel.ISupportInitialize)topbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)bottombar).EndInit();
            ((System.ComponentModel.ISupportInitialize)logotopbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)consoletopbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private TextBox console;
        private Button settings;
        private PictureBox consoletopbar;
        private Label consoletopbarlabel;
        private PictureBox pictureBox1;
        private Button pull;
        private Button push;
        private Label rights;
        private Button help;
        private Button delete;
        private Button pullall;
        private Button pushall;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private Button install;
        private Button toolsrestore;
        private Button commands;
        private Button login;
        private Label label1;
        private PictureBox pictureBox3;
        private Label label2;
        private TextBox textBox2;
        private ToolTip tooltip;
        private Button powershell;
    }
}
