using System;
using System.Windows.Forms;

namespace StarportExcel
{
    partial class PlanetTypeForm
    {
        private Button ArcticsButton;
        private Button DesertsButton;
        private Button EarthlikesButton;
        private Button GreenhousesButton;
        private Button MountainousButton;
        private Button OceanicsButton;
        private Button ParadisesButton;
        private Button RockiesButton;
        private Button VolcanicsButton;
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
        private Button SameSystemListButton;
        private Button FindMoraleButton;
        private Button RenameListsButton;
        private Button DoubleDomeListButton;

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
            this.EarthlikesButton = new System.Windows.Forms.Button();
            this.GreenhousesButton = new System.Windows.Forms.Button();
            this.MountainousButton = new System.Windows.Forms.Button();
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
            this.SameSystemListButton = new System.Windows.Forms.Button();
            this.FindMoraleButton = new System.Windows.Forms.Button();
            this.RenameListsButton = new System.Windows.Forms.Button();
            this.DoubleDomeListButton = new System.Windows.Forms.Button();
            this.ArcticZoundsCheckBox = new System.Windows.Forms.CheckBox();
            this.ArcticsCheckBox = new System.Windows.Forms.CheckBox();
            this.DesertsCheckBox = new System.Windows.Forms.CheckBox();
            this.DesertZoundsCheckBox = new System.Windows.Forms.CheckBox();
            this.GreenhousesCheckBox = new System.Windows.Forms.CheckBox();
            this.GreenhouseZoundsCheckBox = new System.Windows.Forms.CheckBox();
            this.EarthlikesCheckBox = new System.Windows.Forms.CheckBox();
            this.EarthlikeZoundsCheckBox = new System.Windows.Forms.CheckBox();
            this.VolcanicsCheckBox = new System.Windows.Forms.CheckBox();
            this.VolcanicZoundsCheckBox = new System.Windows.Forms.CheckBox();
            this.RockiesCheckBox = new System.Windows.Forms.CheckBox();
            this.RockyZoundsCheckBox = new System.Windows.Forms.CheckBox();
            this.OceanicsCheckBox = new System.Windows.Forms.CheckBox();
            this.OceanicZoundsCheckBox = new System.Windows.Forms.CheckBox();
            this.MountainousCheckBox = new System.Windows.Forms.CheckBox();
            this.MountainZoundsCheckBox = new System.Windows.Forms.CheckBox();
            this.ConstructionListButton = new System.Windows.Forms.Button();
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
            // EarthlikesButton
            // 
            resources.ApplyResources(this.EarthlikesButton, "EarthlikesButton");
            this.EarthlikesButton.Name = "EarthlikesButton";
            this.EarthlikesButton.UseVisualStyleBackColor = true;
            this.EarthlikesButton.Click += new System.EventHandler(this.EarthlikesButton_Click);
            // 
            // GreenhousesButton
            // 
            resources.ApplyResources(this.GreenhousesButton, "GreenhousesButton");
            this.GreenhousesButton.Name = "GreenhousesButton";
            this.GreenhousesButton.UseVisualStyleBackColor = true;
            this.GreenhousesButton.Click += new System.EventHandler(this.GreenhousesButton_Click);
            // 
            // MountainousButton
            // 
            resources.ApplyResources(this.MountainousButton, "MountainousButton");
            this.MountainousButton.Name = "MountainousButton";
            this.MountainousButton.UseVisualStyleBackColor = true;
            this.MountainousButton.Click += new System.EventHandler(this.MountainousButton_Click);
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
            this.numberTextBox.AllowDrop = true;
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
            this.DirectorshipListButton.Click += new System.EventHandler(this.DirectorshipListButton_Click);
            // 
            // PrisonListButton
            // 
            resources.ApplyResources(this.PrisonListButton, "PrisonListButton");
            this.PrisonListButton.Name = "PrisonListButton";
            this.PrisonListButton.UseVisualStyleBackColor = true;
            this.PrisonListButton.Click += new System.EventHandler(this.PrisonListButton_Click);
            // 
            // SocialismListButton
            // 
            resources.ApplyResources(this.SocialismListButton, "SocialismListButton");
            this.SocialismListButton.Name = "SocialismListButton";
            this.SocialismListButton.UseVisualStyleBackColor = true;
            this.SocialismListButton.Click += new System.EventHandler(this.SocialismListButton_Click);
            // 
            // DemocracyListButton
            // 
            resources.ApplyResources(this.DemocracyListButton, "DemocracyListButton");
            this.DemocracyListButton.Name = "DemocracyListButton";
            this.DemocracyListButton.UseVisualStyleBackColor = true;
            this.DemocracyListButton.Click += new System.EventHandler(this.DemocracyListButton_Click);
            // 
            // NukesListButton
            // 
            resources.ApplyResources(this.NukesListButton, "NukesListButton");
            this.NukesListButton.Name = "NukesListButton";
            this.NukesListButton.UseVisualStyleBackColor = true;
            this.NukesListButton.Click += new System.EventHandler(this.NukesListButton_Click);
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
            this.SolarsListButton.Click += new System.EventHandler(this.SolarsListButton_Click);
            // 
            // LasersListButton
            // 
            resources.ApplyResources(this.LasersListButton, "LasersListButton");
            this.LasersListButton.Name = "LasersListButton";
            this.LasersListButton.UseVisualStyleBackColor = true;
            this.LasersListButton.Click += new System.EventHandler(this.LasersListButton_Click);
            // 
            // BuildListButton
            // 
            resources.ApplyResources(this.BuildListButton, "BuildListButton");
            this.BuildListButton.Name = "BuildListButton";
            this.BuildListButton.UseVisualStyleBackColor = true;
            this.BuildListButton.Click += new System.EventHandler(this.BuildListButton_Click);
            // 
            // SameSystemListButton
            // 
            resources.ApplyResources(this.SameSystemListButton, "SameSystemListButton");
            this.SameSystemListButton.Name = "SameSystemListButton";
            this.SameSystemListButton.UseVisualStyleBackColor = true;
            this.SameSystemListButton.Click += new System.EventHandler(this.SameSystemListButton_Click);
            // 
            // FindMoraleButton
            // 
            resources.ApplyResources(this.FindMoraleButton, "FindMoraleButton");
            this.FindMoraleButton.Name = "FindMoraleButton";
            this.FindMoraleButton.UseVisualStyleBackColor = true;
            this.FindMoraleButton.Click += new System.EventHandler(this.FindMoraleButton_Click);
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
            // ArcticZoundsCheckBox
            // 
            resources.ApplyResources(this.ArcticZoundsCheckBox, "ArcticZoundsCheckBox");
            this.ArcticZoundsCheckBox.Name = "ArcticZoundsCheckBox";
            this.ArcticZoundsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ArcticsCheckBox
            // 
            resources.ApplyResources(this.ArcticsCheckBox, "ArcticsCheckBox");
            this.ArcticsCheckBox.Name = "ArcticsCheckBox";
            this.ArcticsCheckBox.UseVisualStyleBackColor = true;
            // 
            // DesertsCheckBox
            // 
            resources.ApplyResources(this.DesertsCheckBox, "DesertsCheckBox");
            this.DesertsCheckBox.Name = "DesertsCheckBox";
            this.DesertsCheckBox.UseVisualStyleBackColor = true;
            // 
            // DesertZoundsCheckBox
            // 
            resources.ApplyResources(this.DesertZoundsCheckBox, "DesertZoundsCheckBox");
            this.DesertZoundsCheckBox.Name = "DesertZoundsCheckBox";
            this.DesertZoundsCheckBox.UseVisualStyleBackColor = true;
            // 
            // GreenhousesCheckBox
            // 
            resources.ApplyResources(this.GreenhousesCheckBox, "GreenhousesCheckBox");
            this.GreenhousesCheckBox.Name = "GreenhousesCheckBox";
            this.GreenhousesCheckBox.UseVisualStyleBackColor = true;
            // 
            // GreenhouseZoundsCheckBox
            // 
            resources.ApplyResources(this.GreenhouseZoundsCheckBox, "GreenhouseZoundsCheckBox");
            this.GreenhouseZoundsCheckBox.Name = "GreenhouseZoundsCheckBox";
            this.GreenhouseZoundsCheckBox.UseVisualStyleBackColor = true;
            // 
            // EarthlikesCheckBox
            // 
            resources.ApplyResources(this.EarthlikesCheckBox, "EarthlikesCheckBox");
            this.EarthlikesCheckBox.Name = "EarthlikesCheckBox";
            this.EarthlikesCheckBox.UseVisualStyleBackColor = true;
            // 
            // EarthlikeZoundsCheckBox
            // 
            resources.ApplyResources(this.EarthlikeZoundsCheckBox, "EarthlikeZoundsCheckBox");
            this.EarthlikeZoundsCheckBox.Name = "EarthlikeZoundsCheckBox";
            this.EarthlikeZoundsCheckBox.UseVisualStyleBackColor = true;
            // 
            // VolcanicsCheckBox
            // 
            resources.ApplyResources(this.VolcanicsCheckBox, "VolcanicsCheckBox");
            this.VolcanicsCheckBox.Name = "VolcanicsCheckBox";
            this.VolcanicsCheckBox.UseVisualStyleBackColor = true;
            // 
            // VolcanicZoundsCheckBox
            // 
            resources.ApplyResources(this.VolcanicZoundsCheckBox, "VolcanicZoundsCheckBox");
            this.VolcanicZoundsCheckBox.Name = "VolcanicZoundsCheckBox";
            this.VolcanicZoundsCheckBox.UseVisualStyleBackColor = true;
            // 
            // RockiesCheckBox
            // 
            resources.ApplyResources(this.RockiesCheckBox, "RockiesCheckBox");
            this.RockiesCheckBox.Name = "RockiesCheckBox";
            this.RockiesCheckBox.UseVisualStyleBackColor = true;
            // 
            // RockyZoundsCheckBox
            // 
            resources.ApplyResources(this.RockyZoundsCheckBox, "RockyZoundsCheckBox");
            this.RockyZoundsCheckBox.Name = "RockyZoundsCheckBox";
            this.RockyZoundsCheckBox.UseVisualStyleBackColor = true;
            // 
            // OceanicsCheckBox
            // 
            resources.ApplyResources(this.OceanicsCheckBox, "OceanicsCheckBox");
            this.OceanicsCheckBox.Name = "OceanicsCheckBox";
            this.OceanicsCheckBox.UseVisualStyleBackColor = true;
            // 
            // OceanicZoundsCheckBox
            // 
            resources.ApplyResources(this.OceanicZoundsCheckBox, "OceanicZoundsCheckBox");
            this.OceanicZoundsCheckBox.Name = "OceanicZoundsCheckBox";
            this.OceanicZoundsCheckBox.UseVisualStyleBackColor = true;
            // 
            // MountainousCheckBox
            // 
            resources.ApplyResources(this.MountainousCheckBox, "MountainousCheckBox");
            this.MountainousCheckBox.Name = "MountainousCheckBox";
            this.MountainousCheckBox.UseVisualStyleBackColor = true;
            // 
            // MountainZoundsCheckBox
            // 
            resources.ApplyResources(this.MountainZoundsCheckBox, "MountainZoundsCheckBox");
            this.MountainZoundsCheckBox.Name = "MountainZoundsCheckBox";
            this.MountainZoundsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ConstructionListButton
            // 
            resources.ApplyResources(this.ConstructionListButton, "ConstructionListButton");
            this.ConstructionListButton.Name = "ConstructionListButton";
            this.ConstructionListButton.UseVisualStyleBackColor = true;
            this.ConstructionListButton.Click += new System.EventHandler(this.ConstructionListButton_Click);
            // 
            // PlanetTypeForm
            // 
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.ConstructionListButton);
            this.Controls.Add(this.VolcanicsCheckBox);
            this.Controls.Add(this.VolcanicZoundsCheckBox);
            this.Controls.Add(this.RockiesCheckBox);
            this.Controls.Add(this.RockyZoundsCheckBox);
            this.Controls.Add(this.OceanicsCheckBox);
            this.Controls.Add(this.OceanicZoundsCheckBox);
            this.Controls.Add(this.MountainousCheckBox);
            this.Controls.Add(this.MountainZoundsCheckBox);
            this.Controls.Add(this.GreenhousesCheckBox);
            this.Controls.Add(this.GreenhouseZoundsCheckBox);
            this.Controls.Add(this.EarthlikesCheckBox);
            this.Controls.Add(this.EarthlikeZoundsCheckBox);
            this.Controls.Add(this.DesertsCheckBox);
            this.Controls.Add(this.DesertZoundsCheckBox);
            this.Controls.Add(this.ArcticsCheckBox);
            this.Controls.Add(this.ArcticZoundsCheckBox);
            this.Controls.Add(this.DoubleDomeListButton);
            this.Controls.Add(this.RenameListsButton);
            this.Controls.Add(this.FindMoraleButton);
            this.Controls.Add(this.SameSystemListButton);
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
            this.Controls.Add(this.MountainousButton);
            this.Controls.Add(this.GreenhousesButton);
            this.Controls.Add(this.EarthlikesButton);
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

        private CheckBox ArcticZoundsCheckBox;
        private CheckBox ArcticsCheckBox;
        private CheckBox DesertsCheckBox;
        private CheckBox DesertZoundsCheckBox;
        private CheckBox GreenhousesCheckBox;
        private CheckBox GreenhouseZoundsCheckBox;
        private CheckBox EarthlikesCheckBox;
        private CheckBox EarthlikeZoundsCheckBox;
        private CheckBox VolcanicsCheckBox;
        private CheckBox VolcanicZoundsCheckBox;
        private CheckBox RockiesCheckBox;
        private CheckBox RockyZoundsCheckBox;
        private CheckBox OceanicsCheckBox;
        private CheckBox OceanicZoundsCheckBox;
        private CheckBox MountainousCheckBox;
        private CheckBox MountainZoundsCheckBox;
        private Button ConstructionListButton;
    }//class
}//namespace