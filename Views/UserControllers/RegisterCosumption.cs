using GestorDeConsumo.Controllers;
using GestorDeConsumo.Views.UserControllers.MessageBoxes;

namespace GestorDeConsumo.Views.UserControllers
{
    public partial class RegisterCosumption : UserControl
    {
        public RegisterCosumption()
        {
            InitializeComponent();
        }

        private void RegisterCosumption_Load(object sender, EventArgs e)
        {
            foreach (string name in Enums.dishTypes.Select(dish => dish.name))
            {
                ComboBoxDishType.Items.Add(name);
            }
            foreach ((int id, string hour, string employee_name, string dish) in ConsumptionController.GetConsumptionsForTable())
            {
                TableConsumption.Rows.Add(id, hour, employee_name, dish);
            }
        }

        private void ButtonFingerprint_Click(object sender, EventArgs e)
        {
            (int id, string hour, string name, string dish)? resp = ConsumptionController.RegisterConsumption(ComboBoxDishType.Text);
            if (resp != null)
            {
                TableConsumption.Rows.Add(resp.Value.id, resp.Value.hour, resp.Value.name, resp.Value.dish);
            }
        }

        private void ComboBoxDishType_Click(object sender, EventArgs e)
        {
            ComboBoxDishType.Items.Clear();
            foreach (string name in Enums.dishTypes.Select(dish => dish.name))
            {
                ComboBoxDishType.Items.Add(name);
            }
        }

        private void ComboBoxDishType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxDishType.SelectedIndex == -1)
            {
                ButtonFingerprint.Enabled = false;
            }
            else
            {
                ButtonFingerprint.Enabled = true;
            }
        }

        private void TableConsumption_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = TableConsumption.Rows[e.RowIndex];
            if (e.ColumnIndex == 4)
            {
                DialogResult response = ConfirmMessageBox.Show("¿Estás seguro de querer eliminar el registro de este consumo?");
                if (response == DialogResult.OK)
                {
                    string stringId = currentRow.Cells[0].Value.ToString() ?? "-1";
                    int id = Int32.Parse(stringId);
                    if (id != -1)
                    {
                        bool success = ConsumptionController.DeleteConsumption(id);
                        if (success)
                        {
                            TableConsumption.Rows.RemoveAt(e.RowIndex);
                        }
                    }
                }
            }
        }
    }
}
