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

            string appPath = AppDomain.CurrentDomain.BaseDirectory;
            console.Text = $"{appPath}>";
            console.Focus();
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

        private async void toolsrestore_Click(object sender, EventArgs e)
        {
            string appPath = AppDomain.CurrentDomain.BaseDirectory;
            console.Text = $"{appPath}> dotnet tool restore\r\n";

            try
            {
                var process = new System.Diagnostics.Process
                {
                    StartInfo = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = "dotnet",
                        Arguments = "tool restore",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true,
                        WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory,
                        StandardOutputEncoding = System.Text.Encoding.UTF8,
                        StandardErrorEncoding = System.Text.Encoding.UTF8
                    }
                };

                process.OutputDataReceived += (s, args) =>
                {
                    if (!string.IsNullOrEmpty(args.Data))
                    {
                        console.Invoke(() => console.AppendText(args.Data + "\r\n"));
                    }
                };

                process.ErrorDataReceived += (s, args) =>
                {
                    if (!string.IsNullOrEmpty(args.Data))
                    {
                        console.Invoke(() => console.AppendText("ERROR: " + args.Data + "\r\n"));
                    }
                };

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                await process.WaitForExitAsync();

                console.AppendText($"\r\nCommand completed with exit code: {process.ExitCode}\r\n");
                console.Focus();
            }
            catch (Exception ex)
            {
                console.AppendText($"\r\nError: {ex.Message}\r\n");
                console.Focus();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string appPath = AppDomain.CurrentDomain.BaseDirectory;
            console.Text = $"{appPath}>";
        }
    }
}
