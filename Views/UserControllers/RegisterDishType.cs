using GestorDeConsumo.Controllers;
using GestorDeConsumo.Database.Models;
using GestorDeConsumo.Views.UserControllers.MessageBoxes;

namespace GestorDeConsumo.Views.UserControllers
{
    public partial class RegisterDishType : UserControl
    {
        public RegisterDishType()
        {
            InitializeComponent();
        }

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
    }
}
