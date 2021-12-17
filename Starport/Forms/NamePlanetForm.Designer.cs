
namespace StarportExcel.Forms
{
    partial class NamePlanetForm
    {
        private string excelPath = "";
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

        public void SetExcelPath(string path)
        {
            excelPath = path;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.VolcanicsButton = new System.Windows.Forms.Button();
            this.RockiesButton = new System.Windows.Forms.Button();
            this.OceanicsButton = new System.Windows.Forms.Button();
            this.MountainousButton = new System.Windows.Forms.Button();
            this.GreenhousesButton = new System.Windows.Forms.Button();
            this.EarthlikesButton = new System.Windows.Forms.Button();
            this.DesertsButton = new System.Windows.Forms.Button();
            this.ArcticsButton = new System.Windows.Forms.Button();
            this.PlanetNameOutput = new System.Windows.Forms.TextBox();
            this.ZoundsButton = new System.Windows.Forms.Button();
            this.GrowingButton = new System.Windows.Forms.Button();
            this.ResearchButton = new System.Windows.Forms.Button();
            this.NeedsDefenseButton = new System.Windows.Forms.Button();
            this.InvadedButton = new System.Windows.Forms.Button();
            this.DoubleDomeButton = new System.Windows.Forms.Button();
            this.NameTagTextBox = new System.Windows.Forms.TextBox();
            this.GenerateNameButton = new System.Windows.Forms.Button();
            this.CoordinatesTextBox = new System.Windows.Forms.TextBox();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.UnitCircleCoordinatesButton = new System.Windows.Forms.TextBox();
            this.ConstructingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VolcanicsButton
            // 
            this.VolcanicsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.VolcanicsButton.Location = new System.Drawing.Point(482, 92);
            this.VolcanicsButton.Name = "VolcanicsButton";
            this.VolcanicsButton.Size = new System.Drawing.Size(109, 24);
            this.VolcanicsButton.TabIndex = 16;
            this.VolcanicsButton.Text = "Volcanic";
            this.VolcanicsButton.UseVisualStyleBackColor = true;
            this.VolcanicsButton.Click += new System.EventHandler(this.VolcanicsButton_Click);
            // 
            // RockiesButton
            // 
            this.RockiesButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RockiesButton.Location = new System.Drawing.Point(333, 92);
            this.RockiesButton.Name = "RockiesButton";
            this.RockiesButton.Size = new System.Drawing.Size(109, 24);
            this.RockiesButton.TabIndex = 15;
            this.RockiesButton.Text = "Rocky";
            this.RockiesButton.UseVisualStyleBackColor = true;
            this.RockiesButton.Click += new System.EventHandler(this.RockiesButton_Click);
            // 
            // OceanicsButton
            // 
            this.OceanicsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OceanicsButton.Location = new System.Drawing.Point(191, 92);
            this.OceanicsButton.Name = "OceanicsButton";
            this.OceanicsButton.Size = new System.Drawing.Size(109, 24);
            this.OceanicsButton.TabIndex = 14;
            this.OceanicsButton.Text = "Oceanic";
            this.OceanicsButton.UseVisualStyleBackColor = true;
            this.OceanicsButton.Click += new System.EventHandler(this.OceanicsButton_Click);
            // 
            // MountainousButton
            // 
            this.MountainousButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MountainousButton.Location = new System.Drawing.Point(45, 92);
            this.MountainousButton.Name = "MountainousButton";
            this.MountainousButton.Size = new System.Drawing.Size(109, 24);
            this.MountainousButton.TabIndex = 13;
            this.MountainousButton.Text = "Mountainous";
            this.MountainousButton.UseVisualStyleBackColor = true;
            this.MountainousButton.Click += new System.EventHandler(this.MountainousButton_Click);
            // 
            // GreenhousesButton
            // 
            this.GreenhousesButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GreenhousesButton.Location = new System.Drawing.Point(482, 39);
            this.GreenhousesButton.Name = "GreenhousesButton";
            this.GreenhousesButton.Size = new System.Drawing.Size(109, 24);
            this.GreenhousesButton.TabIndex = 12;
            this.GreenhousesButton.Text = "Greenhouse";
            this.GreenhousesButton.UseVisualStyleBackColor = true;
            this.GreenhousesButton.Click += new System.EventHandler(this.GreenhousesButton_Click);
            // 
            // EarthlikesButton
            // 
            this.EarthlikesButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EarthlikesButton.Location = new System.Drawing.Point(333, 39);
            this.EarthlikesButton.Name = "EarthlikesButton";
            this.EarthlikesButton.Size = new System.Drawing.Size(109, 24);
            this.EarthlikesButton.TabIndex = 11;
            this.EarthlikesButton.Text = "Earthlike";
            this.EarthlikesButton.UseVisualStyleBackColor = true;
            this.EarthlikesButton.Click += new System.EventHandler(this.EarthlikesButton_Click);
            // 
            // DesertsButton
            // 
            this.DesertsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DesertsButton.Location = new System.Drawing.Point(191, 39);
            this.DesertsButton.Name = "DesertsButton";
            this.DesertsButton.Size = new System.Drawing.Size(109, 24);
            this.DesertsButton.TabIndex = 10;
            this.DesertsButton.Text = "Desert";
            this.DesertsButton.UseVisualStyleBackColor = true;
            this.DesertsButton.Click += new System.EventHandler(this.DesertsButton_Click);
            // 
            // ArcticsButton
            // 
            this.ArcticsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ArcticsButton.Location = new System.Drawing.Point(45, 39);
            this.ArcticsButton.Name = "ArcticsButton";
            this.ArcticsButton.Size = new System.Drawing.Size(109, 24);
            this.ArcticsButton.TabIndex = 9;
            this.ArcticsButton.Text = "Arctic";
            this.ArcticsButton.UseVisualStyleBackColor = true;
            this.ArcticsButton.Click += new System.EventHandler(this.ArcticsButton_Click);
            // 
            // PlanetNameOutput
            // 
            this.PlanetNameOutput.AllowDrop = true;
            this.PlanetNameOutput.Location = new System.Drawing.Point(230, 427);
            this.PlanetNameOutput.Name = "PlanetNameOutput";
            this.PlanetNameOutput.Size = new System.Drawing.Size(193, 20);
            this.PlanetNameOutput.TabIndex = 17;
            this.PlanetNameOutput.Text = "Your Planet Name will appear here";
            // 
            // ZoundsButton
            // 
            this.ZoundsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ZoundsButton.Location = new System.Drawing.Point(45, 180);
            this.ZoundsButton.Name = "ZoundsButton";
            this.ZoundsButton.Size = new System.Drawing.Size(109, 24);
            this.ZoundsButton.TabIndex = 18;
            this.ZoundsButton.Text = "Zounds";
            this.ZoundsButton.UseVisualStyleBackColor = true;
            this.ZoundsButton.Click += new System.EventHandler(this.ZoundsButton_Click);
            // 
            // GrowingButton
            // 
            this.GrowingButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GrowingButton.Location = new System.Drawing.Point(191, 180);
            this.GrowingButton.Name = "GrowingButton";
            this.GrowingButton.Size = new System.Drawing.Size(109, 24);
            this.GrowingButton.TabIndex = 19;
            this.GrowingButton.Text = "Growing";
            this.GrowingButton.UseVisualStyleBackColor = true;
            this.GrowingButton.Click += new System.EventHandler(this.GrowingButton_Click);
            // 
            // ResearchButton
            // 
            this.ResearchButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ResearchButton.Location = new System.Drawing.Point(333, 180);
            this.ResearchButton.Name = "ResearchButton";
            this.ResearchButton.Size = new System.Drawing.Size(109, 24);
            this.ResearchButton.TabIndex = 20;
            this.ResearchButton.Text = "Research";
            this.ResearchButton.UseVisualStyleBackColor = true;
            this.ResearchButton.Click += new System.EventHandler(this.ResearchButton_Click);
            // 
            // NeedsDefenseButton
            // 
            this.NeedsDefenseButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NeedsDefenseButton.Location = new System.Drawing.Point(482, 180);
            this.NeedsDefenseButton.Name = "NeedsDefenseButton";
            this.NeedsDefenseButton.Size = new System.Drawing.Size(109, 24);
            this.NeedsDefenseButton.TabIndex = 21;
            this.NeedsDefenseButton.Text = "Needs Defense";
            this.NeedsDefenseButton.UseVisualStyleBackColor = true;
            this.NeedsDefenseButton.Click += new System.EventHandler(this.NeedsDefenseButton_Click);
            // 
            // InvadedButton
            // 
            this.InvadedButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.InvadedButton.Location = new System.Drawing.Point(191, 234);
            this.InvadedButton.Name = "InvadedButton";
            this.InvadedButton.Size = new System.Drawing.Size(109, 24);
            this.InvadedButton.TabIndex = 22;
            this.InvadedButton.Text = "Invaded";
            this.InvadedButton.UseVisualStyleBackColor = true;
            this.InvadedButton.Click += new System.EventHandler(this.InvadedButton_Click);
            // 
            // DoubleDomeButton
            // 
            this.DoubleDomeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DoubleDomeButton.Location = new System.Drawing.Point(333, 234);
            this.DoubleDomeButton.Name = "DoubleDomeButton";
            this.DoubleDomeButton.Size = new System.Drawing.Size(109, 24);
            this.DoubleDomeButton.TabIndex = 23;
            this.DoubleDomeButton.Text = "Double Dome";
            this.DoubleDomeButton.UseVisualStyleBackColor = true;
            this.DoubleDomeButton.Click += new System.EventHandler(this.DoubleDomeButton_Click);
            // 
            // NameTagTextBox
            // 
            this.NameTagTextBox.AllowDrop = true;
            this.NameTagTextBox.Location = new System.Drawing.Point(45, 321);
            this.NameTagTextBox.Name = "NameTagTextBox";
            this.NameTagTextBox.Size = new System.Drawing.Size(181, 20);
            this.NameTagTextBox.TabIndex = 24;
            this.NameTagTextBox.Text = "Input Name to override default";
            this.NameTagTextBox.TextChanged += new System.EventHandler(this.NameTagTextBox_TextChanged);
            // 
            // GenerateNameButton
            // 
            this.GenerateNameButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GenerateNameButton.Location = new System.Drawing.Point(45, 423);
            this.GenerateNameButton.Name = "GenerateNameButton";
            this.GenerateNameButton.Size = new System.Drawing.Size(109, 24);
            this.GenerateNameButton.TabIndex = 25;
            this.GenerateNameButton.Text = "Generate Name";
            this.GenerateNameButton.UseVisualStyleBackColor = true;
            this.GenerateNameButton.Click += new System.EventHandler(this.GenerateNameButton_Click);
            // 
            // CoordinatesTextBox
            // 
            this.CoordinatesTextBox.AllowDrop = true;
            this.CoordinatesTextBox.Location = new System.Drawing.Point(45, 347);
            this.CoordinatesTextBox.Name = "CoordinatesTextBox";
            this.CoordinatesTextBox.Size = new System.Drawing.Size(181, 20);
            this.CoordinatesTextBox.TabIndex = 26;
            this.CoordinatesTextBox.Text = "Input System Coordinates";
            this.CoordinatesTextBox.TextChanged += new System.EventHandler(this.CoordinatesTextBox_TextChanged);
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ClearAllButton.Location = new System.Drawing.Point(465, 424);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(109, 24);
            this.ClearAllButton.TabIndex = 27;
            this.ClearAllButton.Text = "Clear All";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // UnitCircleCoordinatesButton
            // 
            this.UnitCircleCoordinatesButton.AllowDrop = true;
            this.UnitCircleCoordinatesButton.Location = new System.Drawing.Point(45, 373);
            this.UnitCircleCoordinatesButton.Name = "UnitCircleCoordinatesButton";
            this.UnitCircleCoordinatesButton.Size = new System.Drawing.Size(181, 20);
            this.UnitCircleCoordinatesButton.TabIndex = 28;
            this.UnitCircleCoordinatesButton.Text = "Input Circle Coordinates";
            this.UnitCircleCoordinatesButton.TextChanged += new System.EventHandler(this.UnitCircleCoordinatesButton_TextChanged);
            // 
            // ConstructingButton
            // 
            this.ConstructingButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ConstructingButton.Location = new System.Drawing.Point(45, 234);
            this.ConstructingButton.Name = "ConstructingButton";
            this.ConstructingButton.Size = new System.Drawing.Size(109, 24);
            this.ConstructingButton.TabIndex = 29;
            this.ConstructingButton.Text = "Constructing";
            this.ConstructingButton.UseVisualStyleBackColor = true;
            this.ConstructingButton.Click += new System.EventHandler(this.ConstructingButton_Click);
            // 
            // NamePlanetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 459);
            this.Controls.Add(this.ConstructingButton);
            this.Controls.Add(this.UnitCircleCoordinatesButton);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.CoordinatesTextBox);
            this.Controls.Add(this.GenerateNameButton);
            this.Controls.Add(this.NameTagTextBox);
            this.Controls.Add(this.DoubleDomeButton);
            this.Controls.Add(this.InvadedButton);
            this.Controls.Add(this.NeedsDefenseButton);
            this.Controls.Add(this.ResearchButton);
            this.Controls.Add(this.GrowingButton);
            this.Controls.Add(this.ZoundsButton);
            this.Controls.Add(this.PlanetNameOutput);
            this.Controls.Add(this.VolcanicsButton);
            this.Controls.Add(this.RockiesButton);
            this.Controls.Add(this.OceanicsButton);
            this.Controls.Add(this.MountainousButton);
            this.Controls.Add(this.GreenhousesButton);
            this.Controls.Add(this.EarthlikesButton);
            this.Controls.Add(this.DesertsButton);
            this.Controls.Add(this.ArcticsButton);
            this.Name = "NamePlanetForm";
            this.Text = "NamePlanetForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VolcanicsButton;
        private System.Windows.Forms.Button RockiesButton;
        private System.Windows.Forms.Button OceanicsButton;
        private System.Windows.Forms.Button MountainousButton;
        private System.Windows.Forms.Button GreenhousesButton;
        private System.Windows.Forms.Button EarthlikesButton;
        private System.Windows.Forms.Button DesertsButton;
        private System.Windows.Forms.Button ArcticsButton;
        private System.Windows.Forms.TextBox PlanetNameOutput;
        private System.Windows.Forms.Button ZoundsButton;
        private System.Windows.Forms.Button GrowingButton;
        private System.Windows.Forms.Button ResearchButton;
        private System.Windows.Forms.Button NeedsDefenseButton;
        private System.Windows.Forms.Button InvadedButton;
        private System.Windows.Forms.Button DoubleDomeButton;
        private System.Windows.Forms.TextBox NameTagTextBox;
        private System.Windows.Forms.Button GenerateNameButton;
        private System.Windows.Forms.TextBox CoordinatesTextBox;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.TextBox UnitCircleCoordinatesButton;
        private System.Windows.Forms.Button ConstructingButton;
    }
}