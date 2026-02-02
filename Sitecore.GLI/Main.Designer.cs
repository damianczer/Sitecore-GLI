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
            cmurl = new TextBox();
            cmbg = new PictureBox();
            install = new Button();
            toolsrestore = new Button();
            commands = new Button();
            login = new Button();
            cmlabel = new Label();
            identitybg = new PictureBox();
            identitylabel = new Label();
            identityurl = new TextBox();
            tooltip = new ToolTip(components);
            powershell = new Button();
            selectall = new Button();
            refresh = new Button();
            notifications = new Button();
            sitecoreinit = new Button();
            nuget = new Button();
            logs = new Button();
            openmodule = new Button();
            workingurl = new TextBox();
            workinglabel = new Label();
            workingbg = new PictureBox();
            modulesurl = new TextBox();
            moduleslocationlabel = new Label();
            moduleslocationbg = new PictureBox();
            modules = new CheckedListBox();
            toplistborder = new PictureBox();
            toplistlabel = new Label();
            bottomlistborder = new PictureBox();
            modulesamount = new TextBox();
            modulesamountbg = new PictureBox();
            matop = new PictureBox();
            mabottom = new PictureBox();
            maright = new PictureBox();
            modulesamountlabel = new Label();
            serializeditemslabel = new Label();
            siright = new PictureBox();
            sibottom = new PictureBox();
            sitop = new PictureBox();
            serializeditemsbg = new PictureBox();
            serializeditems = new TextBox();
            newitemslabel = new Label();
            niright = new PictureBox();
            nibottom = new PictureBox();
            nitop = new PictureBox();
            newitemsbg = new PictureBox();
            newitems = new TextBox();
            license = new Label();
            copyright = new Label();
            middleborder = new PictureBox();
            loaderleft = new PictureBox();
            loaderright = new PictureBox();
            loadertop = new PictureBox();
            loaderbottom = new PictureBox();
            loader = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)topbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bottombar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logotopbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)consoletopbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)identitybg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)workingbg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)moduleslocationbg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toplistborder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bottomlistborder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modulesamountbg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)matop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mabottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maright).BeginInit();
            ((System.ComponentModel.ISupportInitialize)siright).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sibottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sitop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serializeditemsbg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)niright).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nibottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nitop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)newitemsbg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)middleborder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loaderleft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loaderright).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loadertop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loaderbottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loader).BeginInit();
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
            logo.Location = new Point(-16, 511);
            logo.Name = "logo";
            logo.Size = new Size(185, 103);
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
            bottombar.Location = new Point(-1, 587);
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
            author.BackColor = Color.FromArgb(254, 41, 17);
            author.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            author.ForeColor = SystemColors.ButtonHighlight;
            author.Location = new Point(422, 42);
            author.Name = "author";
            author.Size = new Size(132, 12);
            author.TabIndex = 10;
            author.Text = "Author: Damian Czerwiński";
            // 
            // console
            // 
            console.BackColor = SystemColors.InactiveCaptionText;
            console.BorderStyle = BorderStyle.None;
            console.ForeColor = SystemColors.ButtonHighlight;
            console.HideSelection = false;
            console.Location = new Point(8, 58);
            console.Margin = new Padding(10);
            console.Multiline = true;
            console.Name = "console";
            console.ReadOnly = true;
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
            settings.Click += settings_Click;
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
            consoletopbarlabel.Location = new Point(11, 42);
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
            pull.Location = new Point(548, 363);
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
            push.Location = new Point(690, 363);
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
            delete.Location = new Point(832, 363);
            delete.Name = "delete";
            delete.Size = new Size(65, 48);
            delete.TabIndex = 20;
            tooltip.SetToolTip(delete, "Clear Console");
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
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
            pullall.Location = new Point(619, 363);
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
            pushall.Location = new Point(761, 363);
            pushall.Name = "pushall";
            pushall.Size = new Size(65, 48);
            pushall.TabIndex = 22;
            tooltip.SetToolTip(pushall, "Push - All Projects");
            pushall.UseVisualStyleBackColor = false;
            // 
            // cmurl
            // 
            cmurl.BorderStyle = BorderStyle.FixedSingle;
            cmurl.Font = new Font("Segoe UI", 10F);
            cmurl.ForeColor = SystemColors.InactiveCaptionText;
            cmurl.Location = new Point(154, 417);
            cmurl.Name = "cmurl";
            cmurl.Size = new Size(357, 25);
            cmurl.TabIndex = 23;
            cmurl.Text = "https://local.swb10.de";
            cmurl.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbg
            // 
            cmbg.BackColor = Color.FromArgb(254, 41, 17);
            cmbg.Location = new Point(7, 417);
            cmbg.Name = "cmbg";
            cmbg.Size = new Size(141, 25);
            cmbg.TabIndex = 24;
            cmbg.TabStop = false;
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
            toolsrestore.Click += toolsrestore_Click;
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
            // cmlabel
            // 
            cmlabel.AutoSize = true;
            cmlabel.BackColor = Color.FromArgb(254, 41, 17);
            cmlabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmlabel.ForeColor = SystemColors.ButtonHighlight;
            cmlabel.Location = new Point(13, 422);
            cmlabel.Name = "cmlabel";
            cmlabel.Size = new Size(128, 12);
            cmlabel.TabIndex = 29;
            cmlabel.Text = "Content Management URL";
            // 
            // identitybg
            // 
            identitybg.BackColor = Color.FromArgb(254, 41, 17);
            identitybg.Location = new Point(7, 448);
            identitybg.Name = "identitybg";
            identitybg.Size = new Size(141, 25);
            identitybg.TabIndex = 30;
            identitybg.TabStop = false;
            // 
            // identitylabel
            // 
            identitylabel.AutoSize = true;
            identitylabel.BackColor = Color.FromArgb(254, 41, 17);
            identitylabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Pixel);
            identitylabel.ForeColor = SystemColors.ButtonHighlight;
            identitylabel.Location = new Point(30, 453);
            identitylabel.Name = "identitylabel";
            identitylabel.Size = new Size(95, 12);
            identitylabel.TabIndex = 31;
            identitylabel.Text = "Identity Server URL";
            // 
            // identityurl
            // 
            identityurl.BorderStyle = BorderStyle.FixedSingle;
            identityurl.Font = new Font("Segoe UI", 10F);
            identityurl.ForeColor = SystemColors.InactiveCaptionText;
            identityurl.Location = new Point(154, 448);
            identityurl.Name = "identityurl";
            identityurl.Size = new Size(357, 25);
            identityurl.TabIndex = 32;
            identityurl.Text = "https://local.swb10.identityserver";
            identityurl.TextAlign = HorizontalAlignment.Center;
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
            powershell.Location = new Point(903, 363);
            powershell.Name = "powershell";
            powershell.Size = new Size(65, 48);
            powershell.TabIndex = 33;
            tooltip.SetToolTip(powershell, "Open PowerShell CommandLine Administrator Mode");
            powershell.UseVisualStyleBackColor = false;
            powershell.Click += powershell_Click;
            // 
            // selectall
            // 
            selectall.BackColor = Color.FromArgb(254, 41, 17);
            selectall.BackgroundImage = (Image)resources.GetObject("selectall.BackgroundImage");
            selectall.BackgroundImageLayout = ImageLayout.Center;
            selectall.Cursor = Cursors.Hand;
            selectall.FlatAppearance.BorderSize = 0;
            selectall.FlatStyle = FlatStyle.Flat;
            selectall.ForeColor = SystemColors.ActiveCaptionText;
            selectall.Location = new Point(974, 448);
            selectall.Name = "selectall";
            selectall.Size = new Size(65, 48);
            selectall.TabIndex = 43;
            tooltip.SetToolTip(selectall, "Select All");
            selectall.UseVisualStyleBackColor = false;
            selectall.Click += selectall_Click;
            // 
            // refresh
            // 
            refresh.BackColor = Color.FromArgb(254, 41, 17);
            refresh.BackgroundImage = (Image)resources.GetObject("refresh.BackgroundImage");
            refresh.BackgroundImageLayout = ImageLayout.Center;
            refresh.Cursor = Cursors.Hand;
            refresh.FlatAppearance.BorderSize = 0;
            refresh.FlatStyle = FlatStyle.Flat;
            refresh.ForeColor = SystemColors.ActiveCaptionText;
            refresh.Location = new Point(974, 502);
            refresh.Name = "refresh";
            refresh.Size = new Size(65, 48);
            refresh.TabIndex = 44;
            tooltip.SetToolTip(refresh, "Refresh");
            refresh.UseVisualStyleBackColor = false;
            // 
            // notifications
            // 
            notifications.BackColor = Color.FromArgb(254, 41, 17);
            notifications.BackgroundImage = (Image)resources.GetObject("notifications.BackgroundImage");
            notifications.BackgroundImageLayout = ImageLayout.Center;
            notifications.Cursor = Cursors.Hand;
            notifications.FlatAppearance.BorderSize = 0;
            notifications.FlatStyle = FlatStyle.Flat;
            notifications.ForeColor = SystemColors.ActiveCaptionText;
            notifications.Location = new Point(974, 363);
            notifications.Name = "notifications";
            notifications.Size = new Size(65, 48);
            notifications.TabIndex = 66;
            tooltip.SetToolTip(notifications, "Enable & Disable Notifications");
            notifications.UseVisualStyleBackColor = false;
            // 
            // sitecoreinit
            // 
            sitecoreinit.BackColor = Color.FromArgb(254, 41, 17);
            sitecoreinit.BackgroundImage = (Image)resources.GetObject("sitecoreinit.BackgroundImage");
            sitecoreinit.BackgroundImageLayout = ImageLayout.Center;
            sitecoreinit.Cursor = Cursors.Hand;
            sitecoreinit.FlatAppearance.BorderSize = 0;
            sitecoreinit.FlatStyle = FlatStyle.Flat;
            sitecoreinit.ForeColor = SystemColors.ActiveCaptionText;
            sitecoreinit.Location = new Point(380, 541);
            sitecoreinit.Name = "sitecoreinit";
            sitecoreinit.Size = new Size(44, 40);
            sitecoreinit.TabIndex = 76;
            tooltip.SetToolTip(sitecoreinit, "Command: dotnet sitecore init");
            sitecoreinit.UseVisualStyleBackColor = false;
            // 
            // nuget
            // 
            nuget.BackColor = Color.FromArgb(254, 41, 17);
            nuget.BackgroundImage = (Image)resources.GetObject("nuget.BackgroundImage");
            nuget.BackgroundImageLayout = ImageLayout.Center;
            nuget.Cursor = Cursors.Hand;
            nuget.FlatAppearance.BorderSize = 0;
            nuget.FlatStyle = FlatStyle.Flat;
            nuget.ForeColor = SystemColors.ActiveCaptionText;
            nuget.Location = new Point(330, 541);
            nuget.Name = "nuget";
            nuget.Size = new Size(44, 40);
            nuget.TabIndex = 77;
            tooltip.SetToolTip(nuget, "Command: dotnet nuget add source -n SCS");
            nuget.UseVisualStyleBackColor = false;
            // 
            // logs
            // 
            logs.BackColor = Color.FromArgb(254, 41, 17);
            logs.BackgroundImage = (Image)resources.GetObject("logs.BackgroundImage");
            logs.BackgroundImageLayout = ImageLayout.Center;
            logs.Cursor = Cursors.Hand;
            logs.FlatAppearance.BorderSize = 0;
            logs.FlatStyle = FlatStyle.Flat;
            logs.ForeColor = SystemColors.ActiveCaptionText;
            logs.Location = new Point(280, 541);
            logs.Name = "logs";
            logs.Size = new Size(44, 40);
            logs.TabIndex = 78;
            tooltip.SetToolTip(logs, "View Logs");
            logs.UseVisualStyleBackColor = false;
            // 
            // openmodule
            // 
            openmodule.BackColor = Color.FromArgb(254, 41, 17);
            openmodule.BackgroundImage = (Image)resources.GetObject("openmodule.BackgroundImage");
            openmodule.BackgroundImageLayout = ImageLayout.Center;
            openmodule.Cursor = Cursors.Hand;
            openmodule.FlatAppearance.BorderSize = 0;
            openmodule.FlatStyle = FlatStyle.Flat;
            openmodule.ForeColor = SystemColors.ActiveCaptionText;
            openmodule.Location = new Point(230, 541);
            openmodule.Name = "openmodule";
            openmodule.Size = new Size(44, 40);
            openmodule.TabIndex = 79;
            tooltip.SetToolTip(openmodule, "Open Module Directory");
            openmodule.UseVisualStyleBackColor = false;
            // 
            // workingurl
            // 
            workingurl.BorderStyle = BorderStyle.FixedSingle;
            workingurl.Font = new Font("Segoe UI", 10F);
            workingurl.ForeColor = SystemColors.InactiveCaptionText;
            workingurl.Location = new Point(154, 479);
            workingurl.Name = "workingurl";
            workingurl.Size = new Size(357, 25);
            workingurl.TabIndex = 36;
            workingurl.Text = "E:\\SWB\\SWBSitecore10\\SWBSitecore";
            workingurl.TextAlign = HorizontalAlignment.Center;
            // 
            // workinglabel
            // 
            workinglabel.AutoSize = true;
            workinglabel.BackColor = Color.FromArgb(254, 41, 17);
            workinglabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Pixel);
            workinglabel.ForeColor = SystemColors.ButtonHighlight;
            workinglabel.Location = new Point(20, 484);
            workinglabel.Name = "workinglabel";
            workinglabel.Size = new Size(114, 12);
            workinglabel.TabIndex = 35;
            workinglabel.Text = "Working Directory URL";
            // 
            // workingbg
            // 
            workingbg.BackColor = Color.FromArgb(254, 41, 17);
            workingbg.Location = new Point(7, 479);
            workingbg.Name = "workingbg";
            workingbg.Size = new Size(141, 25);
            workingbg.TabIndex = 34;
            workingbg.TabStop = false;
            // 
            // modulesurl
            // 
            modulesurl.BorderStyle = BorderStyle.FixedSingle;
            modulesurl.Font = new Font("Segoe UI", 10F);
            modulesurl.ForeColor = SystemColors.InactiveCaptionText;
            modulesurl.Location = new Point(154, 510);
            modulesurl.Name = "modulesurl";
            modulesurl.Size = new Size(357, 25);
            modulesurl.TabIndex = 39;
            modulesurl.Text = "E:\\SWB\\SWBSitecore10\\SWBSitecore\\src";
            modulesurl.TextAlign = HorizontalAlignment.Center;
            // 
            // moduleslocationlabel
            // 
            moduleslocationlabel.AutoSize = true;
            moduleslocationlabel.BackColor = Color.FromArgb(254, 41, 17);
            moduleslocationlabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Pixel);
            moduleslocationlabel.ForeColor = SystemColors.ButtonHighlight;
            moduleslocationlabel.Location = new Point(22, 515);
            moduleslocationlabel.Name = "moduleslocationlabel";
            moduleslocationlabel.Size = new Size(110, 12);
            moduleslocationlabel.TabIndex = 38;
            moduleslocationlabel.Text = "Modules Location URL";
            // 
            // moduleslocationbg
            // 
            moduleslocationbg.BackColor = Color.FromArgb(254, 41, 17);
            moduleslocationbg.Location = new Point(7, 510);
            moduleslocationbg.Name = "moduleslocationbg";
            moduleslocationbg.Size = new Size(141, 25);
            moduleslocationbg.TabIndex = 37;
            moduleslocationbg.TabStop = false;
            // 
            // modules
            // 
            modules.BorderStyle = BorderStyle.None;
            modules.CheckOnClick = true;
            modules.FormattingEnabled = true;
            modules.Items.AddRange(new object[] { "Featue.DCPlatform", "Foundation.Component", "Feature.User", "Feature.DCShop", "Foundation.API", "Feature.Misc", "Feature.Test" });
            modules.Location = new Point(548, 445);
            modules.Name = "modules";
            modules.Size = new Size(420, 108);
            modules.TabIndex = 40;
            // 
            // toplistborder
            // 
            toplistborder.BackColor = Color.FromArgb(254, 41, 17);
            toplistborder.Location = new Point(548, 417);
            toplistborder.Name = "toplistborder";
            toplistborder.Size = new Size(491, 25);
            toplistborder.TabIndex = 41;
            toplistborder.TabStop = false;
            // 
            // toplistlabel
            // 
            toplistlabel.AutoSize = true;
            toplistlabel.BackColor = Color.FromArgb(254, 41, 17);
            toplistlabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Pixel);
            toplistlabel.ForeColor = SystemColors.ButtonHighlight;
            toplistlabel.Location = new Point(553, 423);
            toplistlabel.Name = "toplistlabel";
            toplistlabel.Size = new Size(131, 12);
            toplistlabel.TabIndex = 42;
            toplistlabel.Text = "Available Sitecore Modules";
            // 
            // bottomlistborder
            // 
            bottomlistborder.BackColor = Color.FromArgb(254, 41, 17);
            bottomlistborder.Location = new Point(548, 556);
            bottomlistborder.Name = "bottomlistborder";
            bottomlistborder.Size = new Size(491, 25);
            bottomlistborder.TabIndex = 45;
            bottomlistborder.TabStop = false;
            // 
            // modulesamount
            // 
            modulesamount.BackColor = SystemColors.ButtonHighlight;
            modulesamount.BorderStyle = BorderStyle.None;
            modulesamount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            modulesamount.ForeColor = SystemColors.WindowFrame;
            modulesamount.Location = new Point(221, 376);
            modulesamount.Name = "modulesamount";
            modulesamount.ReadOnly = true;
            modulesamount.Size = new Size(60, 22);
            modulesamount.TabIndex = 46;
            modulesamount.Text = "10";
            modulesamount.TextAlign = HorizontalAlignment.Center;
            // 
            // modulesamountbg
            // 
            modulesamountbg.BackColor = Color.FromArgb(254, 41, 17);
            modulesamountbg.Location = new Point(154, 363);
            modulesamountbg.Name = "modulesamountbg";
            modulesamountbg.Size = new Size(65, 48);
            modulesamountbg.TabIndex = 47;
            modulesamountbg.TabStop = false;
            // 
            // matop
            // 
            matop.BackColor = Color.FromArgb(254, 41, 17);
            matop.Location = new Point(219, 363);
            matop.Name = "matop";
            matop.Size = new Size(65, 10);
            matop.TabIndex = 48;
            matop.TabStop = false;
            // 
            // mabottom
            // 
            mabottom.BackColor = Color.FromArgb(254, 41, 17);
            mabottom.Location = new Point(219, 401);
            mabottom.Name = "mabottom";
            mabottom.Size = new Size(65, 10);
            mabottom.TabIndex = 49;
            mabottom.TabStop = false;
            // 
            // maright
            // 
            maright.BackColor = Color.FromArgb(254, 41, 17);
            maright.Location = new Point(284, 363);
            maright.Name = "maright";
            maright.Size = new Size(10, 48);
            maright.TabIndex = 50;
            maright.TabStop = false;
            // 
            // modulesamountlabel
            // 
            modulesamountlabel.AutoSize = true;
            modulesamountlabel.BackColor = Color.FromArgb(254, 41, 17);
            modulesamountlabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Pixel);
            modulesamountlabel.ForeColor = SystemColors.ButtonHighlight;
            modulesamountlabel.Location = new Point(164, 375);
            modulesamountlabel.Name = "modulesamountlabel";
            modulesamountlabel.Size = new Size(45, 24);
            modulesamountlabel.TabIndex = 51;
            modulesamountlabel.Text = "Modules\r\nAmount";
            modulesamountlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // serializeditemslabel
            // 
            serializeditemslabel.AutoSize = true;
            serializeditemslabel.BackColor = Color.FromArgb(254, 41, 17);
            serializeditemslabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Pixel);
            serializeditemslabel.ForeColor = SystemColors.ButtonHighlight;
            serializeditemslabel.Location = new Point(307, 375);
            serializeditemslabel.Name = "serializeditemslabel";
            serializeditemslabel.Size = new Size(50, 24);
            serializeditemslabel.TabIndex = 57;
            serializeditemslabel.Text = "Serialized\r\nItems";
            serializeditemslabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // siright
            // 
            siright.BackColor = Color.FromArgb(254, 41, 17);
            siright.Location = new Point(430, 363);
            siright.Name = "siright";
            siright.Size = new Size(10, 48);
            siright.TabIndex = 56;
            siright.TabStop = false;
            // 
            // sibottom
            // 
            sibottom.BackColor = Color.FromArgb(254, 41, 17);
            sibottom.Location = new Point(365, 401);
            sibottom.Name = "sibottom";
            sibottom.Size = new Size(65, 10);
            sibottom.TabIndex = 55;
            sibottom.TabStop = false;
            // 
            // sitop
            // 
            sitop.BackColor = Color.FromArgb(254, 41, 17);
            sitop.Location = new Point(365, 363);
            sitop.Name = "sitop";
            sitop.Size = new Size(65, 10);
            sitop.TabIndex = 54;
            sitop.TabStop = false;
            // 
            // serializeditemsbg
            // 
            serializeditemsbg.BackColor = Color.FromArgb(254, 41, 17);
            serializeditemsbg.Location = new Point(300, 363);
            serializeditemsbg.Name = "serializeditemsbg";
            serializeditemsbg.Size = new Size(65, 48);
            serializeditemsbg.TabIndex = 53;
            serializeditemsbg.TabStop = false;
            // 
            // serializeditems
            // 
            serializeditems.BackColor = SystemColors.ButtonHighlight;
            serializeditems.BorderStyle = BorderStyle.None;
            serializeditems.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            serializeditems.ForeColor = SystemColors.WindowFrame;
            serializeditems.Location = new Point(367, 376);
            serializeditems.Name = "serializeditems";
            serializeditems.ReadOnly = true;
            serializeditems.Size = new Size(60, 22);
            serializeditems.TabIndex = 52;
            serializeditems.Text = "1359";
            serializeditems.TextAlign = HorizontalAlignment.Center;
            // 
            // newitemslabel
            // 
            newitemslabel.AutoSize = true;
            newitemslabel.BackColor = Color.FromArgb(254, 41, 17);
            newitemslabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Pixel);
            newitemslabel.ForeColor = SystemColors.ButtonHighlight;
            newitemslabel.Location = new Point(25, 375);
            newitemslabel.Name = "newitemslabel";
            newitemslabel.Size = new Size(30, 24);
            newitemslabel.TabIndex = 63;
            newitemslabel.Text = "New\r\nItems";
            newitemslabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // niright
            // 
            niright.BackColor = Color.FromArgb(254, 41, 17);
            niright.Location = new Point(138, 363);
            niright.Name = "niright";
            niright.Size = new Size(10, 48);
            niright.TabIndex = 62;
            niright.TabStop = false;
            // 
            // nibottom
            // 
            nibottom.BackColor = Color.FromArgb(254, 41, 17);
            nibottom.Location = new Point(73, 401);
            nibottom.Name = "nibottom";
            nibottom.Size = new Size(65, 10);
            nibottom.TabIndex = 61;
            nibottom.TabStop = false;
            // 
            // nitop
            // 
            nitop.BackColor = Color.FromArgb(254, 41, 17);
            nitop.Location = new Point(73, 363);
            nitop.Name = "nitop";
            nitop.Size = new Size(65, 10);
            nitop.TabIndex = 60;
            nitop.TabStop = false;
            // 
            // newitemsbg
            // 
            newitemsbg.BackColor = Color.FromArgb(254, 41, 17);
            newitemsbg.Location = new Point(8, 363);
            newitemsbg.Name = "newitemsbg";
            newitemsbg.Size = new Size(65, 48);
            newitemsbg.TabIndex = 59;
            newitemsbg.TabStop = false;
            // 
            // newitems
            // 
            newitems.BackColor = SystemColors.ButtonHighlight;
            newitems.BorderStyle = BorderStyle.None;
            newitems.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            newitems.ForeColor = SystemColors.WindowFrame;
            newitems.Location = new Point(75, 376);
            newitems.Name = "newitems";
            newitems.ReadOnly = true;
            newitems.Size = new Size(60, 22);
            newitems.TabIndex = 58;
            newitems.Text = "16";
            newitems.TextAlign = HorizontalAlignment.Center;
            // 
            // license
            // 
            license.AutoSize = true;
            license.BackColor = Color.FromArgb(254, 41, 17);
            license.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            license.ForeColor = SystemColors.ButtonHighlight;
            license.Location = new Point(897, 341);
            license.Name = "license";
            license.Size = new Size(66, 12);
            license.TabIndex = 64;
            license.Text = "License v. 1.0";
            license.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // copyright
            // 
            copyright.AutoSize = true;
            copyright.BackColor = Color.FromArgb(254, 41, 17);
            copyright.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            copyright.ForeColor = SystemColors.ButtonHighlight;
            copyright.Location = new Point(806, 42);
            copyright.Name = "copyright";
            copyright.Size = new Size(159, 12);
            copyright.TabIndex = 65;
            copyright.Text = "Copyright © All Rights Reserved.";
            // 
            // middleborder
            // 
            middleborder.BackColor = Color.FromArgb(254, 41, 17);
            middleborder.Location = new Point(517, 363);
            middleborder.Name = "middleborder";
            middleborder.Size = new Size(25, 218);
            middleborder.TabIndex = 67;
            middleborder.TabStop = false;
            // 
            // loaderleft
            // 
            loaderleft.BackColor = Color.FromArgb(254, 41, 17);
            loaderleft.Location = new Point(446, 372);
            loaderleft.Name = "loaderleft";
            loaderleft.Size = new Size(10, 38);
            loaderleft.TabIndex = 68;
            loaderleft.TabStop = false;
            // 
            // loaderright
            // 
            loaderright.BackColor = Color.FromArgb(254, 41, 17);
            loaderright.Location = new Point(501, 364);
            loaderright.Name = "loaderright";
            loaderright.Size = new Size(10, 37);
            loaderright.TabIndex = 69;
            loaderright.TabStop = false;
            // 
            // loadertop
            // 
            loadertop.BackColor = Color.FromArgb(254, 41, 17);
            loadertop.Location = new Point(446, 363);
            loadertop.Name = "loadertop";
            loadertop.Size = new Size(65, 10);
            loadertop.TabIndex = 70;
            loadertop.TabStop = false;
            // 
            // loaderbottom
            // 
            loaderbottom.BackColor = Color.FromArgb(254, 41, 17);
            loaderbottom.Location = new Point(446, 401);
            loaderbottom.Name = "loaderbottom";
            loaderbottom.Size = new Size(65, 10);
            loaderbottom.TabIndex = 71;
            loaderbottom.TabStop = false;
            // 
            // loader
            // 
            loader.BackColor = Color.White;
            loader.BackgroundImage = (Image)resources.GetObject("loader.BackgroundImage");
            loader.Location = new Point(466, 375);
            loader.Name = "loader";
            loader.Size = new Size(24, 25);
            loader.TabIndex = 72;
            loader.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1047, 589);
            Controls.Add(openmodule);
            Controls.Add(logs);
            Controls.Add(nuget);
            Controls.Add(sitecoreinit);
            Controls.Add(loader);
            Controls.Add(loaderbottom);
            Controls.Add(loadertop);
            Controls.Add(loaderright);
            Controls.Add(loaderleft);
            Controls.Add(middleborder);
            Controls.Add(notifications);
            Controls.Add(copyright);
            Controls.Add(license);
            Controls.Add(newitemslabel);
            Controls.Add(niright);
            Controls.Add(nibottom);
            Controls.Add(nitop);
            Controls.Add(newitemsbg);
            Controls.Add(newitems);
            Controls.Add(serializeditemslabel);
            Controls.Add(siright);
            Controls.Add(sibottom);
            Controls.Add(sitop);
            Controls.Add(serializeditemsbg);
            Controls.Add(serializeditems);
            Controls.Add(modulesamountlabel);
            Controls.Add(maright);
            Controls.Add(mabottom);
            Controls.Add(matop);
            Controls.Add(modulesamountbg);
            Controls.Add(modulesamount);
            Controls.Add(bottomlistborder);
            Controls.Add(refresh);
            Controls.Add(selectall);
            Controls.Add(toplistlabel);
            Controls.Add(toplistborder);
            Controls.Add(modules);
            Controls.Add(modulesurl);
            Controls.Add(moduleslocationlabel);
            Controls.Add(moduleslocationbg);
            Controls.Add(workingurl);
            Controls.Add(workinglabel);
            Controls.Add(workingbg);
            Controls.Add(powershell);
            Controls.Add(identityurl);
            Controls.Add(identitylabel);
            Controls.Add(identitybg);
            Controls.Add(cmlabel);
            Controls.Add(login);
            Controls.Add(commands);
            Controls.Add(toolsrestore);
            Controls.Add(install);
            Controls.Add(cmbg);
            Controls.Add(cmurl);
            Controls.Add(pushall);
            Controls.Add(pullall);
            Controls.Add(delete);
            Controls.Add(help);
            Controls.Add(rights);
            Controls.Add(push);
            Controls.Add(pull);
            Controls.Add(pictureBox1);
            Controls.Add(consoletopbarlabel);
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
            Controls.Add(consoletopbar);
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
            ((System.ComponentModel.ISupportInitialize)cmbg).EndInit();
            ((System.ComponentModel.ISupportInitialize)identitybg).EndInit();
            ((System.ComponentModel.ISupportInitialize)workingbg).EndInit();
            ((System.ComponentModel.ISupportInitialize)moduleslocationbg).EndInit();
            ((System.ComponentModel.ISupportInitialize)toplistborder).EndInit();
            ((System.ComponentModel.ISupportInitialize)bottomlistborder).EndInit();
            ((System.ComponentModel.ISupportInitialize)modulesamountbg).EndInit();
            ((System.ComponentModel.ISupportInitialize)matop).EndInit();
            ((System.ComponentModel.ISupportInitialize)mabottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)maright).EndInit();
            ((System.ComponentModel.ISupportInitialize)siright).EndInit();
            ((System.ComponentModel.ISupportInitialize)sibottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)sitop).EndInit();
            ((System.ComponentModel.ISupportInitialize)serializeditemsbg).EndInit();
            ((System.ComponentModel.ISupportInitialize)niright).EndInit();
            ((System.ComponentModel.ISupportInitialize)nibottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)nitop).EndInit();
            ((System.ComponentModel.ISupportInitialize)newitemsbg).EndInit();
            ((System.ComponentModel.ISupportInitialize)middleborder).EndInit();
            ((System.ComponentModel.ISupportInitialize)loaderleft).EndInit();
            ((System.ComponentModel.ISupportInitialize)loaderright).EndInit();
            ((System.ComponentModel.ISupportInitialize)loadertop).EndInit();
            ((System.ComponentModel.ISupportInitialize)loaderbottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)loader).EndInit();
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
        private TextBox cmurl;
        private PictureBox cmbg;
        private Button install;
        private Button toolsrestore;
        private Button commands;
        private Button login;
        private Label cmlabel;
        private PictureBox identitybg;
        private Label identitylabel;
        private TextBox identityurl;
        private ToolTip tooltip;
        private Button powershell;
        private TextBox workingurl;
        private Label workinglabel;
        private PictureBox workingbg;
        private TextBox modulesurl;
        private Label moduleslocationlabel;
        private PictureBox moduleslocationbg;
        private CheckedListBox modules;
        private PictureBox toplistborder;
        private Label toplistlabel;
        private Button selectall;
        private Button refresh;
        private PictureBox bottomlistborder;
        private TextBox modulesamount;
        private PictureBox modulesamountbg;
        private PictureBox matop;
        private PictureBox mabottom;
        private PictureBox maright;
        private Label modulesamountlabel;
        private Label serializeditemslabel;
        private PictureBox siright;
        private PictureBox sibottom;
        private PictureBox sitop;
        private PictureBox serializeditemsbg;
        private TextBox serializeditems;
        private Label newitemslabel;
        private PictureBox niright;
        private PictureBox nibottom;
        private PictureBox nitop;
        private PictureBox newitemsbg;
        private TextBox newitems;
        private Label license;
        private Label copyright;
        private Button notifications;
        private PictureBox middleborder;
        private PictureBox loaderleft;
        private PictureBox loaderright;
        private PictureBox loadertop;
        private PictureBox loaderbottom;
        private PictureBox loader;
        private Button sitecoreinit;
        private Button nuget;
        private Button logs;
        private Button openmodule;
    }
}
