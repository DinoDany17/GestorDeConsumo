namespace GestorDeConsumo.Views.UserControllers.MessageBoxes
{
    public partial class CustomMessageBox : Form
    {
        CustomMessageBoxType type;
        public CustomMessageBox(string message, CustomMessageBoxType type)
        {
            InitializeComponent();
            ConfirmLabel.Text = message;
            this.type = type;
            switch (type)
            {
                case CustomMessageBoxType.Error:
                    IconPictureBox.BackgroundImage = Properties.Resources.error;
                    ButtonCancel.Visible = false;
                    break;
                case CustomMessageBoxType.Confirm:
                    IconPictureBox.BackgroundImage = Properties.Resources.question;
                    ButtonCancel.Visible = true;
                    break;
                case CustomMessageBoxType.Info:
                    IconPictureBox.BackgroundImage = Properties.Resources.info;
                    ButtonCancel.Visible = false;
                    break;
                case CustomMessageBoxType.Warning:
                default:
                    IconPictureBox.BackgroundImage = Properties.Resources.warning;
                    ButtonCancel.Visible = false;
                    break;
            }
        }

        public static DialogResult Show(string message, CustomMessageBoxType type)
        {
            CustomMessageBox customMessageBox = new CustomMessageBox(message, type);
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

    public enum CustomMessageBoxType
    {
        Error,
        Confirm,
        Info,
        Warning
    }
}
