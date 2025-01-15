namespace GestorDeConsumo.Views
{
    public partial class RegisterCosumption : UserControl
    {
        public RegisterCosumption()
        {
            InitializeComponent();
        }

        private void ButtonFingerprint_Click(object sender, EventArgs e)
        {
            string timeStamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string dishType = ComboBoxDishType.Text;
            string hour = timeStamp.Split(' ')[1];
            string[] values = { hour, "Daniel Ivan Rodriguez Espinoza", dishType };
            TableConsumption.Rows.Add(values);
        }
    }
}
