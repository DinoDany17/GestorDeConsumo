using GestorDeConsumo.Controllers;
using GestorDeConsumo.Database.Models;
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
            string nameTrimmed = TextBoxName.Text.Trim();
            Employee? newEmployee = EmployeeController.RegisterEmployee(nameTrimmed, new byte[0]);
            if (newEmployee != null)
            {
                TableEmployee.Rows.Add(newEmployee.id, newEmployee.name);
                TextBoxName.Text = "";
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
            if (e.ColumnIndex == 3)
            {
                DialogResult response = ConfirmMessageBox.Show("¿Estás seguro de querer eliminar el registro de este empleado?");
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
                    Console.WriteLine("El nombre es demasiado corto.");
                    return;
                }
                int id = int.TryParse(currentRow.Cells[0].Value?.ToString(), out var parsedId) ? parsedId : -1;
                if (id == -1)
                {
                    currentCell.Value = originalCellValue;
                    Console.WriteLine("ID inválido.");
                    return;
                }
                bool success = EmployeeController.UpdateEmployee(id, currentColumn.Name, value);
                if (!success)
                {
                    currentCell.Value = originalCellValue;
                    Console.WriteLine("Error al actualizar el empleado.");
                }
            }

            originalCellValue = string.Empty;
        }
    }
}
