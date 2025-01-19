namespace GestorDeConsumo.Views
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
            MinimizeButton = new Button();
            WindowButton = new Button();
            CloseButton = new Button();
            MainPanel = new Panel();
            RegisterConsumptionInstance = new UserControllers.RegisterCosumption();
            RegisterEmployeeInstance = new UserControllers.RegisterEmployee();
            RegisterDishTypeInstance = new UserControllers.RegisterDishType();
            SideBar.SuspendLayout();
            Top.SuspendLayout();
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
            SideBar.TabIndex = 2;
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
            ButtonReports.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ButtonReports.BackColor = Color.Transparent;
            ButtonReports.FlatAppearance.BorderSize = 0;
            ButtonReports.FlatStyle = FlatStyle.Flat;
            ButtonReports.ForeColor = Color.FromArgb(165, 142, 116);
            ButtonReports.Location = new Point(0, 176);
            ButtonReports.Name = "ButtonReports";
            ButtonReports.Size = new Size(155, 40);
            ButtonReports.TabIndex = 1;
            ButtonReports.Text = "Reportes";
            ButtonReports.UseVisualStyleBackColor = false;
            // 
            // ButtonDishes
            // 
            ButtonDishes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            ButtonDishes.Click += ButtonDishes_Click;
            // 
            // ButtonCreateEmployee
            // 
            ButtonCreateEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ButtonCreateEmployee.BackColor = Color.Transparent;
            ButtonCreateEmployee.FlatAppearance.BorderSize = 0;
            ButtonCreateEmployee.FlatStyle = FlatStyle.Flat;
            ButtonCreateEmployee.ForeColor = Color.FromArgb(165, 142, 116);
            ButtonCreateEmployee.Location = new Point(0, 94);
            ButtonCreateEmployee.Name = "ButtonCreateEmployee";
            ButtonCreateEmployee.Size = new Size(155, 40);
            ButtonCreateEmployee.TabIndex = 3;
            ButtonCreateEmployee.Text = "Empleados";
            ButtonCreateEmployee.UseVisualStyleBackColor = false;
            ButtonCreateEmployee.Click += ButtonCreateEmployee_Click;
            // 
            // ButtonHome
            // 
            ButtonHome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ButtonHome.BackColor = Color.Transparent;
            ButtonHome.FlatAppearance.BorderSize = 0;
            ButtonHome.FlatStyle = FlatStyle.Flat;
            ButtonHome.ForeColor = Color.FromArgb(165, 142, 116);
            ButtonHome.Location = new Point(0, 53);
            ButtonHome.Name = "ButtonHome";
            ButtonHome.Size = new Size(155, 40);
            ButtonHome.TabIndex = 4;
            ButtonHome.Text = "Inicio";
            ButtonHome.UseVisualStyleBackColor = false;
            ButtonHome.Click += ButtonHome_Click;
            // 
            // Top
            // 
            Top.BackColor = Color.FromArgb(224, 145, 50);
            Top.Controls.Add(MinimizeButton);
            Top.Controls.Add(WindowButton);
            Top.Controls.Add(CloseButton);
            Top.Dock = DockStyle.Top;
            Top.Location = new Point(155, 0);
            Top.Name = "Top";
            Top.Size = new Size(1045, 35);
            Top.TabIndex = 1;
            // 
            // MinimizeButton
            // 
            MinimizeButton.Anchor = AnchorStyles.Right;
            MinimizeButton.BackColor = Color.Transparent;
            MinimizeButton.BackgroundImageLayout = ImageLayout.Zoom;
            MinimizeButton.FlatAppearance.BorderSize = 0;
            MinimizeButton.FlatStyle = FlatStyle.Flat;
            MinimizeButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            MinimizeButton.ForeColor = SystemColors.ButtonFace;
            MinimizeButton.Image = Properties.Resources.minimize;
            MinimizeButton.Location = new Point(934, 0);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.Size = new Size(35, 35);
            MinimizeButton.TabIndex = 0;
            MinimizeButton.TextAlign = ContentAlignment.TopCenter;
            MinimizeButton.UseVisualStyleBackColor = false;
            MinimizeButton.Click += MinimizeButton_Click;
            // 
            // WindowButton
            // 
            WindowButton.Anchor = AnchorStyles.Right;
            WindowButton.BackColor = Color.Transparent;
            WindowButton.BackgroundImageLayout = ImageLayout.Zoom;
            WindowButton.FlatAppearance.BorderSize = 0;
            WindowButton.FlatStyle = FlatStyle.Flat;
            WindowButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            WindowButton.ForeColor = SystemColors.ButtonFace;
            WindowButton.Image = Properties.Resources.fullscreen;
            WindowButton.Location = new Point(972, 0);
            WindowButton.Name = "WindowButton";
            WindowButton.Size = new Size(35, 35);
            WindowButton.TabIndex = 1;
            WindowButton.TextAlign = ContentAlignment.TopCenter;
            WindowButton.UseVisualStyleBackColor = false;
            WindowButton.Click += WindowButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Right;
            CloseButton.BackColor = Color.Transparent;
            CloseButton.BackgroundImageLayout = ImageLayout.Stretch;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            CloseButton.ForeColor = SystemColors.ButtonFace;
            CloseButton.Image = Properties.Resources.close;
            CloseButton.Location = new Point(1010, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(35, 35);
            CloseButton.TabIndex = 2;
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.WhiteSmoke;
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(155, 35);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1045, 565);
            MainPanel.TabIndex = 0;
            // 
            // RegisterConsumptionInstance
            // 
            RegisterConsumptionInstance.Dock = DockStyle.Fill;
            RegisterConsumptionInstance.Location = new Point(0, 0);
            RegisterConsumptionInstance.Name = "RegisterConsumptionInstance";
            RegisterConsumptionInstance.Size = new Size(1045, 565);
            RegisterConsumptionInstance.TabIndex = 0;
            // 
            // RegisterEmployeeInstance
            // 
            RegisterEmployeeInstance.Dock = DockStyle.Fill;
            RegisterEmployeeInstance.Location = new Point(0, 0);
            RegisterEmployeeInstance.Name = "RegisterEmployeeInstance";
            RegisterEmployeeInstance.Size = new Size(1045, 565);
            RegisterEmployeeInstance.TabIndex = 0;
            // 
            // RegisterDishTypeInstance
            // 
            RegisterDishTypeInstance.Dock = DockStyle.Fill;
            RegisterDishTypeInstance.Location = new Point(0, 0);
            RegisterDishTypeInstance.Name = "RegisterDishTypeInstance";
            RegisterDishTypeInstance.Size = new Size(1045, 565);
            RegisterDishTypeInstance.TabIndex = 0;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 600);
            Controls.Add(MainPanel);
            Controls.Add(Top);
            Controls.Add(SideBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestor de consumo";
            Load += HomePage_Load;
            SideBar.ResumeLayout(false);
            Top.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel SideBar;
        private Panel Top;
        private Panel MainPanel;
        private Button ButtonHome;
        private Button ButtonInfo;
        private Button ButtonReports;
        private Button ButtonDishes;
        private Button ButtonCreateEmployee;
        private UserControllers.RegisterCosumption RegisterConsumptionInstance;
        private UserControllers.RegisterEmployee RegisterEmployeeInstance;
        private UserControllers.RegisterDishType RegisterDishTypeInstance;
        private Button WindowButton;
        private Button CloseButton;
        private Button MinimizeButton;
    }
}