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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            SideBar = new Panel();
            ButtonBackup = new Button();
            ButtonReports = new Button();
            ButtonDishes = new Button();
            ButtonCreateEmployee = new Button();
            ButtonHome = new Button();
            TopPanel = new Panel();
            MinimizeButton = new Button();
            WindowButton = new Button();
            CloseButton = new Button();
            MainPanel = new Panel();
            BackupRestoreInstance = new UserControllers.BackupRestore(this);
            RegisterConsumptionInstance = new UserControllers.RegisterCosumption();
            RegisterEmployeeInstance = new UserControllers.RegisterEmployee();
            RegisterDishTypeInstance = new UserControllers.RegisterDishType();
            ReportGenerationInstance = new UserControllers.ReportGeneration();
            SideBar.SuspendLayout();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SideBar
            // 
            SideBar.BackColor = Color.FromArgb(66, 69, 48);
            SideBar.Controls.Add(ButtonBackup);
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
            // ButtonBackup
            // 
            ButtonBackup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ButtonBackup.BackColor = Color.Transparent;
            ButtonBackup.FlatAppearance.BorderSize = 0;
            ButtonBackup.FlatStyle = FlatStyle.Flat;
            ButtonBackup.ForeColor = Color.FromArgb(165, 142, 116);
            ButtonBackup.Location = new Point(0, 225);
            ButtonBackup.Name = "ButtonBackup";
            ButtonBackup.Size = new Size(155, 40);
            ButtonBackup.TabIndex = 5;
            ButtonBackup.Text = "Base de datos";
            ButtonBackup.UseVisualStyleBackColor = false;
            ButtonBackup.Click += ButtonBackup_Click;
            // 
            // ButtonReports
            // 
            ButtonReports.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ButtonReports.BackColor = Color.Transparent;
            ButtonReports.FlatAppearance.BorderSize = 0;
            ButtonReports.FlatStyle = FlatStyle.Flat;
            ButtonReports.ForeColor = Color.FromArgb(165, 142, 116);
            ButtonReports.Location = new Point(0, 182);
            ButtonReports.Name = "ButtonReports";
            ButtonReports.Size = new Size(155, 40);
            ButtonReports.TabIndex = 1;
            ButtonReports.Text = "Reportes";
            ButtonReports.UseVisualStyleBackColor = false;
            ButtonReports.Click += ButtonReports_Click;
            // 
            // ButtonDishes
            // 
            ButtonDishes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ButtonDishes.BackColor = Color.Transparent;
            ButtonDishes.FlatAppearance.BorderSize = 0;
            ButtonDishes.FlatStyle = FlatStyle.Flat;
            ButtonDishes.ForeColor = Color.FromArgb(165, 142, 116);
            ButtonDishes.Location = new Point(0, 139);
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
            ButtonCreateEmployee.Location = new Point(0, 96);
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
            // TopPanel
            // 
            TopPanel.BackColor = Color.FromArgb(224, 145, 50);
            TopPanel.Controls.Add(MinimizeButton);
            TopPanel.Controls.Add(WindowButton);
            TopPanel.Controls.Add(CloseButton);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(155, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(1045, 35);
            TopPanel.TabIndex = 1;
            TopPanel.MouseDown += TopPanel_MouseDown;
            TopPanel.MouseMove += TopPanel_MouseMove;
            TopPanel.MouseUp += TopPanel_MouseUp;
            // 
            // MinimizeButton
            // 
            MinimizeButton.Anchor = AnchorStyles.Right;
            MinimizeButton.BackColor = Color.Transparent;
            MinimizeButton.BackgroundImageLayout = ImageLayout.Zoom;
            MinimizeButton.FlatAppearance.BorderSize = 0;
            MinimizeButton.FlatStyle = FlatStyle.Flat;
            MinimizeButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            MinimizeButton.ForeColor = Color.Gray;
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
            WindowButton.ForeColor = Color.Gray;
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
            CloseButton.ForeColor = Color.Gray;
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
            // BackupRestoreInstance
            // 
            BackupRestoreInstance.Dock = DockStyle.Fill;
            BackupRestoreInstance.Location = new Point(0, 0);
            BackupRestoreInstance.Name = "BackupRestoreInstance";
            BackupRestoreInstance.Size = new Size(1045, 565);
            BackupRestoreInstance.TabIndex = 0;
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
            // ReportGenerationInstance
            // 
            ReportGenerationInstance.Dock = DockStyle.Fill;
            ReportGenerationInstance.Location = new Point(0, 0);
            ReportGenerationInstance.Name = "ReportGenerationInstance";
            ReportGenerationInstance.Size = new Size(1045, 565);
            ReportGenerationInstance.TabIndex = 0;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 600);
            Controls.Add(MainPanel);
            Controls.Add(TopPanel);
            Controls.Add(SideBar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestor de consumo";
            Load += HomePage_Load;
            SideBar.ResumeLayout(false);
            TopPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel SideBar;
        private Panel TopPanel;
        private Panel MainPanel;
        private Button ButtonHome;
        private Button ButtonReports;
        private Button ButtonDishes;
        private Button ButtonCreateEmployee;
        private UserControllers.RegisterCosumption RegisterConsumptionInstance;
        private UserControllers.RegisterEmployee RegisterEmployeeInstance;
        private UserControllers.RegisterDishType RegisterDishTypeInstance;
        private Button WindowButton;
        private Button CloseButton;
        private Button MinimizeButton;
        private UserControllers.BackupRestore BackupRestoreInstance;
        private Button ButtonBackup;
        private UserControllers.ReportGeneration ReportGenerationInstance;
    }
}