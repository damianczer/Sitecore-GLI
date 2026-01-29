namespace Sitecore.GLI
{
    public partial class Main : Form
    {
        private const int WS_MINIMIZEBOX = 0x20000;
        private const int CS_DBLCLKS = 0x8;

        int WindowMove;
        int WindowLocationX;
        int WindowLocationY;
        private Commands? commandsForm;

        public Main()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;

                return cp;
            }
        }

        private void topbar_MouseDown(object sender, MouseEventArgs e)
        {
            WindowMove = 1; WindowLocationX = e.X; WindowLocationY = e.Y;
        }

        private void topbar_MouseUp(object sender, MouseEventArgs e)
        {
            WindowMove = 0;
        }

        private void topbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (WindowMove == 1)
            {
                SetDesktopLocation(MousePosition.X - WindowLocationX, MousePosition.Y - WindowLocationY);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void exit_MouseEnter(object sender, EventArgs e)
        {
            exit.BackgroundImage = Properties.Resources.red_x;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.BackgroundImage = Properties.Resources.white_x;
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void logo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://damianczerwinski.pl/",
                UseShellExecute = true
            });
        }

        private void help_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://doc.sitecore.com/xp/en/developers/latest/developer-tools/sitecore-content-serialization.html",
                UseShellExecute = true
            });
        }

        private void commands_Click(object sender, EventArgs e)
        {
            if (commandsForm == null || commandsForm.IsDisposed)
            {
                commandsForm = new Commands();
                commandsForm.Show();
            }
            else
            {
                commandsForm.BringToFront();
                commandsForm.Focus();
            }
        }

        private void powershell_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    UseShellExecute = true,
                    Verb = "runas"
                });
            }
            catch (System.ComponentModel.Win32Exception)
            {
                // User canceled the UAC prompt
            }
        }
    }
}
