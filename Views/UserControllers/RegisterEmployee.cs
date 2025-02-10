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
        private bool validEmpNumber = false;
        private bool validName = false;

        private void RegisterEmployee_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            foreach (Employee employee in EmployeeController.GetAllEmployees())
            {
                TableEmployee.Rows.Add(employee.id, employee.emp_number, employee.name);
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
                    int emp_number = Int32.Parse(EmpNumberUpDown.Text);
                    string nameTrimmed = TextBoxName.Text.Trim();
                    Employee? newEmployee = EmployeeController.RegisterEmployee(emp_number, nameTrimmed, fingerprint);
                    if (newEmployee != null)
                    {
                        TableEmployee.Rows.Add(newEmployee.id, newEmployee.emp_number, newEmployee.name);
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
            validName = textTrimmed != "";
            EnableButtonFingerprint();
        }

        private void TableEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = TableEmployee.Rows[e.RowIndex];
            if (e.ColumnIndex == 3)
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
            if (currentColumn.Name == "emp_number")
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
                    CustomMessageBox.Show("Id de empleado inválido", CustomMessageBoxType.Error);
                    return;
                }
                bool success = EmployeeController.UpdateEmployee(id, currentColumn.Name, value);
                if (!success)
                {
                    currentCell.Value = originalCellValue;
                    CustomMessageBox.Show("Error al actualizar el empleado", CustomMessageBoxType.Error);
                }
            }
            if (currentColumn.Name == "emp_number")
            {
                string? value = currentCell.Value?.ToString();
                int valueInt = int.TryParse(value, out var parsedValue) ? parsedValue : -1;
                if (string.IsNullOrEmpty(value) || valueInt < 1)
                {
                    currentCell.Value = originalCellValue;
                    CustomMessageBox.Show("El número de empleado no puede ser menor a 1", CustomMessageBoxType.Warning);
                    return;
                }
                int id = int.TryParse(currentRow.Cells[0].Value?.ToString(), out var parsedId) ? parsedId : -1;
                if (id == -1)
                {
                    currentCell.Value = originalCellValue;
                    CustomMessageBox.Show("Id de empleado inválido", CustomMessageBoxType.Error);
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

        private void TableEmployee_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.AdvancedBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            }
            if (e.ColumnIndex == 3)
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
            TextBoxName.Text = "";
            TableEmployee.Rows.Clear();
            LoadEmployees();
        }

        private void EnableButtonFingerprint()
        {
            ButtonFingerprint.Enabled = validEmpNumber && validName;
        }

        private void EmpNumberUpDown_ValueChanged(object sender, EventArgs e)
        {
            int empNumber = Int32.Parse(EmpNumberUpDown.Text);
            validEmpNumber = empNumber > 0;
            EnableButtonFingerprint();
        }

        private void EmpNumberUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
