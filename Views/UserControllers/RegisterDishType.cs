using GestorDeConsumo.Controllers;
using GestorDeConsumo.Database.Models;
using GestorDeConsumo.Views.UserControllers.MessageBoxes;
using GestorDeConsumo.Utils;

namespace GestorDeConsumo.Views.UserControllers
{
    public partial class RegisterDishType : UserControl
    {
        public RegisterDishType()
        {
            InitializeComponent();
        }

        private string? originalCellValue = "";

        private void RegisterDishType_Load(object sender, EventArgs e)
        {
            foreach (DishType dish in DishTypeController.GetAllDishTypes())
            {
                TableDishType.Rows.Add(dish.id, dish.name, dish.cost);
            }
        }

        private void ButtonAddDishType_Click(object sender, EventArgs e)
        {
            string dishname = DishTypeTextBox.Text.Trim();
            decimal cost = CostNumericDropDown.Value;
            DishType? newDish = DishTypeController.RegisterDishType(dishname, cost);
            if (newDish != null)
            {
                TableDishType.Rows.Add(newDish.id, newDish.name, newDish.cost);
            }
        }

        private void DishTypeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DishTypeTextBox.Text.Length > 0)
            {
                ButtonAddDishType.Enabled = true;
            }
            else
            {
                ButtonAddDishType.Enabled = false;
            }
        }

        private void TableDishType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = TableDishType.Rows[e.RowIndex];
            if (e.ColumnIndex == 3)
            {
                DialogResult response = ConfirmMessageBox.Show("¿Estás seguro de querer eliminar este platillo?");
                if (response == DialogResult.OK)
                {
                    string stringId = currentRow.Cells[0].Value.ToString() ?? "-1";
                    int id = Int32.Parse(stringId);
                    if (id != -1)
                    {
                        bool success = DishTypeController.DeleteDishType(id);
                        if (success)
                        {
                            TableDishType.Rows.RemoveAt(e.RowIndex);
                        }
                    }
                }
            }
        }

        private void TableDishType_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            originalCellValue = TableDishType.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void TableDishType_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = TableDishType.Rows[e.RowIndex];
            DataGridViewColumn currentColumn = TableDishType.Columns[e.ColumnIndex];
            DataGridViewCell currentCell = currentRow.Cells[currentColumn.Index];
            var value = currentCell.Value;

            if (currentColumn.Name == "cost")
            {
                string? cellValue = currentCell.Value?.ToString();
                if (string.IsNullOrEmpty(cellValue) || !Validations.validateDecimal(cellValue))
                {
                    currentCell.Value = originalCellValue;
                    Console.WriteLine("Valor inválido para el campo 'costo'.");
                    return;
                }
                value = decimal.Parse(cellValue);
            }

            int id = int.TryParse(currentRow.Cells[0].Value?.ToString(), out var parsedId) ? parsedId : -1;
            if (id == -1)
            {
                Console.WriteLine("ID inválido.");
                currentCell.Value = originalCellValue;
                return;
            }

            bool success = DishTypeController.UpdateDishType(id, currentColumn.Name, value);
            if (!success)
            {
                currentCell.Value = originalCellValue;
                Console.WriteLine("Error al actualizar el platillo");
            }
        }
    }
}
