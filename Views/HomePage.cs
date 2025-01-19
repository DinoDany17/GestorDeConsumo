namespace GestorDeConsumo.Views
{
    public partial class HomePage : Form
    {
        private bool _isFullscreenModeEnabled = false;
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
    }
}