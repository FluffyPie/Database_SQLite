namespace Laba_4_CSharp.Forms
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MainLabel = new System.Windows.Forms.Label();
            this.TopPanelDragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.MainPanelDragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.CloseButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ElipseAboutForm = new Guna.UI.WinForms.GunaElipse(this.components);
            this.CloseAboutButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(464, 44);
            this.TopPanel.TabIndex = 25;
            // 
            // MainLabel
            // 
            this.MainLabel.BackColor = System.Drawing.Color.Transparent;
            this.MainLabel.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MainLabel.Location = new System.Drawing.Point(71, 66);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(319, 341);
            this.MainLabel.TabIndex = 27;
            this.MainLabel.Text = "Лабораторная работа №4\r\nНаписать программу для работы с базой данных\r\nСтудент гру" +
    "ппы 484\r\nКлюев Богдан Сергеевич\r\n2020 год";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TopPanelDragControl
            // 
            this.TopPanelDragControl.TargetControl = this.TopPanel;
            // 
            // MainPanelDragControl
            // 
            this.MainPanelDragControl.TargetControl = this;
            // 
            // CloseButton
            // 
            this.CloseButton.AnimationHoverSpeed = 0.07F;
            this.CloseButton.AnimationSpeed = 0.03F;
            this.CloseButton.BaseColor = System.Drawing.Color.Transparent;
            this.CloseButton.BorderColor = System.Drawing.Color.Black;
            this.CloseButton.CheckedBaseColor = System.Drawing.SystemColors.GrayText;
            this.CloseButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.CloseButton.CheckedForeColor = System.Drawing.Color.White;
            this.CloseButton.CheckedImage = null;
            this.CloseButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CloseButton.FocusedColor = System.Drawing.Color.Empty;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Image = null;
            this.CloseButton.ImageSize = new System.Drawing.Size(20, 20);
            this.CloseButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CloseButton.Location = new System.Drawing.Point(140, 355);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CloseButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CloseButton.OnHoverForeColor = System.Drawing.Color.White;
            this.CloseButton.OnHoverImage = null;
            this.CloseButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CloseButton.OnPressedColor = System.Drawing.Color.Black;
            this.CloseButton.Size = new System.Drawing.Size(180, 42);
            this.CloseButton.TabIndex = 28;
            this.CloseButton.Text = "Close";
            this.CloseButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ElipseAboutForm
            // 
            this.ElipseAboutForm.TargetControl = this;
            // 
            // CloseAboutButton
            // 
            this.CloseAboutButton.AnimationHoverSpeed = 0.07F;
            this.CloseAboutButton.AnimationSpeed = 0.03F;
            this.CloseAboutButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.CloseAboutButton.BorderColor = System.Drawing.Color.Black;
            this.CloseAboutButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.CloseAboutButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.CloseAboutButton.CheckedForeColor = System.Drawing.Color.White;
            this.CloseAboutButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("CloseAboutButton.CheckedImage")));
            this.CloseAboutButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.CloseAboutButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CloseAboutButton.FocusedColor = System.Drawing.Color.Empty;
            this.CloseAboutButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseAboutButton.ForeColor = System.Drawing.Color.White;
            this.CloseAboutButton.Image = null;
            this.CloseAboutButton.ImageSize = new System.Drawing.Size(20, 20);
            this.CloseAboutButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CloseAboutButton.Location = new System.Drawing.Point(140, 396);
            this.CloseAboutButton.Name = "CloseAboutButton";
            this.CloseAboutButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.CloseAboutButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CloseAboutButton.OnHoverForeColor = System.Drawing.Color.White;
            this.CloseAboutButton.OnHoverImage = null;
            this.CloseAboutButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.CloseAboutButton.OnPressedColor = System.Drawing.Color.Black;
            this.CloseAboutButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CloseAboutButton.Size = new System.Drawing.Size(180, 42);
            this.CloseAboutButton.TabIndex = 29;
            this.CloseAboutButton.Text = "Закрыть";
            this.CloseAboutButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CloseAboutButton.Click += new System.EventHandler(this.CloseAboutButton_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(464, 474);
            this.Controls.Add(this.CloseAboutButton);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label MainLabel;
        private Guna.UI.WinForms.GunaDragControl TopPanelDragControl;
        private Guna.UI.WinForms.GunaDragControl MainPanelDragControl;
        private Guna.UI.WinForms.GunaAdvenceButton CloseButton;
        private Guna.UI.WinForms.GunaElipse ElipseAboutForm;
        private Guna.UI.WinForms.GunaAdvenceButton CloseAboutButton;
    }
}