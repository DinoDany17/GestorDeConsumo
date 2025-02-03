using GestorDeConsumo.Controllers;
using GestorDeConsumo.Views.UserControllers.MessageBoxes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeConsumo.Views.UserControllers
{
    public partial class BackupRestore : UserControl
    {
        private static string directorio = Environment.GetEnvironmentVariable("APP_DIRECTORY") ?? "";
        private static string databaseLocation = Path.Combine(directorio, "Database", "master.db");
        private static string selectedBackup = "";
        public BackupRestore()
        {
            InitializeComponent();
        }

        private void ButtonBackup_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = $"backup{DateTime.Today.ToString("yyMMdd")}.db";
            saveFileDialog.Filter = "SQLite files (*.db)|*.db";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                try
                {
                    File.Copy(databaseLocation, filePath, true);
                    CustomMessageBox.Show("Copia de seguridad realizada con éxito", CustomMessageBoxType.Info);
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show($"Error al realizar la copia de seguridad: {ex.Message}", CustomMessageBoxType.Error);
                }
            }
            else
            {
                CustomMessageBox.Show("No se seleccionó ninguna ruta", CustomMessageBoxType.Warning);
            }
        }

        private void ButtonLoadBackup_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "SQLite files (*.db)|*.db";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedBackup = openFileDialog.FileName;
                SelectedBackupTextBox.Text = selectedBackup;
                ButtonRestore.Enabled = true;
                CustomMessageBox.Show("Se cargó la copia de seguridad", CustomMessageBoxType.Info);
            }
            else
            {
                CustomMessageBox.Show("No se seleccionó ninguna ruta", CustomMessageBoxType.Warning);
            }
        }

        private void ButtonRestore_Click(object sender, EventArgs e)
        {
            try
            {
                File.Copy(selectedBackup, databaseLocation, true);
                CustomMessageBox.Show("Copia de seguridad restaurada con éxito", CustomMessageBoxType.Info);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show($"Error al restaurar la copia de seguridad: {ex.Message}", CustomMessageBoxType.Error);
            }
        }
    }
}
