using GestorDeConsumo.Controllers;
using GestorDeConsumo.Views.UserControllers.MessageBoxes;
using GestorDeConsumo.Views.Fingerprint;
using GestorDeConsumo.Database.Models;
using System.Windows.Forms;
using GestorDeConsumo.Utils;

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
            LoadConsumptions();
        }

        private void LoadConsumptions()
        {
            foreach (string name in Enums.dishTypes.Select(dish => dish.name))
            {
                ComboBoxDishType.Items.Add(name);
            }
            foreach (ConsumptionTableRow tb in ConsumptionController.GetConsumptionsForTable())
            {
                TableConsumption.Rows.Add(tb.id, tb.hour, tb.employee, tb.dish);
            }
        }

        private void ButtonFingerprint_Click(object sender, EventArgs e)
        {
            Employee? verifiedEmployee = null;
            VerifyFingerprint verifyFingerprint = new VerifyFingerprint();
            verifyFingerprint.OnTemplate += (Employee? employee) =>
            {
                verifiedEmployee = employee;
            };
            DialogResult result = verifyFingerprint.ShowDialog();
            switch (result)
            {
                case DialogResult.Abort:
                    CustomMessageBox.Show("No se pudo iniciar la captura", CustomMessageBoxType.Error);
                    break;
                case DialogResult.Cancel:
                    CustomMessageBox.Show("La captura fue cancelada por el usuario", CustomMessageBoxType.Warning);
                    break;
                case DialogResult.OK:
                    if (verifiedEmployee != null)
                    {
                        (int id, string hour, string name, string dish)? resp = ConsumptionController.RegisterConsumption(ComboBoxDishType.Text, verifiedEmployee);
                        if (resp != null)
                        {
                            TableConsumption.Rows.Add(resp.Value.id, resp.Value.hour, resp.Value.name, resp.Value.dish);
                        }
                    }
                    break;
                default:
                    CustomMessageBox.Show("Error desconocido", CustomMessageBoxType.Error);
                    break;
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
                DialogResult response = CustomMessageBox.Show("¿Estás seguro de querer eliminar el registro de este consumo?", CustomMessageBoxType.Confirm);
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

        private void TableConsumption_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.AdvancedBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            }
            if (e.ColumnIndex == 4)
            {
                e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            }
            if (e.RowIndex == -1)
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
        }

        public void ClearControl()
        {
            ComboBoxDishType.SelectedIndex = -1;
            ButtonFingerprint.Enabled = false;
            TableConsumption.Rows.Clear();
            LoadConsumptions();
        }
    }
}
