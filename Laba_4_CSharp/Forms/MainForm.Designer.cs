namespace Laba_4_CSharp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Elipse = new Guna.UI.WinForms.GunaElipse(this.components);
            this.GalacticTable = new System.Windows.Forms.DataGridView();
            this.GalacticNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GalacticName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GalacticObjects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.GalacticsTab = new System.Windows.Forms.TabPage();
            this.EditButtonGalactic = new Guna.UI.WinForms.GunaAdvenceButton();
            this.AddButtonGalactic = new Guna.UI.WinForms.GunaAdvenceButton();
            this.RefreshButtonGalactic = new Guna.UI.WinForms.GunaAdvenceButton();
            this.DeleteButtonGalactics = new Guna.UI.WinForms.GunaAdvenceButton();
            this.PlanetsTab = new System.Windows.Forms.TabPage();
            this.EditButtonPlanet = new Guna.UI.WinForms.GunaAdvenceButton();
            this.AddButtonPlanets = new Guna.UI.WinForms.GunaAdvenceButton();
            this.RefreshButtonPlanets = new Guna.UI.WinForms.GunaAdvenceButton();
            this.DeleteButtonPlanets = new Guna.UI.WinForms.GunaAdvenceButton();
            this.PlanetsTable = new System.Windows.Forms.DataGridView();
            this.PlanetNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanetMass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanetSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StarsTab = new System.Windows.Forms.TabPage();
            this.EditButtonStars = new Guna.UI.WinForms.GunaAdvenceButton();
            this.AddButtonStars = new Guna.UI.WinForms.GunaAdvenceButton();
            this.RefreshButtonStars = new Guna.UI.WinForms.GunaAdvenceButton();
            this.DeleteButtonStars = new Guna.UI.WinForms.GunaAdvenceButton();
            this.StarsTable = new System.Windows.Forms.DataGridView();
            this.StarNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StarSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StarFar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StarMass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollapseButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.CloseButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.NumberOfGalacticTextbox = new System.Windows.Forms.TextBox();
            this.GalacticNameTextbox = new System.Windows.Forms.TextBox();
            this.NumOfObjTextbox = new System.Windows.Forms.TextBox();
            this.SaveButtonGalactic = new Guna.UI.WinForms.GunaAdvenceButton();
            this.NumberOfGalacticLabel = new System.Windows.Forms.Label();
            this.NameOfGalacticLabel = new System.Windows.Forms.Label();
            this.NumOfObjGalacticLabel = new System.Windows.Forms.Label();
            this.EditSaveButtonGalactic = new Guna.UI.WinForms.GunaAdvenceButton();
            this.NumberOfPlanetLabel = new System.Windows.Forms.Label();
            this.NumberOfPlanetTextbox = new System.Windows.Forms.TextBox();
            this.NameOfPlanetLabel = new System.Windows.Forms.Label();
            this.NameOfPlanetTextbox = new System.Windows.Forms.TextBox();
            this.MassOfPlanetLabel = new System.Windows.Forms.Label();
            this.MassOfPlanetTextbox = new System.Windows.Forms.TextBox();
            this.SizeOfPlanetLabel = new System.Windows.Forms.Label();
            this.SizeOfPlanetTextbox = new System.Windows.Forms.TextBox();
            this.EditSaveButtonPlanet = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SaveButtonPlanet = new Guna.UI.WinForms.GunaAdvenceButton();
            this.FarOfStarLabel = new System.Windows.Forms.Label();
            this.FarOfStarTextbox = new System.Windows.Forms.TextBox();
            this.SizeOfStarLabel = new System.Windows.Forms.Label();
            this.SizeOfStarTextbox = new System.Windows.Forms.TextBox();
            this.NameOfStarLabel = new System.Windows.Forms.Label();
            this.NameOfStarTextbox = new System.Windows.Forms.TextBox();
            this.NumberOfStarLabel = new System.Windows.Forms.Label();
            this.NumberOfStarTextbox = new System.Windows.Forms.TextBox();
            this.SaveStarButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SaveEditStarButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.MassOfStarLabel = new System.Windows.Forms.Label();
            this.MassOfStarTextbox = new System.Windows.Forms.TextBox();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ReturnButton = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.GalacticTable)).BeginInit();
            this.Tabs.SuspendLayout();
            this.GalacticsTab.SuspendLayout();
            this.PlanetsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlanetsTable)).BeginInit();
            this.StarsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StarsTable)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.Radius = 9;
            this.Elipse.TargetControl = this;
            // 
            // GalacticTable
            // 
            this.GalacticTable.AllowUserToAddRows = false;
            this.GalacticTable.AllowUserToDeleteRows = false;
            this.GalacticTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.GalacticTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GalacticTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GalacticNumber,
            this.GalacticName,
            this.GalacticObjects});
            this.GalacticTable.Location = new System.Drawing.Point(1, 0);
            this.GalacticTable.Name = "GalacticTable";
            this.GalacticTable.Size = new System.Drawing.Size(799, 314);
            this.GalacticTable.TabIndex = 1;
            // 
            // GalacticNumber
            // 
            this.GalacticNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GalacticNumber.HeaderText = "Номер Галактики";
            this.GalacticNumber.Name = "GalacticNumber";
            // 
            // GalacticName
            // 
            this.GalacticName.HeaderText = "Название галактики";
            this.GalacticName.Name = "GalacticName";
            this.GalacticName.Width = 332;
            // 
            // GalacticObjects
            // 
            this.GalacticObjects.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GalacticObjects.HeaderText = "Количество объектов";
            this.GalacticObjects.Name = "GalacticObjects";
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.GalacticsTab);
            this.Tabs.Controls.Add(this.PlanetsTab);
            this.Tabs.Controls.Add(this.StarsTab);
            this.Tabs.Location = new System.Drawing.Point(12, 39);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(808, 395);
            this.Tabs.TabIndex = 2;
            this.Tabs.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // GalacticsTab
            // 
            this.GalacticsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.GalacticsTab.Controls.Add(this.EditButtonGalactic);
            this.GalacticsTab.Controls.Add(this.AddButtonGalactic);
            this.GalacticsTab.Controls.Add(this.RefreshButtonGalactic);
            this.GalacticsTab.Controls.Add(this.DeleteButtonGalactics);
            this.GalacticsTab.Controls.Add(this.GalacticTable);
            this.GalacticsTab.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GalacticsTab.Location = new System.Drawing.Point(4, 22);
            this.GalacticsTab.Name = "GalacticsTab";
            this.GalacticsTab.Padding = new System.Windows.Forms.Padding(3);
            this.GalacticsTab.Size = new System.Drawing.Size(800, 369);
            this.GalacticsTab.TabIndex = 0;
            this.GalacticsTab.Text = "Галактики";
            // 
            // EditButtonGalactic
            // 
            this.EditButtonGalactic.AnimationHoverSpeed = 0.07F;
            this.EditButtonGalactic.AnimationSpeed = 0.03F;
            this.EditButtonGalactic.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.EditButtonGalactic.BorderColor = System.Drawing.Color.Black;
            this.EditButtonGalactic.CheckedBaseColor = System.Drawing.Color.Gray;
            this.EditButtonGalactic.CheckedBorderColor = System.Drawing.Color.Black;
            this.EditButtonGalactic.CheckedForeColor = System.Drawing.Color.White;
            this.EditButtonGalactic.CheckedImage = ((System.Drawing.Image)(resources.GetObject("EditButtonGalactic.CheckedImage")));
            this.EditButtonGalactic.CheckedLineColor = System.Drawing.Color.DimGray;
            this.EditButtonGalactic.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EditButtonGalactic.FocusedColor = System.Drawing.Color.Empty;
            this.EditButtonGalactic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EditButtonGalactic.ForeColor = System.Drawing.Color.White;
            this.EditButtonGalactic.Image = ((System.Drawing.Image)(resources.GetObject("EditButtonGalactic.Image")));
            this.EditButtonGalactic.ImageSize = new System.Drawing.Size(20, 20);
            this.EditButtonGalactic.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.EditButtonGalactic.Location = new System.Drawing.Point(414, 320);
            this.EditButtonGalactic.Name = "EditButtonGalactic";
            this.EditButtonGalactic.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.EditButtonGalactic.OnHoverBorderColor = System.Drawing.Color.Black;
            this.EditButtonGalactic.OnHoverForeColor = System.Drawing.Color.White;
            this.EditButtonGalactic.OnHoverImage = null;
            this.EditButtonGalactic.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.EditButtonGalactic.OnPressedColor = System.Drawing.Color.Black;
            this.EditButtonGalactic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EditButtonGalactic.Size = new System.Drawing.Size(180, 42);
            this.EditButtonGalactic.TabIndex = 9;
            this.EditButtonGalactic.Text = "Изменить запись";
            this.EditButtonGalactic.Click += new System.EventHandler(this.EditButtonGalactic_Click);
            // 
            // AddButtonGalactic
            // 
            this.AddButtonGalactic.AnimationHoverSpeed = 0.07F;
            this.AddButtonGalactic.AnimationSpeed = 0.03F;
            this.AddButtonGalactic.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.AddButtonGalactic.BorderColor = System.Drawing.Color.Black;
            this.AddButtonGalactic.CheckedBaseColor = System.Drawing.Color.Gray;
            this.AddButtonGalactic.CheckedBorderColor = System.Drawing.Color.Black;
            this.AddButtonGalactic.CheckedForeColor = System.Drawing.Color.White;
            this.AddButtonGalactic.CheckedImage = ((System.Drawing.Image)(resources.GetObject("AddButtonGalactic.CheckedImage")));
            this.AddButtonGalactic.CheckedLineColor = System.Drawing.Color.DimGray;
            this.AddButtonGalactic.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddButtonGalactic.FocusedColor = System.Drawing.Color.Empty;
            this.AddButtonGalactic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddButtonGalactic.ForeColor = System.Drawing.Color.White;
            this.AddButtonGalactic.Image = ((System.Drawing.Image)(resources.GetObject("AddButtonGalactic.Image")));
            this.AddButtonGalactic.ImageSize = new System.Drawing.Size(20, 20);
            this.AddButtonGalactic.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddButtonGalactic.Location = new System.Drawing.Point(209, 320);
            this.AddButtonGalactic.Name = "AddButtonGalactic";
            this.AddButtonGalactic.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.AddButtonGalactic.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddButtonGalactic.OnHoverForeColor = System.Drawing.Color.White;
            this.AddButtonGalactic.OnHoverImage = null;
            this.AddButtonGalactic.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.AddButtonGalactic.OnPressedColor = System.Drawing.Color.Black;
            this.AddButtonGalactic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddButtonGalactic.Size = new System.Drawing.Size(180, 42);
            this.AddButtonGalactic.TabIndex = 8;
            this.AddButtonGalactic.Text = "Добавить запись";
            this.AddButtonGalactic.Click += new System.EventHandler(this.AddButtonGalactic_Click);
            // 
            // RefreshButtonGalactic
            // 
            this.RefreshButtonGalactic.AnimationHoverSpeed = 0.07F;
            this.RefreshButtonGalactic.AnimationSpeed = 0.03F;
            this.RefreshButtonGalactic.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.RefreshButtonGalactic.BorderColor = System.Drawing.Color.Black;
            this.RefreshButtonGalactic.CheckedBaseColor = System.Drawing.Color.Gray;
            this.RefreshButtonGalactic.CheckedBorderColor = System.Drawing.Color.Black;
            this.RefreshButtonGalactic.CheckedForeColor = System.Drawing.Color.White;
            this.RefreshButtonGalactic.CheckedImage = ((System.Drawing.Image)(resources.GetObject("RefreshButtonGalactic.CheckedImage")));
            this.RefreshButtonGalactic.CheckedLineColor = System.Drawing.Color.DimGray;
            this.RefreshButtonGalactic.DialogResult = System.Windows.Forms.DialogResult.None;
            this.RefreshButtonGalactic.FocusedColor = System.Drawing.Color.Empty;
            this.RefreshButtonGalactic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RefreshButtonGalactic.ForeColor = System.Drawing.Color.White;
            this.RefreshButtonGalactic.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButtonGalactic.Image")));
            this.RefreshButtonGalactic.ImageSize = new System.Drawing.Size(20, 20);
            this.RefreshButtonGalactic.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.RefreshButtonGalactic.Location = new System.Drawing.Point(3, 320);
            this.RefreshButtonGalactic.Name = "RefreshButtonGalactic";
            this.RefreshButtonGalactic.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.RefreshButtonGalactic.OnHoverBorderColor = System.Drawing.Color.Black;
            this.RefreshButtonGalactic.OnHoverForeColor = System.Drawing.Color.White;
            this.RefreshButtonGalactic.OnHoverImage = null;
            this.RefreshButtonGalactic.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.RefreshButtonGalactic.OnPressedColor = System.Drawing.Color.Black;
            this.RefreshButtonGalactic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RefreshButtonGalactic.Size = new System.Drawing.Size(180, 42);
            this.RefreshButtonGalactic.TabIndex = 7;
            this.RefreshButtonGalactic.Text = "Обновить таблицу";
            this.RefreshButtonGalactic.Click += new System.EventHandler(this.RefreshButtonGalactic_Click);
            // 
            // DeleteButtonGalactics
            // 
            this.DeleteButtonGalactics.AnimationHoverSpeed = 0.07F;
            this.DeleteButtonGalactics.AnimationSpeed = 0.03F;
            this.DeleteButtonGalactics.BaseColor = System.Drawing.Color.Red;
            this.DeleteButtonGalactics.BorderColor = System.Drawing.Color.Black;
            this.DeleteButtonGalactics.CheckedBaseColor = System.Drawing.Color.Gray;
            this.DeleteButtonGalactics.CheckedBorderColor = System.Drawing.Color.Black;
            this.DeleteButtonGalactics.CheckedForeColor = System.Drawing.Color.White;
            this.DeleteButtonGalactics.CheckedImage = ((System.Drawing.Image)(resources.GetObject("DeleteButtonGalactics.CheckedImage")));
            this.DeleteButtonGalactics.CheckedLineColor = System.Drawing.Color.DimGray;
            this.DeleteButtonGalactics.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DeleteButtonGalactics.FocusedColor = System.Drawing.Color.Empty;
            this.DeleteButtonGalactics.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteButtonGalactics.ForeColor = System.Drawing.Color.White;
            this.DeleteButtonGalactics.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButtonGalactics.Image")));
            this.DeleteButtonGalactics.ImageSize = new System.Drawing.Size(20, 20);
            this.DeleteButtonGalactics.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.DeleteButtonGalactics.Location = new System.Drawing.Point(617, 320);
            this.DeleteButtonGalactics.Name = "DeleteButtonGalactics";
            this.DeleteButtonGalactics.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteButtonGalactics.OnHoverBorderColor = System.Drawing.Color.Black;
            this.DeleteButtonGalactics.OnHoverForeColor = System.Drawing.Color.White;
            this.DeleteButtonGalactics.OnHoverImage = null;
            this.DeleteButtonGalactics.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteButtonGalactics.OnPressedColor = System.Drawing.Color.Black;
            this.DeleteButtonGalactics.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DeleteButtonGalactics.Size = new System.Drawing.Size(180, 42);
            this.DeleteButtonGalactics.TabIndex = 6;
            this.DeleteButtonGalactics.Text = "Удалить запись";
            this.DeleteButtonGalactics.Click += new System.EventHandler(this.DeleteButtonGalactics_Click);
            // 
            // PlanetsTab
            // 
            this.PlanetsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.PlanetsTab.Controls.Add(this.EditButtonPlanet);
            this.PlanetsTab.Controls.Add(this.AddButtonPlanets);
            this.PlanetsTab.Controls.Add(this.RefreshButtonPlanets);
            this.PlanetsTab.Controls.Add(this.DeleteButtonPlanets);
            this.PlanetsTab.Controls.Add(this.PlanetsTable);
            this.PlanetsTab.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlanetsTab.Location = new System.Drawing.Point(4, 22);
            this.PlanetsTab.Name = "PlanetsTab";
            this.PlanetsTab.Padding = new System.Windows.Forms.Padding(3);
            this.PlanetsTab.Size = new System.Drawing.Size(800, 369);
            this.PlanetsTab.TabIndex = 1;
            this.PlanetsTab.Text = "Планеты";
            // 
            // EditButtonPlanet
            // 
            this.EditButtonPlanet.AnimationHoverSpeed = 0.07F;
            this.EditButtonPlanet.AnimationSpeed = 0.03F;
            this.EditButtonPlanet.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.EditButtonPlanet.BorderColor = System.Drawing.Color.Black;
            this.EditButtonPlanet.CheckedBaseColor = System.Drawing.Color.Gray;
            this.EditButtonPlanet.CheckedBorderColor = System.Drawing.Color.Black;
            this.EditButtonPlanet.CheckedForeColor = System.Drawing.Color.White;
            this.EditButtonPlanet.CheckedImage = ((System.Drawing.Image)(resources.GetObject("EditButtonPlanet.CheckedImage")));
            this.EditButtonPlanet.CheckedLineColor = System.Drawing.Color.DimGray;
            this.EditButtonPlanet.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EditButtonPlanet.FocusedColor = System.Drawing.Color.Empty;
            this.EditButtonPlanet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EditButtonPlanet.ForeColor = System.Drawing.Color.White;
            this.EditButtonPlanet.Image = ((System.Drawing.Image)(resources.GetObject("EditButtonPlanet.Image")));
            this.EditButtonPlanet.ImageSize = new System.Drawing.Size(20, 20);
            this.EditButtonPlanet.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.EditButtonPlanet.Location = new System.Drawing.Point(415, 320);
            this.EditButtonPlanet.Name = "EditButtonPlanet";
            this.EditButtonPlanet.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.EditButtonPlanet.OnHoverBorderColor = System.Drawing.Color.Black;
            this.EditButtonPlanet.OnHoverForeColor = System.Drawing.Color.White;
            this.EditButtonPlanet.OnHoverImage = null;
            this.EditButtonPlanet.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.EditButtonPlanet.OnPressedColor = System.Drawing.Color.Black;
            this.EditButtonPlanet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EditButtonPlanet.Size = new System.Drawing.Size(180, 42);
            this.EditButtonPlanet.TabIndex = 11;
            this.EditButtonPlanet.Text = "Изменить запись";
            this.EditButtonPlanet.Click += new System.EventHandler(this.EditButtonPlanet_Click);
            // 
            // AddButtonPlanets
            // 
            this.AddButtonPlanets.AnimationHoverSpeed = 0.07F;
            this.AddButtonPlanets.AnimationSpeed = 0.03F;
            this.AddButtonPlanets.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.AddButtonPlanets.BorderColor = System.Drawing.Color.Black;
            this.AddButtonPlanets.CheckedBaseColor = System.Drawing.Color.Gray;
            this.AddButtonPlanets.CheckedBorderColor = System.Drawing.Color.Black;
            this.AddButtonPlanets.CheckedForeColor = System.Drawing.Color.White;
            this.AddButtonPlanets.CheckedImage = ((System.Drawing.Image)(resources.GetObject("AddButtonPlanets.CheckedImage")));
            this.AddButtonPlanets.CheckedLineColor = System.Drawing.Color.DimGray;
            this.AddButtonPlanets.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddButtonPlanets.FocusedColor = System.Drawing.Color.Empty;
            this.AddButtonPlanets.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddButtonPlanets.ForeColor = System.Drawing.Color.White;
            this.AddButtonPlanets.Image = ((System.Drawing.Image)(resources.GetObject("AddButtonPlanets.Image")));
            this.AddButtonPlanets.ImageSize = new System.Drawing.Size(20, 20);
            this.AddButtonPlanets.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddButtonPlanets.Location = new System.Drawing.Point(210, 320);
            this.AddButtonPlanets.Name = "AddButtonPlanets";
            this.AddButtonPlanets.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.AddButtonPlanets.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddButtonPlanets.OnHoverForeColor = System.Drawing.Color.White;
            this.AddButtonPlanets.OnHoverImage = null;
            this.AddButtonPlanets.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.AddButtonPlanets.OnPressedColor = System.Drawing.Color.Black;
            this.AddButtonPlanets.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddButtonPlanets.Size = new System.Drawing.Size(180, 42);
            this.AddButtonPlanets.TabIndex = 10;
            this.AddButtonPlanets.Text = "Добавить запись";
            this.AddButtonPlanets.Click += new System.EventHandler(this.AddButtonPlanets_Click);
            // 
            // RefreshButtonPlanets
            // 
            this.RefreshButtonPlanets.AnimationHoverSpeed = 0.07F;
            this.RefreshButtonPlanets.AnimationSpeed = 0.03F;
            this.RefreshButtonPlanets.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.RefreshButtonPlanets.BorderColor = System.Drawing.Color.Black;
            this.RefreshButtonPlanets.CheckedBaseColor = System.Drawing.Color.Gray;
            this.RefreshButtonPlanets.CheckedBorderColor = System.Drawing.Color.Black;
            this.RefreshButtonPlanets.CheckedForeColor = System.Drawing.Color.White;
            this.RefreshButtonPlanets.CheckedImage = ((System.Drawing.Image)(resources.GetObject("RefreshButtonPlanets.CheckedImage")));
            this.RefreshButtonPlanets.CheckedLineColor = System.Drawing.Color.DimGray;
            this.RefreshButtonPlanets.DialogResult = System.Windows.Forms.DialogResult.None;
            this.RefreshButtonPlanets.FocusedColor = System.Drawing.Color.Empty;
            this.RefreshButtonPlanets.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RefreshButtonPlanets.ForeColor = System.Drawing.Color.White;
            this.RefreshButtonPlanets.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButtonPlanets.Image")));
            this.RefreshButtonPlanets.ImageSize = new System.Drawing.Size(20, 20);
            this.RefreshButtonPlanets.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.RefreshButtonPlanets.Location = new System.Drawing.Point(3, 320);
            this.RefreshButtonPlanets.Name = "RefreshButtonPlanets";
            this.RefreshButtonPlanets.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.RefreshButtonPlanets.OnHoverBorderColor = System.Drawing.Color.Black;
            this.RefreshButtonPlanets.OnHoverForeColor = System.Drawing.Color.White;
            this.RefreshButtonPlanets.OnHoverImage = null;
            this.RefreshButtonPlanets.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.RefreshButtonPlanets.OnPressedColor = System.Drawing.Color.Black;
            this.RefreshButtonPlanets.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RefreshButtonPlanets.Size = new System.Drawing.Size(180, 42);
            this.RefreshButtonPlanets.TabIndex = 8;
            this.RefreshButtonPlanets.Text = "Обновить таблицу";
            this.RefreshButtonPlanets.Click += new System.EventHandler(this.RefreshButtonPlanets_Click);
            // 
            // DeleteButtonPlanets
            // 
            this.DeleteButtonPlanets.AnimationHoverSpeed = 0.07F;
            this.DeleteButtonPlanets.AnimationSpeed = 0.03F;
            this.DeleteButtonPlanets.BaseColor = System.Drawing.Color.Red;
            this.DeleteButtonPlanets.BorderColor = System.Drawing.Color.Black;
            this.DeleteButtonPlanets.CheckedBaseColor = System.Drawing.Color.Gray;
            this.DeleteButtonPlanets.CheckedBorderColor = System.Drawing.Color.Black;
            this.DeleteButtonPlanets.CheckedForeColor = System.Drawing.Color.White;
            this.DeleteButtonPlanets.CheckedImage = ((System.Drawing.Image)(resources.GetObject("DeleteButtonPlanets.CheckedImage")));
            this.DeleteButtonPlanets.CheckedLineColor = System.Drawing.Color.DimGray;
            this.DeleteButtonPlanets.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DeleteButtonPlanets.FocusedColor = System.Drawing.Color.Empty;
            this.DeleteButtonPlanets.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteButtonPlanets.ForeColor = System.Drawing.Color.White;
            this.DeleteButtonPlanets.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButtonPlanets.Image")));
            this.DeleteButtonPlanets.ImageSize = new System.Drawing.Size(20, 20);
            this.DeleteButtonPlanets.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.DeleteButtonPlanets.Location = new System.Drawing.Point(617, 320);
            this.DeleteButtonPlanets.Name = "DeleteButtonPlanets";
            this.DeleteButtonPlanets.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteButtonPlanets.OnHoverBorderColor = System.Drawing.Color.Black;
            this.DeleteButtonPlanets.OnHoverForeColor = System.Drawing.Color.White;
            this.DeleteButtonPlanets.OnHoverImage = null;
            this.DeleteButtonPlanets.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteButtonPlanets.OnPressedColor = System.Drawing.Color.Black;
            this.DeleteButtonPlanets.Size = new System.Drawing.Size(180, 42);
            this.DeleteButtonPlanets.TabIndex = 5;
            this.DeleteButtonPlanets.Text = "Удалить запись";
            this.DeleteButtonPlanets.Click += new System.EventHandler(this.PlanetsDeleteButton_Click);
            // 
            // PlanetsTable
            // 
            this.PlanetsTable.AllowUserToAddRows = false;
            this.PlanetsTable.AllowUserToDeleteRows = false;
            this.PlanetsTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.PlanetsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlanetsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlanetNumber,
            this.PlanetName,
            this.PlanetMass,
            this.PlanetSize});
            this.PlanetsTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PlanetsTable.Location = new System.Drawing.Point(1, 0);
            this.PlanetsTable.Name = "PlanetsTable";
            this.PlanetsTable.Size = new System.Drawing.Size(799, 314);
            this.PlanetsTable.TabIndex = 2;
            // 
            // PlanetNumber
            // 
            this.PlanetNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PlanetNumber.HeaderText = "Номер планеты";
            this.PlanetNumber.Name = "PlanetNumber";
            // 
            // PlanetName
            // 
            this.PlanetName.HeaderText = "Название планеты";
            this.PlanetName.Name = "PlanetName";
            this.PlanetName.Width = 332;
            // 
            // PlanetMass
            // 
            this.PlanetMass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PlanetMass.HeaderText = "Масса планеты";
            this.PlanetMass.Name = "PlanetMass";
            // 
            // PlanetSize
            // 
            this.PlanetSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PlanetSize.HeaderText = "Размер планеты";
            this.PlanetSize.Name = "PlanetSize";
            // 
            // StarsTab
            // 
            this.StarsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.StarsTab.Controls.Add(this.EditButtonStars);
            this.StarsTab.Controls.Add(this.AddButtonStars);
            this.StarsTab.Controls.Add(this.RefreshButtonStars);
            this.StarsTab.Controls.Add(this.DeleteButtonStars);
            this.StarsTab.Controls.Add(this.StarsTable);
            this.StarsTab.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StarsTab.Location = new System.Drawing.Point(4, 22);
            this.StarsTab.Name = "StarsTab";
            this.StarsTab.Size = new System.Drawing.Size(800, 369);
            this.StarsTab.TabIndex = 2;
            this.StarsTab.Text = "Звезды";
            // 
            // EditButtonStars
            // 
            this.EditButtonStars.AnimationHoverSpeed = 0.07F;
            this.EditButtonStars.AnimationSpeed = 0.03F;
            this.EditButtonStars.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.EditButtonStars.BorderColor = System.Drawing.Color.Black;
            this.EditButtonStars.CheckedBaseColor = System.Drawing.Color.Gray;
            this.EditButtonStars.CheckedBorderColor = System.Drawing.Color.Black;
            this.EditButtonStars.CheckedForeColor = System.Drawing.Color.White;
            this.EditButtonStars.CheckedImage = ((System.Drawing.Image)(resources.GetObject("EditButtonStars.CheckedImage")));
            this.EditButtonStars.CheckedLineColor = System.Drawing.Color.DimGray;
            this.EditButtonStars.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EditButtonStars.FocusedColor = System.Drawing.Color.Empty;
            this.EditButtonStars.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EditButtonStars.ForeColor = System.Drawing.Color.White;
            this.EditButtonStars.Image = ((System.Drawing.Image)(resources.GetObject("EditButtonStars.Image")));
            this.EditButtonStars.ImageSize = new System.Drawing.Size(20, 20);
            this.EditButtonStars.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.EditButtonStars.Location = new System.Drawing.Point(415, 320);
            this.EditButtonStars.Name = "EditButtonStars";
            this.EditButtonStars.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.EditButtonStars.OnHoverBorderColor = System.Drawing.Color.Black;
            this.EditButtonStars.OnHoverForeColor = System.Drawing.Color.White;
            this.EditButtonStars.OnHoverImage = null;
            this.EditButtonStars.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.EditButtonStars.OnPressedColor = System.Drawing.Color.Black;
            this.EditButtonStars.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EditButtonStars.Size = new System.Drawing.Size(180, 42);
            this.EditButtonStars.TabIndex = 13;
            this.EditButtonStars.Text = "Изменить запись";
            this.EditButtonStars.Click += new System.EventHandler(this.EditButtonStars_Click);
            // 
            // AddButtonStars
            // 
            this.AddButtonStars.AnimationHoverSpeed = 0.07F;
            this.AddButtonStars.AnimationSpeed = 0.03F;
            this.AddButtonStars.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.AddButtonStars.BorderColor = System.Drawing.Color.Black;
            this.AddButtonStars.CheckedBaseColor = System.Drawing.Color.Gray;
            this.AddButtonStars.CheckedBorderColor = System.Drawing.Color.Black;
            this.AddButtonStars.CheckedForeColor = System.Drawing.Color.White;
            this.AddButtonStars.CheckedImage = ((System.Drawing.Image)(resources.GetObject("AddButtonStars.CheckedImage")));
            this.AddButtonStars.CheckedLineColor = System.Drawing.Color.DimGray;
            this.AddButtonStars.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddButtonStars.FocusedColor = System.Drawing.Color.Empty;
            this.AddButtonStars.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddButtonStars.ForeColor = System.Drawing.Color.White;
            this.AddButtonStars.Image = ((System.Drawing.Image)(resources.GetObject("AddButtonStars.Image")));
            this.AddButtonStars.ImageSize = new System.Drawing.Size(20, 20);
            this.AddButtonStars.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddButtonStars.Location = new System.Drawing.Point(210, 320);
            this.AddButtonStars.Name = "AddButtonStars";
            this.AddButtonStars.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.AddButtonStars.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddButtonStars.OnHoverForeColor = System.Drawing.Color.White;
            this.AddButtonStars.OnHoverImage = null;
            this.AddButtonStars.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.AddButtonStars.OnPressedColor = System.Drawing.Color.Black;
            this.AddButtonStars.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddButtonStars.Size = new System.Drawing.Size(180, 42);
            this.AddButtonStars.TabIndex = 12;
            this.AddButtonStars.Text = "Добавить запись";
            this.AddButtonStars.Click += new System.EventHandler(this.AddButtonStars_Click);
            // 
            // RefreshButtonStars
            // 
            this.RefreshButtonStars.AnimationHoverSpeed = 0.07F;
            this.RefreshButtonStars.AnimationSpeed = 0.03F;
            this.RefreshButtonStars.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.RefreshButtonStars.BorderColor = System.Drawing.Color.Black;
            this.RefreshButtonStars.CheckedBaseColor = System.Drawing.Color.Gray;
            this.RefreshButtonStars.CheckedBorderColor = System.Drawing.Color.Black;
            this.RefreshButtonStars.CheckedForeColor = System.Drawing.Color.White;
            this.RefreshButtonStars.CheckedImage = ((System.Drawing.Image)(resources.GetObject("RefreshButtonStars.CheckedImage")));
            this.RefreshButtonStars.CheckedLineColor = System.Drawing.Color.DimGray;
            this.RefreshButtonStars.DialogResult = System.Windows.Forms.DialogResult.None;
            this.RefreshButtonStars.FocusedColor = System.Drawing.Color.Empty;
            this.RefreshButtonStars.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RefreshButtonStars.ForeColor = System.Drawing.Color.White;
            this.RefreshButtonStars.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButtonStars.Image")));
            this.RefreshButtonStars.ImageSize = new System.Drawing.Size(20, 20);
            this.RefreshButtonStars.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.RefreshButtonStars.Location = new System.Drawing.Point(3, 320);
            this.RefreshButtonStars.Name = "RefreshButtonStars";
            this.RefreshButtonStars.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.RefreshButtonStars.OnHoverBorderColor = System.Drawing.Color.Black;
            this.RefreshButtonStars.OnHoverForeColor = System.Drawing.Color.White;
            this.RefreshButtonStars.OnHoverImage = null;
            this.RefreshButtonStars.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.RefreshButtonStars.OnPressedColor = System.Drawing.Color.Black;
            this.RefreshButtonStars.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RefreshButtonStars.Size = new System.Drawing.Size(180, 42);
            this.RefreshButtonStars.TabIndex = 9;
            this.RefreshButtonStars.Text = "Обновить таблицу";
            this.RefreshButtonStars.Click += new System.EventHandler(this.RefreshButtonStars_Click);
            // 
            // DeleteButtonStars
            // 
            this.DeleteButtonStars.AnimationHoverSpeed = 0.07F;
            this.DeleteButtonStars.AnimationSpeed = 0.03F;
            this.DeleteButtonStars.BaseColor = System.Drawing.Color.Red;
            this.DeleteButtonStars.BorderColor = System.Drawing.Color.Black;
            this.DeleteButtonStars.CheckedBaseColor = System.Drawing.Color.Gray;
            this.DeleteButtonStars.CheckedBorderColor = System.Drawing.Color.Black;
            this.DeleteButtonStars.CheckedForeColor = System.Drawing.Color.White;
            this.DeleteButtonStars.CheckedImage = ((System.Drawing.Image)(resources.GetObject("DeleteButtonStars.CheckedImage")));
            this.DeleteButtonStars.CheckedLineColor = System.Drawing.Color.DimGray;
            this.DeleteButtonStars.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DeleteButtonStars.FocusedColor = System.Drawing.Color.Empty;
            this.DeleteButtonStars.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteButtonStars.ForeColor = System.Drawing.Color.White;
            this.DeleteButtonStars.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButtonStars.Image")));
            this.DeleteButtonStars.ImageSize = new System.Drawing.Size(20, 20);
            this.DeleteButtonStars.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.DeleteButtonStars.Location = new System.Drawing.Point(617, 320);
            this.DeleteButtonStars.Name = "DeleteButtonStars";
            this.DeleteButtonStars.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteButtonStars.OnHoverBorderColor = System.Drawing.Color.Black;
            this.DeleteButtonStars.OnHoverForeColor = System.Drawing.Color.White;
            this.DeleteButtonStars.OnHoverImage = null;
            this.DeleteButtonStars.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteButtonStars.OnPressedColor = System.Drawing.Color.Black;
            this.DeleteButtonStars.Size = new System.Drawing.Size(180, 42);
            this.DeleteButtonStars.TabIndex = 4;
            this.DeleteButtonStars.Text = "Удалить запись";
            this.DeleteButtonStars.Click += new System.EventHandler(this.DeleteButtonStars_Click);
            // 
            // StarsTable
            // 
            this.StarsTable.AllowUserToAddRows = false;
            this.StarsTable.AllowUserToDeleteRows = false;
            this.StarsTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.StarsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StarsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StarNumber,
            this.StarName,
            this.StarSize,
            this.StarFar,
            this.StarMass});
            this.StarsTable.Location = new System.Drawing.Point(1, 0);
            this.StarsTable.Name = "StarsTable";
            this.StarsTable.Size = new System.Drawing.Size(799, 314);
            this.StarsTable.TabIndex = 3;
            // 
            // StarNumber
            // 
            this.StarNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StarNumber.HeaderText = "Номер звезды";
            this.StarNumber.Name = "StarNumber";
            // 
            // StarName
            // 
            this.StarName.HeaderText = "Название звезды";
            this.StarName.Name = "StarName";
            this.StarName.Width = 332;
            // 
            // StarSize
            // 
            this.StarSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StarSize.HeaderText = "Размер звезды";
            this.StarSize.Name = "StarSize";
            // 
            // StarFar
            // 
            this.StarFar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StarFar.HeaderText = "Удаленность от земли (св лет)";
            this.StarFar.Name = "StarFar";
            // 
            // StarMass
            // 
            this.StarMass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StarMass.HeaderText = "Масса звезды";
            this.StarMass.Name = "StarMass";
            // 
            // CollapseButton
            // 
            this.CollapseButton.AnimationHoverSpeed = 0.07F;
            this.CollapseButton.AnimationSpeed = 0.03F;
            this.CollapseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.CollapseButton.BaseColor = System.Drawing.Color.Gold;
            this.CollapseButton.BorderColor = System.Drawing.Color.Black;
            this.CollapseButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.CollapseButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.CollapseButton.CheckedForeColor = System.Drawing.Color.White;
            this.CollapseButton.CheckedImage = null;
            this.CollapseButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.CollapseButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CollapseButton.FocusedColor = System.Drawing.Color.Empty;
            this.CollapseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CollapseButton.ForeColor = System.Drawing.Color.Transparent;
            this.CollapseButton.Image = null;
            this.CollapseButton.ImageSize = new System.Drawing.Size(20, 20);
            this.CollapseButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CollapseButton.Location = new System.Drawing.Point(778, 6);
            this.CollapseButton.Name = "CollapseButton";
            this.CollapseButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CollapseButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CollapseButton.OnHoverForeColor = System.Drawing.Color.White;
            this.CollapseButton.OnHoverImage = null;
            this.CollapseButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CollapseButton.OnPressedColor = System.Drawing.Color.Black;
            this.CollapseButton.Size = new System.Drawing.Size(18, 17);
            this.CollapseButton.TabIndex = 23;
            this.CollapseButton.Click += new System.EventHandler(this.CollapseButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AnimationHoverSpeed = 0.07F;
            this.CloseButton.AnimationSpeed = 0.03F;
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BaseColor = System.Drawing.Color.Red;
            this.CloseButton.BorderColor = System.Drawing.Color.Black;
            this.CloseButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.CloseButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.CloseButton.CheckedForeColor = System.Drawing.Color.White;
            this.CloseButton.CheckedImage = null;
            this.CloseButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CloseButton.FocusedColor = System.Drawing.Color.Empty;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseButton.ForeColor = System.Drawing.Color.Transparent;
            this.CloseButton.Image = null;
            this.CloseButton.ImageSize = new System.Drawing.Size(20, 20);
            this.CloseButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CloseButton.Location = new System.Drawing.Point(802, 6);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CloseButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CloseButton.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.CloseButton.OnHoverImage = null;
            this.CloseButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CloseButton.OnPressedColor = System.Drawing.Color.Black;
            this.CloseButton.Size = new System.Drawing.Size(18, 17);
            this.CloseButton.TabIndex = 22;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(825, 29);
            this.MenuStrip.TabIndex = 21;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToFileButton,
            this.AboutButton});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(66, 25);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // SaveToFileButton
            // 
            this.SaveToFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.SaveToFileButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SaveToFileButton.Name = "SaveToFileButton";
            this.SaveToFileButton.Size = new System.Drawing.Size(256, 26);
            this.SaveToFileButton.Text = "Сохранить как...";
            this.SaveToFileButton.Click += new System.EventHandler(this.SaveToFileButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.AboutButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(256, 26);
            this.AboutButton.Text = "О программе";
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.MenuStrip;
            // 
            // NumberOfGalacticTextbox
            // 
            this.NumberOfGalacticTextbox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfGalacticTextbox.Location = new System.Drawing.Point(55, 485);
            this.NumberOfGalacticTextbox.Multiline = true;
            this.NumberOfGalacticTextbox.Name = "NumberOfGalacticTextbox";
            this.NumberOfGalacticTextbox.ReadOnly = true;
            this.NumberOfGalacticTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NumberOfGalacticTextbox.Size = new System.Drawing.Size(129, 27);
            this.NumberOfGalacticTextbox.TabIndex = 24;
            this.NumberOfGalacticTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumberOfGalacticTextbox.Visible = false;
            // 
            // GalacticNameTextbox
            // 
            this.GalacticNameTextbox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GalacticNameTextbox.Location = new System.Drawing.Point(242, 485);
            this.GalacticNameTextbox.Multiline = true;
            this.GalacticNameTextbox.Name = "GalacticNameTextbox";
            this.GalacticNameTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GalacticNameTextbox.Size = new System.Drawing.Size(129, 27);
            this.GalacticNameTextbox.TabIndex = 25;
            this.GalacticNameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GalacticNameTextbox.Visible = false;
            // 
            // NumOfObjTextbox
            // 
            this.NumOfObjTextbox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumOfObjTextbox.Location = new System.Drawing.Point(421, 485);
            this.NumOfObjTextbox.Multiline = true;
            this.NumOfObjTextbox.Name = "NumOfObjTextbox";
            this.NumOfObjTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NumOfObjTextbox.Size = new System.Drawing.Size(129, 27);
            this.NumOfObjTextbox.TabIndex = 26;
            this.NumOfObjTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumOfObjTextbox.Visible = false;
            this.NumOfObjTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumOfObjectsGalacticKeyPressed);
            // 
            // SaveButtonGalactic
            // 
            this.SaveButtonGalactic.AnimationHoverSpeed = 0.07F;
            this.SaveButtonGalactic.AnimationSpeed = 0.03F;
            this.SaveButtonGalactic.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.SaveButtonGalactic.BorderColor = System.Drawing.Color.Black;
            this.SaveButtonGalactic.CheckedBaseColor = System.Drawing.Color.Gray;
            this.SaveButtonGalactic.CheckedBorderColor = System.Drawing.Color.Black;
            this.SaveButtonGalactic.CheckedForeColor = System.Drawing.Color.White;
            this.SaveButtonGalactic.CheckedImage = ((System.Drawing.Image)(resources.GetObject("SaveButtonGalactic.CheckedImage")));
            this.SaveButtonGalactic.CheckedLineColor = System.Drawing.Color.DimGray;
            this.SaveButtonGalactic.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SaveButtonGalactic.FocusedColor = System.Drawing.Color.Empty;
            this.SaveButtonGalactic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SaveButtonGalactic.ForeColor = System.Drawing.Color.White;
            this.SaveButtonGalactic.Image = null;
            this.SaveButtonGalactic.ImageSize = new System.Drawing.Size(20, 20);
            this.SaveButtonGalactic.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SaveButtonGalactic.Location = new System.Drawing.Point(583, 470);
            this.SaveButtonGalactic.Name = "SaveButtonGalactic";
            this.SaveButtonGalactic.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.SaveButtonGalactic.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SaveButtonGalactic.OnHoverForeColor = System.Drawing.Color.White;
            this.SaveButtonGalactic.OnHoverImage = null;
            this.SaveButtonGalactic.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.SaveButtonGalactic.OnPressedColor = System.Drawing.Color.Black;
            this.SaveButtonGalactic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SaveButtonGalactic.Size = new System.Drawing.Size(180, 42);
            this.SaveButtonGalactic.TabIndex = 27;
            this.SaveButtonGalactic.Text = "Добавить запись";
            this.SaveButtonGalactic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SaveButtonGalactic.Visible = false;
            this.SaveButtonGalactic.Click += new System.EventHandler(this.SaveButtonGalactic_Click);
            // 
            // NumberOfGalacticLabel
            // 
            this.NumberOfGalacticLabel.AutoSize = true;
            this.NumberOfGalacticLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfGalacticLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NumberOfGalacticLabel.Location = new System.Drawing.Point(56, 466);
            this.NumberOfGalacticLabel.Name = "NumberOfGalacticLabel";
            this.NumberOfGalacticLabel.Size = new System.Drawing.Size(128, 16);
            this.NumberOfGalacticLabel.TabIndex = 28;
            this.NumberOfGalacticLabel.Text = "Номер галактики";
            this.NumberOfGalacticLabel.Visible = false;
            // 
            // NameOfGalacticLabel
            // 
            this.NameOfGalacticLabel.AutoSize = true;
            this.NameOfGalacticLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameOfGalacticLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameOfGalacticLabel.Location = new System.Drawing.Point(231, 466);
            this.NameOfGalacticLabel.Name = "NameOfGalacticLabel";
            this.NameOfGalacticLabel.Size = new System.Drawing.Size(152, 16);
            this.NameOfGalacticLabel.TabIndex = 29;
            this.NameOfGalacticLabel.Text = "Название галактики";
            this.NameOfGalacticLabel.Visible = false;
            // 
            // NumOfObjGalacticLabel
            // 
            this.NumOfObjGalacticLabel.AutoSize = true;
            this.NumOfObjGalacticLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumOfObjGalacticLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NumOfObjGalacticLabel.Location = new System.Drawing.Point(408, 466);
            this.NumOfObjGalacticLabel.Name = "NumOfObjGalacticLabel";
            this.NumOfObjGalacticLabel.Size = new System.Drawing.Size(160, 16);
            this.NumOfObjGalacticLabel.TabIndex = 30;
            this.NumOfObjGalacticLabel.Text = "Количество объектов";
            this.NumOfObjGalacticLabel.Visible = false;
            // 
            // EditSaveButtonGalactic
            // 
            this.EditSaveButtonGalactic.AnimationHoverSpeed = 0.07F;
            this.EditSaveButtonGalactic.AnimationSpeed = 0.03F;
            this.EditSaveButtonGalactic.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.EditSaveButtonGalactic.BorderColor = System.Drawing.Color.Black;
            this.EditSaveButtonGalactic.CheckedBaseColor = System.Drawing.Color.Gray;
            this.EditSaveButtonGalactic.CheckedBorderColor = System.Drawing.Color.Black;
            this.EditSaveButtonGalactic.CheckedForeColor = System.Drawing.Color.White;
            this.EditSaveButtonGalactic.CheckedImage = ((System.Drawing.Image)(resources.GetObject("EditSaveButtonGalactic.CheckedImage")));
            this.EditSaveButtonGalactic.CheckedLineColor = System.Drawing.Color.DimGray;
            this.EditSaveButtonGalactic.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EditSaveButtonGalactic.FocusedColor = System.Drawing.Color.Empty;
            this.EditSaveButtonGalactic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EditSaveButtonGalactic.ForeColor = System.Drawing.Color.White;
            this.EditSaveButtonGalactic.Image = null;
            this.EditSaveButtonGalactic.ImageSize = new System.Drawing.Size(20, 20);
            this.EditSaveButtonGalactic.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.EditSaveButtonGalactic.Location = new System.Drawing.Point(583, 473);
            this.EditSaveButtonGalactic.Name = "EditSaveButtonGalactic";
            this.EditSaveButtonGalactic.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.EditSaveButtonGalactic.OnHoverBorderColor = System.Drawing.Color.Black;
            this.EditSaveButtonGalactic.OnHoverForeColor = System.Drawing.Color.White;
            this.EditSaveButtonGalactic.OnHoverImage = null;
            this.EditSaveButtonGalactic.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.EditSaveButtonGalactic.OnPressedColor = System.Drawing.Color.Black;
            this.EditSaveButtonGalactic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EditSaveButtonGalactic.Size = new System.Drawing.Size(180, 42);
            this.EditSaveButtonGalactic.TabIndex = 31;
            this.EditSaveButtonGalactic.Text = "Изменить запись";
            this.EditSaveButtonGalactic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EditSaveButtonGalactic.Visible = false;
            this.EditSaveButtonGalactic.Click += new System.EventHandler(this.EditSaveButtonGalactic_Click);
            // 
            // NumberOfPlanetLabel
            // 
            this.NumberOfPlanetLabel.AutoSize = true;
            this.NumberOfPlanetLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfPlanetLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NumberOfPlanetLabel.Location = new System.Drawing.Point(33, 466);
            this.NumberOfPlanetLabel.Name = "NumberOfPlanetLabel";
            this.NumberOfPlanetLabel.Size = new System.Drawing.Size(112, 16);
            this.NumberOfPlanetLabel.TabIndex = 33;
            this.NumberOfPlanetLabel.Text = "Номер планеты";
            this.NumberOfPlanetLabel.Visible = false;
            // 
            // NumberOfPlanetTextbox
            // 
            this.NumberOfPlanetTextbox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfPlanetTextbox.Location = new System.Drawing.Point(31, 485);
            this.NumberOfPlanetTextbox.Multiline = true;
            this.NumberOfPlanetTextbox.Name = "NumberOfPlanetTextbox";
            this.NumberOfPlanetTextbox.ReadOnly = true;
            this.NumberOfPlanetTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NumberOfPlanetTextbox.Size = new System.Drawing.Size(129, 26);
            this.NumberOfPlanetTextbox.TabIndex = 32;
            this.NumberOfPlanetTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumberOfPlanetTextbox.Visible = false;
            // 
            // NameOfPlanetLabel
            // 
            this.NameOfPlanetLabel.AutoSize = true;
            this.NameOfPlanetLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameOfPlanetLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameOfPlanetLabel.Location = new System.Drawing.Point(163, 466);
            this.NameOfPlanetLabel.Name = "NameOfPlanetLabel";
            this.NameOfPlanetLabel.Size = new System.Drawing.Size(136, 16);
            this.NameOfPlanetLabel.TabIndex = 35;
            this.NameOfPlanetLabel.Text = "Название планеты";
            this.NameOfPlanetLabel.Visible = false;
            // 
            // NameOfPlanetTextbox
            // 
            this.NameOfPlanetTextbox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameOfPlanetTextbox.Location = new System.Drawing.Point(166, 485);
            this.NameOfPlanetTextbox.Multiline = true;
            this.NameOfPlanetTextbox.Name = "NameOfPlanetTextbox";
            this.NameOfPlanetTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NameOfPlanetTextbox.Size = new System.Drawing.Size(129, 26);
            this.NameOfPlanetTextbox.TabIndex = 34;
            this.NameOfPlanetTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameOfPlanetTextbox.Visible = false;
            // 
            // MassOfPlanetLabel
            // 
            this.MassOfPlanetLabel.AutoSize = true;
            this.MassOfPlanetLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MassOfPlanetLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MassOfPlanetLabel.Location = new System.Drawing.Point(307, 466);
            this.MassOfPlanetLabel.Name = "MassOfPlanetLabel";
            this.MassOfPlanetLabel.Size = new System.Drawing.Size(112, 16);
            this.MassOfPlanetLabel.TabIndex = 37;
            this.MassOfPlanetLabel.Text = "Масса планеты";
            this.MassOfPlanetLabel.Visible = false;
            // 
            // MassOfPlanetTextbox
            // 
            this.MassOfPlanetTextbox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MassOfPlanetTextbox.Location = new System.Drawing.Point(301, 485);
            this.MassOfPlanetTextbox.Multiline = true;
            this.MassOfPlanetTextbox.Name = "MassOfPlanetTextbox";
            this.MassOfPlanetTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MassOfPlanetTextbox.Size = new System.Drawing.Size(129, 26);
            this.MassOfPlanetTextbox.TabIndex = 36;
            this.MassOfPlanetTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MassOfPlanetTextbox.Visible = false;
            this.MassOfPlanetTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MassOfPlanetKeyPressed);
            // 
            // SizeOfPlanetLabel
            // 
            this.SizeOfPlanetLabel.AutoSize = true;
            this.SizeOfPlanetLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SizeOfPlanetLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SizeOfPlanetLabel.Location = new System.Drawing.Point(436, 466);
            this.SizeOfPlanetLabel.Name = "SizeOfPlanetLabel";
            this.SizeOfPlanetLabel.Size = new System.Drawing.Size(120, 16);
            this.SizeOfPlanetLabel.TabIndex = 39;
            this.SizeOfPlanetLabel.Text = "Размер планеты";
            this.SizeOfPlanetLabel.Visible = false;
            // 
            // SizeOfPlanetTextbox
            // 
            this.SizeOfPlanetTextbox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SizeOfPlanetTextbox.Location = new System.Drawing.Point(436, 485);
            this.SizeOfPlanetTextbox.Multiline = true;
            this.SizeOfPlanetTextbox.Name = "SizeOfPlanetTextbox";
            this.SizeOfPlanetTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SizeOfPlanetTextbox.Size = new System.Drawing.Size(129, 26);
            this.SizeOfPlanetTextbox.TabIndex = 38;
            this.SizeOfPlanetTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SizeOfPlanetTextbox.Visible = false;
            this.SizeOfPlanetTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SizeOfPlanetKeyPressed);
            // 
            // EditSaveButtonPlanet
            // 
            this.EditSaveButtonPlanet.AnimationHoverSpeed = 0.07F;
            this.EditSaveButtonPlanet.AnimationSpeed = 0.03F;
            this.EditSaveButtonPlanet.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.EditSaveButtonPlanet.BorderColor = System.Drawing.Color.Black;
            this.EditSaveButtonPlanet.CheckedBaseColor = System.Drawing.Color.Gray;
            this.EditSaveButtonPlanet.CheckedBorderColor = System.Drawing.Color.Black;
            this.EditSaveButtonPlanet.CheckedForeColor = System.Drawing.Color.White;
            this.EditSaveButtonPlanet.CheckedImage = ((System.Drawing.Image)(resources.GetObject("EditSaveButtonPlanet.CheckedImage")));
            this.EditSaveButtonPlanet.CheckedLineColor = System.Drawing.Color.DimGray;
            this.EditSaveButtonPlanet.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EditSaveButtonPlanet.FocusedColor = System.Drawing.Color.Empty;
            this.EditSaveButtonPlanet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EditSaveButtonPlanet.ForeColor = System.Drawing.Color.White;
            this.EditSaveButtonPlanet.Image = null;
            this.EditSaveButtonPlanet.ImageSize = new System.Drawing.Size(20, 20);
            this.EditSaveButtonPlanet.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.EditSaveButtonPlanet.Location = new System.Drawing.Point(583, 473);
            this.EditSaveButtonPlanet.Name = "EditSaveButtonPlanet";
            this.EditSaveButtonPlanet.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.EditSaveButtonPlanet.OnHoverBorderColor = System.Drawing.Color.Black;
            this.EditSaveButtonPlanet.OnHoverForeColor = System.Drawing.Color.White;
            this.EditSaveButtonPlanet.OnHoverImage = null;
            this.EditSaveButtonPlanet.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.EditSaveButtonPlanet.OnPressedColor = System.Drawing.Color.Black;
            this.EditSaveButtonPlanet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EditSaveButtonPlanet.Size = new System.Drawing.Size(180, 42);
            this.EditSaveButtonPlanet.TabIndex = 40;
            this.EditSaveButtonPlanet.Text = "Изменить запись";
            this.EditSaveButtonPlanet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EditSaveButtonPlanet.Visible = false;
            this.EditSaveButtonPlanet.Click += new System.EventHandler(this.EditSaveButtonPlanet_Click);
            // 
            // SaveButtonPlanet
            // 
            this.SaveButtonPlanet.AnimationHoverSpeed = 0.07F;
            this.SaveButtonPlanet.AnimationSpeed = 0.03F;
            this.SaveButtonPlanet.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.SaveButtonPlanet.BorderColor = System.Drawing.Color.Black;
            this.SaveButtonPlanet.CheckedBaseColor = System.Drawing.Color.Gray;
            this.SaveButtonPlanet.CheckedBorderColor = System.Drawing.Color.Black;
            this.SaveButtonPlanet.CheckedForeColor = System.Drawing.Color.White;
            this.SaveButtonPlanet.CheckedImage = ((System.Drawing.Image)(resources.GetObject("SaveButtonPlanet.CheckedImage")));
            this.SaveButtonPlanet.CheckedLineColor = System.Drawing.Color.DimGray;
            this.SaveButtonPlanet.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SaveButtonPlanet.FocusedColor = System.Drawing.Color.Empty;
            this.SaveButtonPlanet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SaveButtonPlanet.ForeColor = System.Drawing.Color.White;
            this.SaveButtonPlanet.Image = null;
            this.SaveButtonPlanet.ImageSize = new System.Drawing.Size(20, 20);
            this.SaveButtonPlanet.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SaveButtonPlanet.Location = new System.Drawing.Point(583, 470);
            this.SaveButtonPlanet.Name = "SaveButtonPlanet";
            this.SaveButtonPlanet.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.SaveButtonPlanet.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SaveButtonPlanet.OnHoverForeColor = System.Drawing.Color.White;
            this.SaveButtonPlanet.OnHoverImage = null;
            this.SaveButtonPlanet.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.SaveButtonPlanet.OnPressedColor = System.Drawing.Color.Black;
            this.SaveButtonPlanet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SaveButtonPlanet.Size = new System.Drawing.Size(180, 42);
            this.SaveButtonPlanet.TabIndex = 41;
            this.SaveButtonPlanet.Text = "Добавить запись";
            this.SaveButtonPlanet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SaveButtonPlanet.Visible = false;
            this.SaveButtonPlanet.Click += new System.EventHandler(this.SaveButtonPlanet_Click);
            // 
            // FarOfStarLabel
            // 
            this.FarOfStarLabel.AutoSize = true;
            this.FarOfStarLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FarOfStarLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FarOfStarLabel.Location = new System.Drawing.Point(432, 466);
            this.FarOfStarLabel.Name = "FarOfStarLabel";
            this.FarOfStarLabel.Size = new System.Drawing.Size(96, 16);
            this.FarOfStarLabel.TabIndex = 49;
            this.FarOfStarLabel.Text = "Удаленность";
            this.FarOfStarLabel.Visible = false;
            // 
            // FarOfStarTextbox
            // 
            this.FarOfStarTextbox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FarOfStarTextbox.Location = new System.Drawing.Point(421, 485);
            this.FarOfStarTextbox.Multiline = true;
            this.FarOfStarTextbox.Name = "FarOfStarTextbox";
            this.FarOfStarTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FarOfStarTextbox.Size = new System.Drawing.Size(129, 26);
            this.FarOfStarTextbox.TabIndex = 48;
            this.FarOfStarTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FarOfStarTextbox.Visible = false;
            this.FarOfStarTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FarOfStarKeyPressed);
            // 
            // SizeOfStarLabel
            // 
            this.SizeOfStarLabel.AutoSize = true;
            this.SizeOfStarLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SizeOfStarLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SizeOfStarLabel.Location = new System.Drawing.Point(292, 466);
            this.SizeOfStarLabel.Name = "SizeOfStarLabel";
            this.SizeOfStarLabel.Size = new System.Drawing.Size(112, 16);
            this.SizeOfStarLabel.TabIndex = 47;
            this.SizeOfStarLabel.Text = "Размер звезды";
            this.SizeOfStarLabel.Visible = false;
            // 
            // SizeOfStarTextbox
            // 
            this.SizeOfStarTextbox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SizeOfStarTextbox.Location = new System.Drawing.Point(286, 485);
            this.SizeOfStarTextbox.Multiline = true;
            this.SizeOfStarTextbox.Name = "SizeOfStarTextbox";
            this.SizeOfStarTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SizeOfStarTextbox.Size = new System.Drawing.Size(129, 26);
            this.SizeOfStarTextbox.TabIndex = 46;
            this.SizeOfStarTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SizeOfStarTextbox.Visible = false;
            this.SizeOfStarTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SizeOfStarKeyPressed);
            // 
            // NameOfStarLabel
            // 
            this.NameOfStarLabel.AutoSize = true;
            this.NameOfStarLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameOfStarLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameOfStarLabel.Location = new System.Drawing.Point(148, 466);
            this.NameOfStarLabel.Name = "NameOfStarLabel";
            this.NameOfStarLabel.Size = new System.Drawing.Size(128, 16);
            this.NameOfStarLabel.TabIndex = 45;
            this.NameOfStarLabel.Text = "Название звезды";
            this.NameOfStarLabel.Visible = false;
            // 
            // NameOfStarTextbox
            // 
            this.NameOfStarTextbox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameOfStarTextbox.Location = new System.Drawing.Point(151, 485);
            this.NameOfStarTextbox.Multiline = true;
            this.NameOfStarTextbox.Name = "NameOfStarTextbox";
            this.NameOfStarTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NameOfStarTextbox.Size = new System.Drawing.Size(129, 26);
            this.NameOfStarTextbox.TabIndex = 44;
            this.NameOfStarTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameOfStarTextbox.Visible = false;
            // 
            // NumberOfStarLabel
            // 
            this.NumberOfStarLabel.AutoSize = true;
            this.NumberOfStarLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfStarLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NumberOfStarLabel.Location = new System.Drawing.Point(18, 466);
            this.NumberOfStarLabel.Name = "NumberOfStarLabel";
            this.NumberOfStarLabel.Size = new System.Drawing.Size(104, 16);
            this.NumberOfStarLabel.TabIndex = 43;
            this.NumberOfStarLabel.Text = "Номер звезды";
            this.NumberOfStarLabel.Visible = false;
            // 
            // NumberOfStarTextbox
            // 
            this.NumberOfStarTextbox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfStarTextbox.Location = new System.Drawing.Point(16, 485);
            this.NumberOfStarTextbox.Multiline = true;
            this.NumberOfStarTextbox.Name = "NumberOfStarTextbox";
            this.NumberOfStarTextbox.ReadOnly = true;
            this.NumberOfStarTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NumberOfStarTextbox.Size = new System.Drawing.Size(129, 26);
            this.NumberOfStarTextbox.TabIndex = 42;
            this.NumberOfStarTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumberOfStarTextbox.Visible = false;
            // 
            // SaveStarButton
            // 
            this.SaveStarButton.AnimationHoverSpeed = 0.07F;
            this.SaveStarButton.AnimationSpeed = 0.03F;
            this.SaveStarButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.SaveStarButton.BorderColor = System.Drawing.Color.Black;
            this.SaveStarButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.SaveStarButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.SaveStarButton.CheckedForeColor = System.Drawing.Color.White;
            this.SaveStarButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("SaveStarButton.CheckedImage")));
            this.SaveStarButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.SaveStarButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SaveStarButton.FocusedColor = System.Drawing.Color.Empty;
            this.SaveStarButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SaveStarButton.ForeColor = System.Drawing.Color.White;
            this.SaveStarButton.Image = null;
            this.SaveStarButton.ImageSize = new System.Drawing.Size(20, 20);
            this.SaveStarButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SaveStarButton.Location = new System.Drawing.Point(702, 473);
            this.SaveStarButton.Name = "SaveStarButton";
            this.SaveStarButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.SaveStarButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SaveStarButton.OnHoverForeColor = System.Drawing.Color.White;
            this.SaveStarButton.OnHoverImage = null;
            this.SaveStarButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.SaveStarButton.OnPressedColor = System.Drawing.Color.Black;
            this.SaveStarButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SaveStarButton.Size = new System.Drawing.Size(114, 42);
            this.SaveStarButton.TabIndex = 50;
            this.SaveStarButton.Text = "Добавить запись";
            this.SaveStarButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SaveStarButton.Visible = false;
            this.SaveStarButton.Click += new System.EventHandler(this.SaveStarButton_Click);
            // 
            // SaveEditStarButton
            // 
            this.SaveEditStarButton.AnimationHoverSpeed = 0.07F;
            this.SaveEditStarButton.AnimationSpeed = 0.03F;
            this.SaveEditStarButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.SaveEditStarButton.BorderColor = System.Drawing.Color.Black;
            this.SaveEditStarButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.SaveEditStarButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.SaveEditStarButton.CheckedForeColor = System.Drawing.Color.White;
            this.SaveEditStarButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("SaveEditStarButton.CheckedImage")));
            this.SaveEditStarButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.SaveEditStarButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SaveEditStarButton.FocusedColor = System.Drawing.Color.Empty;
            this.SaveEditStarButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SaveEditStarButton.ForeColor = System.Drawing.Color.White;
            this.SaveEditStarButton.Image = null;
            this.SaveEditStarButton.ImageSize = new System.Drawing.Size(20, 20);
            this.SaveEditStarButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SaveEditStarButton.Location = new System.Drawing.Point(701, 473);
            this.SaveEditStarButton.Name = "SaveEditStarButton";
            this.SaveEditStarButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.SaveEditStarButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SaveEditStarButton.OnHoverForeColor = System.Drawing.Color.White;
            this.SaveEditStarButton.OnHoverImage = null;
            this.SaveEditStarButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.SaveEditStarButton.OnPressedColor = System.Drawing.Color.Black;
            this.SaveEditStarButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SaveEditStarButton.Size = new System.Drawing.Size(112, 38);
            this.SaveEditStarButton.TabIndex = 51;
            this.SaveEditStarButton.Text = "Изменить запись";
            this.SaveEditStarButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SaveEditStarButton.Visible = false;
            this.SaveEditStarButton.Click += new System.EventHandler(this.SaveEditStarButton_Click);
            // 
            // MassOfStarLabel
            // 
            this.MassOfStarLabel.AutoSize = true;
            this.MassOfStarLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MassOfStarLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MassOfStarLabel.Location = new System.Drawing.Point(556, 466);
            this.MassOfStarLabel.Name = "MassOfStarLabel";
            this.MassOfStarLabel.Size = new System.Drawing.Size(104, 16);
            this.MassOfStarLabel.TabIndex = 53;
            this.MassOfStarLabel.Text = "Масса звезды";
            this.MassOfStarLabel.Visible = false;
            // 
            // MassOfStarTextbox
            // 
            this.MassOfStarTextbox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MassOfStarTextbox.Location = new System.Drawing.Point(556, 485);
            this.MassOfStarTextbox.Multiline = true;
            this.MassOfStarTextbox.Name = "MassOfStarTextbox";
            this.MassOfStarTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MassOfStarTextbox.Size = new System.Drawing.Size(129, 26);
            this.MassOfStarTextbox.TabIndex = 52;
            this.MassOfStarTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MassOfStarTextbox.Visible = false;
            this.MassOfStarTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MassOfStarKeyPressed);
            // 
            // ReturnButton
            // 
            this.ReturnButton.AnimationHoverSpeed = 0.07F;
            this.ReturnButton.AnimationSpeed = 0.03F;
            this.ReturnButton.BaseColor = System.Drawing.Color.Transparent;
            this.ReturnButton.BorderColor = System.Drawing.Color.Black;
            this.ReturnButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ReturnButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.ReturnButton.CheckedForeColor = System.Drawing.Color.White;
            this.ReturnButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ReturnButton.CheckedImage")));
            this.ReturnButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ReturnButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ReturnButton.FocusedColor = System.Drawing.Color.Empty;
            this.ReturnButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ReturnButton.ForeColor = System.Drawing.Color.White;
            this.ReturnButton.Image = ((System.Drawing.Image)(resources.GetObject("ReturnButton.Image")));
            this.ReturnButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ReturnButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ReturnButton.Location = new System.Drawing.Point(778, 440);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.ReturnButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ReturnButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ReturnButton.OnHoverImage = null;
            this.ReturnButton.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.ReturnButton.OnPressedColor = System.Drawing.Color.Black;
            this.ReturnButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ReturnButton.Size = new System.Drawing.Size(38, 34);
            this.ReturnButton.TabIndex = 54;
            this.ReturnButton.Text = "Удалить запись";
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(825, 443);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.MassOfStarLabel);
            this.Controls.Add(this.MassOfStarTextbox);
            this.Controls.Add(this.SaveEditStarButton);
            this.Controls.Add(this.SaveStarButton);
            this.Controls.Add(this.FarOfStarLabel);
            this.Controls.Add(this.FarOfStarTextbox);
            this.Controls.Add(this.SizeOfStarLabel);
            this.Controls.Add(this.SizeOfStarTextbox);
            this.Controls.Add(this.NameOfStarLabel);
            this.Controls.Add(this.NameOfStarTextbox);
            this.Controls.Add(this.NumberOfStarLabel);
            this.Controls.Add(this.NumberOfStarTextbox);
            this.Controls.Add(this.SaveButtonPlanet);
            this.Controls.Add(this.EditSaveButtonPlanet);
            this.Controls.Add(this.SizeOfPlanetLabel);
            this.Controls.Add(this.SizeOfPlanetTextbox);
            this.Controls.Add(this.MassOfPlanetLabel);
            this.Controls.Add(this.MassOfPlanetTextbox);
            this.Controls.Add(this.NameOfPlanetLabel);
            this.Controls.Add(this.NameOfPlanetTextbox);
            this.Controls.Add(this.NumberOfPlanetLabel);
            this.Controls.Add(this.NumberOfPlanetTextbox);
            this.Controls.Add(this.EditSaveButtonGalactic);
            this.Controls.Add(this.NumOfObjGalacticLabel);
            this.Controls.Add(this.NameOfGalacticLabel);
            this.Controls.Add(this.NumberOfGalacticLabel);
            this.Controls.Add(this.SaveButtonGalactic);
            this.Controls.Add(this.NumOfObjTextbox);
            this.Controls.Add(this.GalacticNameTextbox);
            this.Controls.Add(this.NumberOfGalacticTextbox);
            this.Controls.Add(this.CollapseButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.Tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GalacticTable)).EndInit();
            this.Tabs.ResumeLayout(false);
            this.GalacticsTab.ResumeLayout(false);
            this.PlanetsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlanetsTable)).EndInit();
            this.StarsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StarsTable)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse Elipse;
        private System.Windows.Forms.DataGridView GalacticTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn GalacticNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn GalacticName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GalacticObjects;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage GalacticsTab;
        private System.Windows.Forms.TabPage PlanetsTab;
        private System.Windows.Forms.DataGridView PlanetsTable;
        private System.Windows.Forms.TabPage StarsTab;
        private System.Windows.Forms.DataGridView StarsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn StarNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StarName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StarSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn StarFar;
        private System.Windows.Forms.DataGridViewTextBoxColumn StarMass;
        private Guna.UI.WinForms.GunaAdvenceButton CollapseButton;
        private Guna.UI.WinForms.GunaAdvenceButton CloseButton;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToFileButton;
        private System.Windows.Forms.ToolStripMenuItem AboutButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanetNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanetMass;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanetSize;
        private Guna.UI.WinForms.GunaDragControl DragControl;
        private Guna.UI.WinForms.GunaAdvenceButton DeleteButtonStars;
        private Guna.UI.WinForms.GunaAdvenceButton DeleteButtonPlanets;
        private Guna.UI.WinForms.GunaAdvenceButton DeleteButtonGalactics;
        private Guna.UI.WinForms.GunaAdvenceButton RefreshButtonGalactic;
        private Guna.UI.WinForms.GunaAdvenceButton RefreshButtonPlanets;
        private Guna.UI.WinForms.GunaAdvenceButton RefreshButtonStars;
        private Guna.UI.WinForms.GunaAdvenceButton EditButtonGalactic;
        private Guna.UI.WinForms.GunaAdvenceButton AddButtonGalactic;
        private Guna.UI.WinForms.GunaAdvenceButton SaveButtonGalactic;
        private System.Windows.Forms.TextBox NumOfObjTextbox;
        private System.Windows.Forms.TextBox GalacticNameTextbox;
        private System.Windows.Forms.TextBox NumberOfGalacticTextbox;
        private System.Windows.Forms.Label NumOfObjGalacticLabel;
        private System.Windows.Forms.Label NameOfGalacticLabel;
        private System.Windows.Forms.Label NumberOfGalacticLabel;
        private Guna.UI.WinForms.GunaAdvenceButton EditSaveButtonGalactic;
        private Guna.UI.WinForms.GunaAdvenceButton EditButtonPlanet;
        private Guna.UI.WinForms.GunaAdvenceButton AddButtonPlanets;
        private Guna.UI.WinForms.GunaAdvenceButton SaveButtonPlanet;
        private Guna.UI.WinForms.GunaAdvenceButton EditSaveButtonPlanet;
        private System.Windows.Forms.Label SizeOfPlanetLabel;
        private System.Windows.Forms.TextBox SizeOfPlanetTextbox;
        private System.Windows.Forms.Label MassOfPlanetLabel;
        private System.Windows.Forms.TextBox MassOfPlanetTextbox;
        private System.Windows.Forms.Label NameOfPlanetLabel;
        private System.Windows.Forms.TextBox NameOfPlanetTextbox;
        private System.Windows.Forms.Label NumberOfPlanetLabel;
        private System.Windows.Forms.TextBox NumberOfPlanetTextbox;
        private Guna.UI.WinForms.GunaAdvenceButton EditButtonStars;
        private Guna.UI.WinForms.GunaAdvenceButton AddButtonStars;
        private System.Windows.Forms.Label MassOfStarLabel;
        private System.Windows.Forms.TextBox MassOfStarTextbox;
        private Guna.UI.WinForms.GunaAdvenceButton SaveEditStarButton;
        private Guna.UI.WinForms.GunaAdvenceButton SaveStarButton;
        private System.Windows.Forms.Label FarOfStarLabel;
        private System.Windows.Forms.TextBox FarOfStarTextbox;
        private System.Windows.Forms.Label SizeOfStarLabel;
        private System.Windows.Forms.TextBox SizeOfStarTextbox;
        private System.Windows.Forms.Label NameOfStarLabel;
        private System.Windows.Forms.TextBox NameOfStarTextbox;
        private System.Windows.Forms.Label NumberOfStarLabel;
        private System.Windows.Forms.TextBox NumberOfStarTextbox;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private Guna.UI.WinForms.GunaAdvenceButton ReturnButton;
    }
}

