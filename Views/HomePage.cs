namespace GestorDeConsumo.Views
{
    public partial class HomePage : Form
    {
        private bool _isFullscreenModeEnabled = false;
        private bool dragging = false;
        private Point start_point = new Point(0, 0);
        public HomePage()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            MoveInstanceToPanel(RegisterConsumptionInstance);
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            MoveInstanceToPanel(RegisterConsumptionInstance);
        }

        private void ButtonCreateEmployee_Click(object sender, EventArgs e)
        {
            MoveInstanceToPanel(RegisterEmployeeInstance);
        }

        private void ButtonDishes_Click(object sender, EventArgs e)
        {
            MoveInstanceToPanel(RegisterDishTypeInstance);
        }

        private void MoveInstanceToPanel(Control control)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(control);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WindowButton_Click(object sender, EventArgs e)
        {
            if (_isFullscreenModeEnabled)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
            _isFullscreenModeEnabled = !_isFullscreenModeEnabled;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                start_point = new Point(e.X, e.Y);
            }
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.start_point.X, p.Y - this.start_point.Y);
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}