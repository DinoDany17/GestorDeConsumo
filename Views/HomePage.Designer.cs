namespace GestorDeConsumo
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SideBar = new Panel();
            ButtonInfo = new Button();
            ButtonReports = new Button();
            ButtonDishes = new Button();
            ButtonCreateEmployee = new Button();
            ButtonHome = new Button();
            Top = new Panel();
            panel1 = new Panel();
            registerCosumption1 = new Views.RegisterCosumption();
            SideBar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SideBar
            // 
            SideBar.BackColor = Color.FromArgb(66, 69, 48);
            SideBar.Controls.Add(ButtonInfo);
            SideBar.Controls.Add(ButtonReports);
            SideBar.Controls.Add(ButtonDishes);
            SideBar.Controls.Add(ButtonCreateEmployee);
            SideBar.Controls.Add(ButtonHome);
            SideBar.Dock = DockStyle.Left;
            SideBar.Location = new Point(0, 0);
            SideBar.Name = "SideBar";
            SideBar.Size = new Size(155, 600);
            SideBar.TabIndex = 0;
            // 
            // ButtonInfo
            // 
            ButtonInfo.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonInfo.FlatAppearance.BorderSize = 0;
            ButtonInfo.FlatStyle = FlatStyle.Flat;
            ButtonInfo.Location = new Point(0, 568);
            ButtonInfo.Name = "ButtonInfo";
            ButtonInfo.Size = new Size(32, 32);
            ButtonInfo.TabIndex = 0;
            ButtonInfo.Text = "Inf";
            ButtonInfo.UseVisualStyleBackColor = true;
            // 
            // ButtonReports
            // 
            ButtonReports.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ButtonReports.BackColor = Color.Transparent;
            ButtonReports.FlatAppearance.BorderSize = 0;
            ButtonReports.FlatStyle = FlatStyle.Flat;
            ButtonReports.ForeColor = Color.FromArgb(165, 142, 116);
            ButtonReports.Location = new Point(0, 176);
            ButtonReports.Name = "ButtonReports";
            ButtonReports.Size = new Size(155, 40);
            ButtonReports.TabIndex = 3;
            ButtonReports.Text = "Reportes";
            ButtonReports.UseVisualStyleBackColor = false;
            // 
            // ButtonDishes
            // 
            ButtonDishes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ButtonDishes.BackColor = Color.Transparent;
            ButtonDishes.FlatAppearance.BorderSize = 0;
            ButtonDishes.FlatStyle = FlatStyle.Flat;
            ButtonDishes.ForeColor = Color.FromArgb(165, 142, 116);
            ButtonDishes.Location = new Point(0, 135);
            ButtonDishes.Name = "ButtonDishes";
            ButtonDishes.Size = new Size(155, 40);
            ButtonDishes.TabIndex = 2;
            ButtonDishes.Text = "Platillos";
            ButtonDishes.UseVisualStyleBackColor = false;
            // 
            // ButtonCreateEmployee
            // 
            ButtonCreateEmployee.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ButtonCreateEmployee.BackColor = Color.Transparent;
            ButtonCreateEmployee.FlatAppearance.BorderSize = 0;
            ButtonCreateEmployee.FlatStyle = FlatStyle.Flat;
            ButtonCreateEmployee.ForeColor = Color.FromArgb(165, 142, 116);
            ButtonCreateEmployee.Location = new Point(0, 94);
            ButtonCreateEmployee.Name = "ButtonCreateEmployee";
            ButtonCreateEmployee.Size = new Size(155, 40);
            ButtonCreateEmployee.TabIndex = 1;
            ButtonCreateEmployee.Text = "Empleados";
            ButtonCreateEmployee.UseVisualStyleBackColor = false;
            // 
            // ButtonHome
            // 
            ButtonHome.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ButtonHome.BackColor = Color.Transparent;
            ButtonHome.FlatAppearance.BorderSize = 0;
            ButtonHome.FlatStyle = FlatStyle.Flat;
            ButtonHome.ForeColor = Color.FromArgb(165, 142, 116);
            ButtonHome.Location = new Point(0, 53);
            ButtonHome.Name = "ButtonHome";
            ButtonHome.Size = new Size(155, 40);
            ButtonHome.TabIndex = 0;
            ButtonHome.Text = "Inicio";
            ButtonHome.UseVisualStyleBackColor = false;
            // 
            // Top
            // 
            Top.BackColor = Color.FromArgb(224, 145, 50);
            Top.Dock = DockStyle.Top;
            Top.Location = new Point(155, 0);
            Top.Name = "Top";
            Top.Size = new Size(1045, 35);
            Top.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(registerCosumption1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(155, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(1045, 565);
            panel1.TabIndex = 2;
            // 
            // registerCosumption1
            // 
            registerCosumption1.Dock = DockStyle.Fill;
            registerCosumption1.Location = new Point(0, 0);
            registerCosumption1.Name = "registerCosumption1";
            registerCosumption1.Size = new Size(1045, 565);
            registerCosumption1.TabIndex = 0;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 600);
            Controls.Add(panel1);
            Controls.Add(Top);
            Controls.Add(SideBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestor de consumo";
            SideBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel SideBar;
        private Panel Top;
        private Panel panel1;
        private Button ButtonHome;
        private Button ButtonInfo;
        private Button ButtonReports;
        private Button ButtonDishes;
        private Button ButtonCreateEmployee;
        private Views.RegisterCosumption registerCosumption1;
    }
}