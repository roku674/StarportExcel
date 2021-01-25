using System;
using System.Windows.Forms;

namespace StarportExcel
{
    partial class PlanetTypeForm
    {
        private Button ArcticsButton;
        private Button DesertsButton;
        private Button EarthsButton;
        private Button GreenhousesButton;
        private Button MountainsButton;
        private Button OceanicsButton;
        private Button ParadisesButton;
        private Button RockiesButton;
        private Button VolcanicsButton;

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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanetTypeForm));
            this.ArcticsButton = new System.Windows.Forms.Button();
            this.DesertsButton = new System.Windows.Forms.Button();
            this.EarthsButton = new System.Windows.Forms.Button();
            this.GreenhousesButton = new System.Windows.Forms.Button();
            this.MountainsButton = new System.Windows.Forms.Button();
            this.OceanicsButton = new System.Windows.Forms.Button();
            this.ParadisesButton = new System.Windows.Forms.Button();
            this.RockiesButton = new System.Windows.Forms.Button();
            this.VolcanicsButton = new System.Windows.Forms.Button();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.NeedsDefensesButton = new System.Windows.Forms.Button();
            this.GrowingButton = new System.Windows.Forms.Button();
            this.ClearOutputButton = new System.Windows.Forms.Button();
            this.LineBreakButton = new System.Windows.Forms.Button();
            this.toolStripPT = new System.Windows.Forms.ToolStrip();
            this.OpenToolStripButtonPT = new System.Windows.Forms.ToolStripButton();
            this.SaveToolStripButtonPT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.CopyToolStripButtonPT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.HelpMeNiggaDamnToolStripButtonPT = new System.Windows.Forms.ToolStripButton();
            this.DirectorshipListButton = new System.Windows.Forms.Button();
            this.PrisonListButton = new System.Windows.Forms.Button();
            this.SocialismListButton = new System.Windows.Forms.Button();
            this.DemocracyListButton = new System.Windows.Forms.Button();
            this.NukesListButton = new System.Windows.Forms.Button();
            this.CMinesListButton = new System.Windows.Forms.Button();
            this.SolarsListButton = new System.Windows.Forms.Button();
            this.LasersListButton = new System.Windows.Forms.Button();
            this.BuildListButton = new System.Windows.Forms.Button();
            this.DeconstructListButton = new System.Windows.Forms.Button();
            this.FindMoraleButton = new System.Windows.Forms.Button();
            this.RenameListsButton = new System.Windows.Forms.Button();
            this.DoubleDomeListButton = new System.Windows.Forms.Button();
            this.toolStripPT.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArcticsButton
            // 
            resources.ApplyResources(this.ArcticsButton, "ArcticsButton");
            this.ArcticsButton.Name = "ArcticsButton";
            this.ArcticsButton.UseVisualStyleBackColor = true;
            this.ArcticsButton.Click += new System.EventHandler(this.ArcticsButton_Click);
            // 
            // DesertsButton
            // 
            resources.ApplyResources(this.DesertsButton, "DesertsButton");
            this.DesertsButton.Name = "DesertsButton";
            this.DesertsButton.UseVisualStyleBackColor = true;
            this.DesertsButton.Click += new System.EventHandler(this.DesertsButton_Click);
            // 
            // EarthsButton
            // 
            resources.ApplyResources(this.EarthsButton, "EarthsButton");
            this.EarthsButton.Name = "EarthsButton";
            this.EarthsButton.UseVisualStyleBackColor = true;
            this.EarthsButton.Click += new System.EventHandler(this.EarthsButton_Click);
            // 
            // GreenhousesButton
            // 
            resources.ApplyResources(this.GreenhousesButton, "GreenhousesButton");
            this.GreenhousesButton.Name = "GreenhousesButton";
            this.GreenhousesButton.UseVisualStyleBackColor = true;
            this.GreenhousesButton.Click += new System.EventHandler(this.GreenhousesButton_Click);
            // 
            // MountainsButton
            // 
            resources.ApplyResources(this.MountainsButton, "MountainsButton");
            this.MountainsButton.Name = "MountainsButton";
            this.MountainsButton.UseVisualStyleBackColor = true;
            this.MountainsButton.Click += new System.EventHandler(this.MountainsButton_Click);
            // 
            // OceanicsButton
            // 
            resources.ApplyResources(this.OceanicsButton, "OceanicsButton");
            this.OceanicsButton.Name = "OceanicsButton";
            this.OceanicsButton.UseVisualStyleBackColor = true;
            this.OceanicsButton.Click += new System.EventHandler(this.OceanicsButton_Click);
            // 
            // ParadisesButton
            // 
            resources.ApplyResources(this.ParadisesButton, "ParadisesButton");
            this.ParadisesButton.Name = "ParadisesButton";
            this.ParadisesButton.UseVisualStyleBackColor = true;
            this.ParadisesButton.Click += new System.EventHandler(this.ParadisesButton_Click);
            // 
            // RockiesButton
            // 
            resources.ApplyResources(this.RockiesButton, "RockiesButton");
            this.RockiesButton.Name = "RockiesButton";
            this.RockiesButton.UseVisualStyleBackColor = true;
            this.RockiesButton.Click += new System.EventHandler(this.RockiesButton_Click);
            // 
            // VolcanicsButton
            // 
            resources.ApplyResources(this.VolcanicsButton, "VolcanicsButton");
            this.VolcanicsButton.Name = "VolcanicsButton";
            this.VolcanicsButton.UseVisualStyleBackColor = true;
            this.VolcanicsButton.Click += new System.EventHandler(this.VolcanicsButton_Click);
            // 
            // numberTextBox
            // 
            resources.ApplyResources(this.numberTextBox, "numberTextBox");
            this.numberTextBox.Name = "numberTextBox";
            // 
            // NeedsDefensesButton
            // 
            resources.ApplyResources(this.NeedsDefensesButton, "NeedsDefensesButton");
            this.NeedsDefensesButton.Name = "NeedsDefensesButton";
            this.NeedsDefensesButton.UseVisualStyleBackColor = true;
            this.NeedsDefensesButton.Click += new System.EventHandler(this.NeedsDefensesButton_Click);
            // 
            // GrowingButton
            // 
            resources.ApplyResources(this.GrowingButton, "GrowingButton");
            this.GrowingButton.Name = "GrowingButton";
            this.GrowingButton.UseVisualStyleBackColor = true;
            this.GrowingButton.Click += new System.EventHandler(this.GrowingButton_Click);
            // 
            // ClearOutputButton
            // 
            resources.ApplyResources(this.ClearOutputButton, "ClearOutputButton");
            this.ClearOutputButton.Name = "ClearOutputButton";
            this.ClearOutputButton.UseVisualStyleBackColor = true;
            this.ClearOutputButton.Click += new System.EventHandler(this.ClearOutputButton_Click);
            // 
            // LineBreakButton
            // 
            resources.ApplyResources(this.LineBreakButton, "LineBreakButton");
            this.LineBreakButton.Name = "LineBreakButton";
            this.LineBreakButton.UseVisualStyleBackColor = true;
            this.LineBreakButton.Click += new System.EventHandler(this.LineBreakButton_Click);
            // 
            // toolStripPT
            // 
            resources.ApplyResources(this.toolStripPT, "toolStripPT");
            this.toolStripPT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripButtonPT,
            this.SaveToolStripButtonPT,
            this.toolStripSeparator,
            this.CopyToolStripButtonPT,
            this.toolStripSeparator1,
            this.HelpMeNiggaDamnToolStripButtonPT});
            this.toolStripPT.Name = "toolStripPT";
            // 
            // OpenToolStripButtonPT
            // 
            resources.ApplyResources(this.OpenToolStripButtonPT, "OpenToolStripButtonPT");
            this.OpenToolStripButtonPT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenToolStripButtonPT.Name = "OpenToolStripButtonPT";
            this.OpenToolStripButtonPT.Click += new System.EventHandler(this.OpenToolStripButton_Click);
            // 
            // SaveToolStripButtonPT
            // 
            resources.ApplyResources(this.SaveToolStripButtonPT, "SaveToolStripButtonPT");
            this.SaveToolStripButtonPT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveToolStripButtonPT.Name = "SaveToolStripButtonPT";
            this.SaveToolStripButtonPT.Click += new System.EventHandler(this.SaveToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            resources.ApplyResources(this.toolStripSeparator, "toolStripSeparator");
            this.toolStripSeparator.Name = "toolStripSeparator";
            // 
            // CopyToolStripButtonPT
            // 
            resources.ApplyResources(this.CopyToolStripButtonPT, "CopyToolStripButtonPT");
            this.CopyToolStripButtonPT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopyToolStripButtonPT.Name = "CopyToolStripButtonPT";
            this.CopyToolStripButtonPT.Click += new System.EventHandler(this.CopyToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // HelpMeNiggaDamnToolStripButtonPT
            // 
            resources.ApplyResources(this.HelpMeNiggaDamnToolStripButtonPT, "HelpMeNiggaDamnToolStripButtonPT");
            this.HelpMeNiggaDamnToolStripButtonPT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HelpMeNiggaDamnToolStripButtonPT.Name = "HelpMeNiggaDamnToolStripButtonPT";
            this.HelpMeNiggaDamnToolStripButtonPT.Click += new System.EventHandler(this.HelpMeNiggaDamnToolStripButton_Click);
            // 
            // DirectorshipListButton
            // 
            resources.ApplyResources(this.DirectorshipListButton, "DirectorshipListButton");
            this.DirectorshipListButton.Name = "DirectorshipListButton";
            this.DirectorshipListButton.UseVisualStyleBackColor = true;
            // 
            // PrisonListButton
            // 
            resources.ApplyResources(this.PrisonListButton, "PrisonListButton");
            this.PrisonListButton.Name = "PrisonListButton";
            this.PrisonListButton.UseVisualStyleBackColor = true;
            // 
            // SocialismListButton
            // 
            resources.ApplyResources(this.SocialismListButton, "SocialismListButton");
            this.SocialismListButton.Name = "SocialismListButton";
            this.SocialismListButton.UseVisualStyleBackColor = true;
            // 
            // DemocracyListButton
            // 
            resources.ApplyResources(this.DemocracyListButton, "DemocracyListButton");
            this.DemocracyListButton.Name = "DemocracyListButton";
            this.DemocracyListButton.UseVisualStyleBackColor = true;
            // 
            // NukesListButton
            // 
            resources.ApplyResources(this.NukesListButton, "NukesListButton");
            this.NukesListButton.Name = "NukesListButton";
            this.NukesListButton.UseVisualStyleBackColor = true;
            // 
            // CMinesListButton
            // 
            resources.ApplyResources(this.CMinesListButton, "CMinesListButton");
            this.CMinesListButton.Name = "CMinesListButton";
            this.CMinesListButton.UseVisualStyleBackColor = true;
            this.CMinesListButton.Click += new System.EventHandler(this.CMinesListButton_Click);
            // 
            // SolarsListButton
            // 
            resources.ApplyResources(this.SolarsListButton, "SolarsListButton");
            this.SolarsListButton.Name = "SolarsListButton";
            this.SolarsListButton.UseVisualStyleBackColor = true;
            // 
            // LasersListButton
            // 
            resources.ApplyResources(this.LasersListButton, "LasersListButton");
            this.LasersListButton.Name = "LasersListButton";
            this.LasersListButton.UseVisualStyleBackColor = true;
            // 
            // BuildListButton
            // 
            resources.ApplyResources(this.BuildListButton, "BuildListButton");
            this.BuildListButton.Name = "BuildListButton";
            this.BuildListButton.UseVisualStyleBackColor = true;
            // 
            // DeconstructListButton
            // 
            resources.ApplyResources(this.DeconstructListButton, "DeconstructListButton");
            this.DeconstructListButton.Name = "DeconstructListButton";
            this.DeconstructListButton.UseVisualStyleBackColor = true;
            // 
            // FindMoraleButton
            // 
            resources.ApplyResources(this.FindMoraleButton, "FindMoraleButton");
            this.FindMoraleButton.Name = "FindMoraleButton";
            this.FindMoraleButton.UseVisualStyleBackColor = true;
            // 
            // RenameListsButton
            // 
            resources.ApplyResources(this.RenameListsButton, "RenameListsButton");
            this.RenameListsButton.Name = "RenameListsButton";
            this.RenameListsButton.UseVisualStyleBackColor = true;
            this.RenameListsButton.Click += new System.EventHandler(this.RenameListsButton_Click);
            // 
            // DoubleDomeListButton
            // 
            resources.ApplyResources(this.DoubleDomeListButton, "DoubleDomeListButton");
            this.DoubleDomeListButton.Name = "DoubleDomeListButton";
            this.DoubleDomeListButton.UseVisualStyleBackColor = true;
            this.DoubleDomeListButton.Click += new System.EventHandler(this.DoubleDomeListButton_Click);
            // 
            // PlanetTypeForm
            // 
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.DoubleDomeListButton);
            this.Controls.Add(this.RenameListsButton);
            this.Controls.Add(this.FindMoraleButton);
            this.Controls.Add(this.DeconstructListButton);
            this.Controls.Add(this.BuildListButton);
            this.Controls.Add(this.SolarsListButton);
            this.Controls.Add(this.LasersListButton);
            this.Controls.Add(this.CMinesListButton);
            this.Controls.Add(this.NukesListButton);
            this.Controls.Add(this.SocialismListButton);
            this.Controls.Add(this.DemocracyListButton);
            this.Controls.Add(this.PrisonListButton);
            this.Controls.Add(this.DirectorshipListButton);
            this.Controls.Add(this.toolStripPT);
            this.Controls.Add(this.LineBreakButton);
            this.Controls.Add(this.ClearOutputButton);
            this.Controls.Add(this.GrowingButton);
            this.Controls.Add(this.NeedsDefensesButton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.VolcanicsButton);
            this.Controls.Add(this.RockiesButton);
            this.Controls.Add(this.ParadisesButton);
            this.Controls.Add(this.OceanicsButton);
            this.Controls.Add(this.MountainsButton);
            this.Controls.Add(this.GreenhousesButton);
            this.Controls.Add(this.EarthsButton);
            this.Controls.Add(this.DesertsButton);
            this.Controls.Add(this.ArcticsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "PlanetTypeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlanetTypeForm_FormClosing);
            this.toolStripPT.ResumeLayout(false);
            this.toolStripPT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        } //init

        private System.Windows.Forms.TextBox numberTextBox;
        private Button NeedsDefensesButton;
        private Button GrowingButton;
        private Button ClearOutputButton;
        private Button LineBreakButton;
        private ToolStrip toolStripPT;
        private ToolStripButton OpenToolStripButtonPT;
        private ToolStripButton SaveToolStripButtonPT;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton CopyToolStripButtonPT;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton HelpMeNiggaDamnToolStripButtonPT;
        private Button DirectorshipListButton;
        private Button PrisonListButton;
        private Button SocialismListButton;
        private Button DemocracyListButton;
        private Button NukesListButton;
        private Button CMinesListButton;
        private Button SolarsListButton;
        private Button LasersListButton;
        private Button BuildListButton;
        private Button DeconstructListButton;
        private Button FindMoraleButton;
        private Button RenameListsButton;
        private Button DoubleDomeListButton;
    }//class
}//namespace