namespace Sitecore.GLI
{
    public partial class Settings : Form
    {
        private const int WS_MINIMIZEBOX = 0x20000;
        private const int CS_DBLCLKS = 0x8;

        int WindowMove;
        int WindowLocationX;
        int WindowLocationY;

        public Settings()
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

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void exit_MouseEnter(object sender, EventArgs e)
        {
            exit.BackgroundImage = Properties.Resources.red_x;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.BackgroundImage = Properties.Resources.white_x;
        }
    }
}
