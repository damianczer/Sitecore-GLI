namespace Sitecore.GLI
{
    partial class Commands
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Commands));
            minimize = new Button();
            exit = new Button();
            logotopbar = new PictureBox();
            name = new Label();
            topbar = new PictureBox();
            logo = new PictureBox();
            rightbar = new PictureBox();
            leftbar = new PictureBox();
            bottombar = new PictureBox();
            commandstable = new TableLayoutPanel();
            descriptiondb = new TextBox();
            descriptionedge = new TextBox();
            descriptionconnect = new TextBox();
            descriptionser = new TextBox();
            descriptionpublish = new TextBox();
            descriptionplugin = new TextBox();
            descriptionlogin = new TextBox();
            descriptionitemres = new TextBox();
            descriptioninit = new TextBox();
            commandinit = new TextBox();
            commandindex = new TextBox();
            descriptionindex = new TextBox();
            commanditemres = new TextBox();
            commandlogin = new TextBox();
            commandplugin = new TextBox();
            commandpublish = new TextBox();
            commandser = new TextBox();
            commandconnect = new TextBox();
            commandedge = new TextBox();
            commanddb = new TextBox();
            commandlabel = new Label();
            tablebar = new PictureBox();
            commanddescription = new Label();
            ((System.ComponentModel.ISupportInitialize)logotopbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)topbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bottombar).BeginInit();
            commandstable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablebar).BeginInit();
            SuspendLayout();
            // 
            // minimize
            // 
            minimize.BackColor = SystemColors.ActiveCaptionText;
            minimize.BackgroundImage = (Image)resources.GetObject("minimize.BackgroundImage");
            minimize.BackgroundImageLayout = ImageLayout.None;
            minimize.Cursor = Cursors.Hand;
            minimize.FlatStyle = FlatStyle.Flat;
            minimize.Location = new Point(660, 3);
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
            exit.Location = new Point(687, 3);
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
            name.Location = new Point(27, 9);
            name.Name = "name";
            name.Size = new Size(148, 15);
            name.TabIndex = 11;
            name.Text = "Sitecore GLI [Commands]";
            // 
            // topbar
            // 
            topbar.BackColor = SystemColors.ActiveCaptionText;
            topbar.Location = new Point(0, -1);
            topbar.Name = "topbar";
            topbar.Size = new Size(717, 34);
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
            logo.Location = new Point(8, 7);
            logo.Name = "logo";
            logo.Size = new Size(18, 17);
            logo.TabIndex = 15;
            logo.TabStop = false;
            // 
            // rightbar
            // 
            rightbar.BackColor = SystemColors.ActiveCaptionText;
            rightbar.Location = new Point(714, 27);
            rightbar.Name = "rightbar";
            rightbar.Size = new Size(10, 541);
            rightbar.TabIndex = 16;
            rightbar.TabStop = false;
            // 
            // leftbar
            // 
            leftbar.BackColor = SystemColors.ActiveCaptionText;
            leftbar.Location = new Point(-8, 30);
            leftbar.Name = "leftbar";
            leftbar.Size = new Size(10, 541);
            leftbar.TabIndex = 17;
            leftbar.TabStop = false;
            // 
            // bottombar
            // 
            bottombar.BackColor = SystemColors.ActiveCaptionText;
            bottombar.Location = new Point(0, 547);
            bottombar.Name = "bottombar";
            bottombar.Size = new Size(724, 10);
            bottombar.TabIndex = 18;
            bottombar.TabStop = false;
            // 
            // commandstable
            // 
            commandstable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            commandstable.ColumnCount = 2;
            commandstable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.69697F));
            commandstable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.30303F));
            commandstable.Controls.Add(descriptiondb, 1, 9);
            commandstable.Controls.Add(descriptionedge, 1, 8);
            commandstable.Controls.Add(descriptionconnect, 1, 7);
            commandstable.Controls.Add(descriptionser, 1, 6);
            commandstable.Controls.Add(descriptionpublish, 1, 5);
            commandstable.Controls.Add(descriptionplugin, 1, 4);
            commandstable.Controls.Add(descriptionlogin, 1, 3);
            commandstable.Controls.Add(descriptionitemres, 1, 2);
            commandstable.Controls.Add(descriptioninit, 1, 1);
            commandstable.Controls.Add(commandinit, 0, 1);
            commandstable.Controls.Add(commandindex, 0, 0);
            commandstable.Controls.Add(descriptionindex, 1, 0);
            commandstable.Controls.Add(commanditemres, 0, 2);
            commandstable.Controls.Add(commandlogin, 0, 3);
            commandstable.Controls.Add(commandplugin, 0, 4);
            commandstable.Controls.Add(commandpublish, 0, 5);
            commandstable.Controls.Add(commandser, 0, 6);
            commandstable.Controls.Add(commandconnect, 0, 7);
            commandstable.Controls.Add(commandedge, 0, 8);
            commandstable.Controls.Add(commanddb, 0, 9);
            commandstable.Location = new Point(8, 55);
            commandstable.Name = "commandstable";
            commandstable.RowCount = 10;
            commandstable.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            commandstable.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            commandstable.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            commandstable.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            commandstable.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            commandstable.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            commandstable.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            commandstable.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            commandstable.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            commandstable.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            commandstable.Size = new Size(700, 485);
            commandstable.TabIndex = 19;
            // 
            // descriptiondb
            // 
            descriptiondb.BackColor = SystemColors.ButtonHighlight;
            descriptiondb.BorderStyle = BorderStyle.None;
            descriptiondb.CausesValidation = false;
            descriptiondb.Location = new Point(211, 436);
            descriptiondb.Multiline = true;
            descriptiondb.Name = "descriptiondb";
            descriptiondb.ReadOnly = true;
            descriptiondb.Size = new Size(485, 41);
            descriptiondb.TabIndex = 19;
            descriptiondb.Text = "\r\nPerforms database cleanup according to the provided tasks.";
            descriptiondb.TextAlign = HorizontalAlignment.Center;
            // 
            // descriptionedge
            // 
            descriptionedge.BackColor = SystemColors.ButtonHighlight;
            descriptionedge.BorderStyle = BorderStyle.None;
            descriptionedge.CausesValidation = false;
            descriptionedge.Location = new Point(209, 386);
            descriptionedge.Margin = new Padding(1);
            descriptionedge.Multiline = true;
            descriptionedge.Name = "descriptionedge";
            descriptionedge.ReadOnly = true;
            descriptionedge.Size = new Size(485, 41);
            descriptionedge.TabIndex = 18;
            descriptionedge.Text = "\r\nHelps you manage Experience Edge API keys.";
            descriptionedge.TextAlign = HorizontalAlignment.Center;
            // 
            // descriptionconnect
            // 
            descriptionconnect.BackColor = SystemColors.ButtonHighlight;
            descriptionconnect.BorderStyle = BorderStyle.None;
            descriptionconnect.CausesValidation = false;
            descriptionconnect.Location = new Point(216, 345);
            descriptionconnect.Margin = new Padding(8);
            descriptionconnect.Multiline = true;
            descriptionconnect.Name = "descriptionconnect";
            descriptionconnect.ReadOnly = true;
            descriptionconnect.Size = new Size(475, 31);
            descriptionconnect.TabIndex = 17;
            descriptionconnect.Text = "Connect your environment to a different existing environment and use its login information.";
            descriptionconnect.TextAlign = HorizontalAlignment.Center;
            // 
            // descriptionser
            // 
            descriptionser.BackColor = SystemColors.ButtonHighlight;
            descriptionser.BorderStyle = BorderStyle.None;
            descriptionser.CausesValidation = false;
            descriptionser.Location = new Point(209, 290);
            descriptionser.Margin = new Padding(1);
            descriptionser.Multiline = true;
            descriptionser.Name = "descriptionser";
            descriptionser.ReadOnly = true;
            descriptionser.Size = new Size(485, 41);
            descriptionser.TabIndex = 16;
            descriptionser.Text = "\r\nHandles the serialization of items. Install the serialization plugin to access this command.";
            descriptionser.TextAlign = HorizontalAlignment.Center;
            // 
            // descriptionpublish
            // 
            descriptionpublish.BackColor = SystemColors.ButtonHighlight;
            descriptionpublish.BorderStyle = BorderStyle.None;
            descriptionpublish.CausesValidation = false;
            descriptionpublish.Location = new Point(216, 249);
            descriptionpublish.Margin = new Padding(8);
            descriptionpublish.Multiline = true;
            descriptionpublish.Name = "descriptionpublish";
            descriptionpublish.ReadOnly = true;
            descriptionpublish.Size = new Size(475, 31);
            descriptionpublish.TabIndex = 15;
            descriptionpublish.Text = "Publishes all content from the Master database to the Web database. Install the publishing plugin to access this command.";
            descriptionpublish.TextAlign = HorizontalAlignment.Center;
            // 
            // descriptionplugin
            // 
            descriptionplugin.BackColor = SystemColors.ButtonHighlight;
            descriptionplugin.BorderStyle = BorderStyle.None;
            descriptionplugin.CausesValidation = false;
            descriptionplugin.Location = new Point(209, 194);
            descriptionplugin.Margin = new Padding(1);
            descriptionplugin.Multiline = true;
            descriptionplugin.Name = "descriptionplugin";
            descriptionplugin.ReadOnly = true;
            descriptionplugin.Size = new Size(485, 41);
            descriptionplugin.TabIndex = 14;
            descriptionplugin.Text = "\r\nManages plugins for the CLI that contain additional commands.";
            descriptionplugin.TextAlign = HorizontalAlignment.Center;
            // 
            // descriptionlogin
            // 
            descriptionlogin.BackColor = SystemColors.ButtonHighlight;
            descriptionlogin.BorderStyle = BorderStyle.None;
            descriptionlogin.CausesValidation = false;
            descriptionlogin.Location = new Point(209, 146);
            descriptionlogin.Margin = new Padding(1);
            descriptionlogin.Multiline = true;
            descriptionlogin.Name = "descriptionlogin";
            descriptionlogin.ReadOnly = true;
            descriptionlogin.Size = new Size(485, 41);
            descriptionlogin.TabIndex = 13;
            descriptionlogin.Text = "\r\nLogs in to a Sitecore instance.";
            descriptionlogin.TextAlign = HorizontalAlignment.Center;
            // 
            // descriptionitemres
            // 
            descriptionitemres.BackColor = SystemColors.ButtonHighlight;
            descriptionitemres.BorderStyle = BorderStyle.None;
            descriptionitemres.CausesValidation = false;
            descriptionitemres.Location = new Point(216, 105);
            descriptionitemres.Margin = new Padding(8);
            descriptionitemres.Multiline = true;
            descriptionitemres.Name = "descriptionitemres";
            descriptionitemres.ReadOnly = true;
            descriptionitemres.Size = new Size(475, 31);
            descriptionitemres.TabIndex = 12;
            descriptionitemres.Text = "Creates an item package in a resource file with configurable options. Install the Items as Resources plugin to access this command.";
            descriptionitemres.TextAlign = HorizontalAlignment.Center;
            // 
            // descriptioninit
            // 
            descriptioninit.BackColor = SystemColors.ButtonHighlight;
            descriptioninit.BorderStyle = BorderStyle.None;
            descriptioninit.CausesValidation = false;
            descriptioninit.Location = new Point(209, 50);
            descriptioninit.Margin = new Padding(1);
            descriptioninit.Multiline = true;
            descriptioninit.Name = "descriptioninit";
            descriptioninit.ReadOnly = true;
            descriptioninit.Size = new Size(485, 41);
            descriptioninit.TabIndex = 11;
            descriptioninit.Text = "\r\nInitializes a project configuration in the current folder.";
            descriptioninit.TextAlign = HorizontalAlignment.Center;
            // 
            // commandinit
            // 
            commandinit.BackColor = SystemColors.ButtonHighlight;
            commandinit.BorderStyle = BorderStyle.None;
            commandinit.CausesValidation = false;
            commandinit.Location = new Point(2, 50);
            commandinit.Margin = new Padding(1);
            commandinit.Multiline = true;
            commandinit.Name = "commandinit";
            commandinit.ReadOnly = true;
            commandinit.Size = new Size(200, 41);
            commandinit.TabIndex = 2;
            commandinit.Text = "\r\nsitecore init";
            commandinit.TextAlign = HorizontalAlignment.Center;
            // 
            // commandindex
            // 
            commandindex.BackColor = SystemColors.ButtonHighlight;
            commandindex.BorderStyle = BorderStyle.None;
            commandindex.CausesValidation = false;
            commandindex.Location = new Point(2, 2);
            commandindex.Margin = new Padding(1);
            commandindex.Multiline = true;
            commandindex.Name = "commandindex";
            commandindex.ReadOnly = true;
            commandindex.Size = new Size(200, 41);
            commandindex.TabIndex = 0;
            commandindex.Text = "\r\nsitecore index";
            commandindex.TextAlign = HorizontalAlignment.Center;
            // 
            // descriptionindex
            // 
            descriptionindex.BackColor = SystemColors.ButtonHighlight;
            descriptionindex.BorderStyle = BorderStyle.None;
            descriptionindex.CausesValidation = false;
            descriptionindex.Location = new Point(209, 2);
            descriptionindex.Margin = new Padding(1);
            descriptionindex.Multiline = true;
            descriptionindex.Name = "descriptionindex";
            descriptionindex.ReadOnly = true;
            descriptionindex.Size = new Size(485, 41);
            descriptionindex.TabIndex = 1;
            descriptionindex.Text = "\r\nAutomates indexing operations. Install the indexing plugin to access this command.";
            descriptionindex.TextAlign = HorizontalAlignment.Center;
            // 
            // commanditemres
            // 
            commanditemres.BackColor = SystemColors.ButtonHighlight;
            commanditemres.BorderStyle = BorderStyle.None;
            commanditemres.CausesValidation = false;
            commanditemres.Location = new Point(2, 98);
            commanditemres.Margin = new Padding(1);
            commanditemres.Multiline = true;
            commanditemres.Name = "commanditemres";
            commanditemres.ReadOnly = true;
            commanditemres.Size = new Size(200, 41);
            commanditemres.TabIndex = 3;
            commanditemres.Text = "\r\nsitecore itemres";
            commanditemres.TextAlign = HorizontalAlignment.Center;
            // 
            // commandlogin
            // 
            commandlogin.BackColor = SystemColors.ButtonHighlight;
            commandlogin.BorderStyle = BorderStyle.None;
            commandlogin.CausesValidation = false;
            commandlogin.Location = new Point(2, 146);
            commandlogin.Margin = new Padding(1);
            commandlogin.Multiline = true;
            commandlogin.Name = "commandlogin";
            commandlogin.ReadOnly = true;
            commandlogin.Size = new Size(200, 41);
            commandlogin.TabIndex = 4;
            commandlogin.Text = "\r\nsitecore login";
            commandlogin.TextAlign = HorizontalAlignment.Center;
            // 
            // commandplugin
            // 
            commandplugin.BackColor = SystemColors.ButtonHighlight;
            commandplugin.BorderStyle = BorderStyle.None;
            commandplugin.CausesValidation = false;
            commandplugin.Location = new Point(2, 194);
            commandplugin.Margin = new Padding(1);
            commandplugin.Multiline = true;
            commandplugin.Name = "commandplugin";
            commandplugin.ReadOnly = true;
            commandplugin.Size = new Size(200, 41);
            commandplugin.TabIndex = 5;
            commandplugin.Text = "\r\nsitecore plugin";
            commandplugin.TextAlign = HorizontalAlignment.Center;
            // 
            // commandpublish
            // 
            commandpublish.BackColor = SystemColors.ButtonHighlight;
            commandpublish.BorderStyle = BorderStyle.None;
            commandpublish.CausesValidation = false;
            commandpublish.Location = new Point(2, 242);
            commandpublish.Margin = new Padding(1);
            commandpublish.Multiline = true;
            commandpublish.Name = "commandpublish";
            commandpublish.ReadOnly = true;
            commandpublish.Size = new Size(200, 41);
            commandpublish.TabIndex = 6;
            commandpublish.Text = "\r\nsitecore publish";
            commandpublish.TextAlign = HorizontalAlignment.Center;
            // 
            // commandser
            // 
            commandser.BackColor = SystemColors.ButtonHighlight;
            commandser.BorderStyle = BorderStyle.None;
            commandser.CausesValidation = false;
            commandser.Location = new Point(2, 290);
            commandser.Margin = new Padding(1);
            commandser.Multiline = true;
            commandser.Name = "commandser";
            commandser.ReadOnly = true;
            commandser.Size = new Size(200, 41);
            commandser.TabIndex = 7;
            commandser.Text = "\r\nsitecore ser, serialization";
            commandser.TextAlign = HorizontalAlignment.Center;
            // 
            // commandconnect
            // 
            commandconnect.BackColor = SystemColors.ButtonHighlight;
            commandconnect.BorderStyle = BorderStyle.None;
            commandconnect.CausesValidation = false;
            commandconnect.Location = new Point(2, 338);
            commandconnect.Margin = new Padding(1);
            commandconnect.Multiline = true;
            commandconnect.Name = "commandconnect";
            commandconnect.ReadOnly = true;
            commandconnect.Size = new Size(200, 41);
            commandconnect.TabIndex = 8;
            commandconnect.Text = "\r\nsitecore connect";
            commandconnect.TextAlign = HorizontalAlignment.Center;
            // 
            // commandedge
            // 
            commandedge.BackColor = SystemColors.ButtonHighlight;
            commandedge.BorderStyle = BorderStyle.None;
            commandedge.CausesValidation = false;
            commandedge.Location = new Point(2, 386);
            commandedge.Margin = new Padding(1);
            commandedge.Multiline = true;
            commandedge.Name = "commandedge";
            commandedge.ReadOnly = true;
            commandedge.Size = new Size(200, 41);
            commandedge.TabIndex = 9;
            commandedge.Text = "\r\nsitecore edge";
            commandedge.TextAlign = HorizontalAlignment.Center;
            // 
            // commanddb
            // 
            commanddb.BackColor = SystemColors.ButtonHighlight;
            commanddb.BorderStyle = BorderStyle.None;
            commanddb.CausesValidation = false;
            commanddb.Location = new Point(4, 436);
            commanddb.Multiline = true;
            commanddb.Name = "commanddb";
            commanddb.ReadOnly = true;
            commanddb.Size = new Size(200, 42);
            commanddb.TabIndex = 10;
            commanddb.Text = "\r\nsitecore dbcleanup";
            commanddb.TextAlign = HorizontalAlignment.Center;
            // 
            // commandlabel
            // 
            commandlabel.AutoSize = true;
            commandlabel.BackColor = Color.FromArgb(254, 41, 17);
            commandlabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Pixel);
            commandlabel.ForeColor = SystemColors.ButtonHighlight;
            commandlabel.Location = new Point(87, 42);
            commandlabel.Name = "commandlabel";
            commandlabel.Size = new Size(52, 12);
            commandlabel.TabIndex = 16;
            commandlabel.Text = "Command";
            // 
            // tablebar
            // 
            tablebar.BackColor = Color.FromArgb(254, 41, 17);
            tablebar.Location = new Point(8, 39);
            tablebar.Name = "tablebar";
            tablebar.Size = new Size(700, 19);
            tablebar.TabIndex = 15;
            tablebar.TabStop = false;
            // 
            // commanddescription
            // 
            commanddescription.AutoSize = true;
            commanddescription.BackColor = Color.FromArgb(254, 41, 17);
            commanddescription.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Pixel);
            commanddescription.ForeColor = SystemColors.ButtonHighlight;
            commanddescription.Location = new Point(428, 42);
            commanddescription.Name = "commanddescription";
            commanddescription.Size = new Size(58, 12);
            commanddescription.TabIndex = 17;
            commanddescription.Text = "Description";
            // 
            // Commands
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(716, 549);
            Controls.Add(commanddescription);
            Controls.Add(commandlabel);
            Controls.Add(tablebar);
            Controls.Add(commandstable);
            Controls.Add(bottombar);
            Controls.Add(leftbar);
            Controls.Add(rightbar);
            Controls.Add(logo);
            Controls.Add(minimize);
            Controls.Add(exit);
            Controls.Add(logotopbar);
            Controls.Add(name);
            Controls.Add(topbar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Commands";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Commands";
            ((System.ComponentModel.ISupportInitialize)logotopbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)topbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)bottombar).EndInit();
            commandstable.ResumeLayout(false);
            commandstable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablebar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button minimize;
        private Button exit;
        private PictureBox logotopbar;
        private Label name;
        private PictureBox topbar;
        private PictureBox logo;
        private PictureBox rightbar;
        private PictureBox leftbar;
        private PictureBox bottombar;
        private TableLayoutPanel commandstable;
        private Label commandlabel;
        private PictureBox tablebar;
        private Label commanddescription;
        private TextBox commandindex;
        private TextBox descriptionindex;
        private TextBox descriptiondb;
        private TextBox descriptionedge;
        private TextBox descriptionconnect;
        private TextBox descriptionser;
        private TextBox descriptionpublish;
        private TextBox descriptionplugin;
        private TextBox descriptionlogin;
        private TextBox descriptionitemres;
        private TextBox descriptioninit;
        private TextBox commandinit;
        private TextBox commanditemres;
        private TextBox commandlogin;
        private TextBox commandplugin;
        private TextBox commandpublish;
        private TextBox commandser;
        private TextBox commandconnect;
        private TextBox commandedge;
        private TextBox commanddb;
    }
}