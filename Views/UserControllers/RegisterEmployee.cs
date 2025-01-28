using GestorDeConsumo.Controllers;
using GestorDeConsumo.Database.Models;
using GestorDeConsumo.Views.Fingerprint;
using GestorDeConsumo.Views.UserControllers.MessageBoxes;

namespace GestorDeConsumo.Views.UserControllers
{
    public partial class RegisterEmployee : UserControl
    {
        public RegisterEmployee()
        {
            InitializeComponent();
        }

        private string? originalCellValue = "";

        private void RegisterEmployee_Load(object sender, EventArgs e)
        {
            foreach (Employee employee in EmployeeController.GetAllEmployees())
            {
                TableEmployee.Rows.Add(employee.id, employee.name);
            }
        }

        private void ButtonFingerprint_Click(object sender, EventArgs e)
        {
            byte[] fingerprint = new byte[0];
            CaptureFingerprint fingerprintCapture = new CaptureFingerprint();
            fingerprintCapture.OnTemplate += (DPFP.Template? template) =>
            {
                if (template != null)
                {
                    fingerprint = new byte[template.Bytes.Length];
                    template.Serialize(ref fingerprint);
                }
                else
                {
                    CustomMessageBox.Show("No se pudo capturar la huella", CustomMessageBoxType.Error);
                }
            };
            DialogResult result = fingerprintCapture.ShowDialog();
            switch (result)
            {
                case DialogResult.Abort:
                    CustomMessageBox.Show("No se pudo iniciar la captura", CustomMessageBoxType.Error);
                    break;
                case DialogResult.Cancel:
                    CustomMessageBox.Show("La captura fue cancelada por el usuario", CustomMessageBoxType.Warning);
                    break;
                case DialogResult.OK:
                    string nameTrimmed = TextBoxName.Text.Trim();
                    Employee? newEmployee = EmployeeController.RegisterEmployee(nameTrimmed, fingerprint);
                    if (newEmployee != null)
                    {
                        TableEmployee.Rows.Add(newEmployee.id, newEmployee.name);
                        TextBoxName.Text = "";
                    }
                    break;
                default:
                    CustomMessageBox.Show("Error desconocido", CustomMessageBoxType.Error);
                    break;
            }
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            string textTrimmed = TextBoxName.Text.Trim();
            if (textTrimmed == "")
            {
                ButtonFingerprint.Enabled = false;
            }
            else
            {
                ButtonFingerprint.Enabled = true;
            }
        }

        private void TableEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = TableEmployee.Rows[e.RowIndex];
            if (e.ColumnIndex == 2)
            {
                DialogResult response = CustomMessageBox.Show("¿Estás seguro de querer eliminar el registro de este empleado?", CustomMessageBoxType.Confirm);
                if (response == DialogResult.OK)
                {
                    string stringId = currentRow.Cells[0].Value.ToString() ?? "-1";
                    int id = Int32.Parse(stringId);
                    if (id != -1)
                    {
                        bool success = EmployeeController.DeleteEmployee(id);
                        if (success)
                        {
                            TableEmployee.Rows.RemoveAt(e.RowIndex);
                        }
                    }
                }
            }
        }

        private void TableEmployee_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewColumn currentColumn = TableEmployee.Columns[e.ColumnIndex];
            if (currentColumn.Name == "name")
            {
                originalCellValue = TableEmployee.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }

        private void TableEmployee_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = TableEmployee.Rows[e.RowIndex];
            DataGridViewColumn currentColumn = TableEmployee.Columns[e.ColumnIndex];
            DataGridViewCell currentCell = currentRow.Cells[currentColumn.Index];
            if (currentColumn.Name == "name")
            {
                string? value = currentCell.Value?.ToString();
                if (string.IsNullOrEmpty(value) || value.Length <= 3)
                {
                    currentCell.Value = originalCellValue; 
                    CustomMessageBox.Show("El nombre es demasiado corto", CustomMessageBoxType.Warning);
                    return;
                }
                int id = int.TryParse(currentRow.Cells[0].Value?.ToString(), out var parsedId) ? parsedId : -1;
                if (id == -1)
                {
                    currentCell.Value = originalCellValue;
                    CustomMessageBox.Show("Id inválido", CustomMessageBoxType.Error);
                    return;
                }
                bool success = EmployeeController.UpdateEmployee(id, currentColumn.Name, value);
                if (!success)
                {
                    currentCell.Value = originalCellValue;
                    CustomMessageBox.Show("Error al actualizar el empleado", CustomMessageBoxType.Error);
                }
            }

            originalCellValue = string.Empty;
        }
    }
}
