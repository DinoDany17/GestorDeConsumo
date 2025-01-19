using System.Windows.Forms;

namespace GestorDeConsumo.Views.UserControllers.MessageBoxes
{
    public partial class ConfirmMessageBox : Form
    {
        public ConfirmMessageBox(string message)
        {
            InitializeComponent();
            ConfirmLabel.Text = message;
        }

        public static DialogResult Show(string message)
        {
            ConfirmMessageBox customMessageBox = new ConfirmMessageBox(message);
            customMessageBox.ShowDialog();
            return customMessageBox.DialogResult;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ButtonAgree_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
