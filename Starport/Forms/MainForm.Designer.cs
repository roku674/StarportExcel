using System;

namespace StarportExcel
{
    partial class MainForm 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CreateQuoteButton = new System.Windows.Forms.Button();
            this.FindGrowingButton = new System.Windows.Forms.Button();
            this.CheckGrowButton = new System.Windows.Forms.Button();
            this.FindZoundsButton = new System.Windows.Forms.Button();
            this.FindTotalsButton = new System.Windows.Forms.Button();
            this.FindNeedsDefenseButton = new System.Windows.Forms.Button();
            this.CheckParenthesisButton = new System.Windows.Forms.Button();
            this.PlanetOrganizerTextBox = new System.Windows.Forms.TextBox();
            this.itsMyWindowTextBox = new System.Windows.Forms.TextBox();
            this.ClearZoundsButton = new System.Windows.Forms.Button();
            this.ReplacePlanetButton = new System.Windows.Forms.Button();
            this.ReturnPlanetButton = new System.Windows.Forms.Button();
            this.ClearNeedsDefenseButton = new System.Windows.Forms.Button();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparatorMain = new System.Windows.Forms.ToolStripSeparator();
            this.ClearGrowButton = new System.Windows.Forms.Button();
            this.CheckNDButton = new System.Windows.Forms.Button();
            this.SortDefensesBySystemButton = new System.Windows.Forms.Button();
            this.SortGrowingBySystemButton = new System.Windows.Forms.Button();
            this.FindBuildsButton = new System.Windows.Forms.Button();
            this.FindDeconstructButton = new System.Windows.Forms.Button();
            this.FindColonialInfoButton = new System.Windows.Forms.Button();
            this.OpenToolStripButtonMain = new System.Windows.Forms.ToolStripButton();
            this.SaveToolStripButtonMain = new System.Windows.Forms.ToolStripButton();
            this.PrintToolStripButtonMain = new System.Windows.Forms.ToolStripButton();
            this.CopyToolStripButtonMain = new System.Windows.Forms.ToolStripButton();
            this.HelpMeNiggaDamnToolStripButtonMain = new System.Windows.Forms.ToolStripButton();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateQuoteButton
            // 
            resources.ApplyResources(this.CreateQuoteButton, "CreateQuoteButton");
            this.CreateQuoteButton.Name = "CreateQuoteButton";
            this.CreateQuoteButton.UseVisualStyleBackColor = true;
            this.CreateQuoteButton.Click += new System.EventHandler(this.CreateQuote_Click);
            // 
            // FindGrowingButton
            // 
            resources.ApplyResources(this.FindGrowingButton, "FindGrowingButton");
            this.FindGrowingButton.Name = "FindGrowingButton";
            this.FindGrowingButton.UseVisualStyleBackColor = true;
            this.FindGrowingButton.Click += new System.EventHandler(this.FindGrowing_Click);
            // 
            // CheckGrowButton
            // 
            resources.ApplyResources(this.CheckGrowButton, "CheckGrowButton");
            this.CheckGrowButton.Name = "CheckGrowButton";
            this.CheckGrowButton.UseVisualStyleBackColor = true;
            this.CheckGrowButton.Click += new System.EventHandler(this.CheckGrow_Click);
            // 
            // FindZoundsButton
            // 
            resources.ApplyResources(this.FindZoundsButton, "FindZoundsButton");
            this.FindZoundsButton.Name = "FindZoundsButton";
            this.FindZoundsButton.UseVisualStyleBackColor = true;
            this.FindZoundsButton.Click += new System.EventHandler(this.FindZounds_Click);
            // 
            // FindTotalsButton
            // 
            resources.ApplyResources(this.FindTotalsButton, "FindTotalsButton");
            this.FindTotalsButton.Name = "FindTotalsButton";
            this.FindTotalsButton.UseVisualStyleBackColor = true;
            this.FindTotalsButton.Click += new System.EventHandler(this.FindTotals_Click);
            // 
            // FindNeedsDefenseButton
            // 
            resources.ApplyResources(this.FindNeedsDefenseButton, "FindNeedsDefenseButton");
            this.FindNeedsDefenseButton.Name = "FindNeedsDefenseButton";
            this.FindNeedsDefenseButton.UseVisualStyleBackColor = true;
            this.FindNeedsDefenseButton.Click += new System.EventHandler(this.FindNeedsDefense_Click);
            // 
            // CheckParenthesisButton
            // 
            resources.ApplyResources(this.CheckParenthesisButton, "CheckParenthesisButton");
            this.CheckParenthesisButton.Name = "CheckParenthesisButton";
            this.CheckParenthesisButton.UseVisualStyleBackColor = true;
            this.CheckParenthesisButton.Click += new System.EventHandler(this.CheckParenthesis_Click);
            // 
            // PlanetOrganizerTextBox
            // 
            resources.ApplyResources(this.PlanetOrganizerTextBox, "PlanetOrganizerTextBox");
            this.PlanetOrganizerTextBox.Name = "PlanetOrganizerTextBox";
            // 
            // itsMyWindowTextBox
            // 
            resources.ApplyResources(this.itsMyWindowTextBox, "itsMyWindowTextBox");
            this.itsMyWindowTextBox.Name = "itsMyWindowTextBox";
            // 
            // ClearZoundsButton
            // 
            resources.ApplyResources(this.ClearZoundsButton, "ClearZoundsButton");
            this.ClearZoundsButton.Name = "ClearZoundsButton";
            this.ClearZoundsButton.UseVisualStyleBackColor = true;
            this.ClearZoundsButton.Click += new System.EventHandler(this.ClearZounds_Click);
            // 
            // ReplacePlanetButton
            // 
            resources.ApplyResources(this.ReplacePlanetButton, "ReplacePlanetButton");
            this.ReplacePlanetButton.Name = "ReplacePlanetButton";
            this.ReplacePlanetButton.UseVisualStyleBackColor = true;
            this.ReplacePlanetButton.Click += new System.EventHandler(this.ReplacePlanet_Click);
            // 
            // ReturnPlanetButton
            // 
            resources.ApplyResources(this.ReturnPlanetButton, "ReturnPlanetButton");
            this.ReturnPlanetButton.Name = "ReturnPlanetButton";
            this.ReturnPlanetButton.UseVisualStyleBackColor = true;
            this.ReturnPlanetButton.Click += new System.EventHandler(this.ReturnPlanet_Click);
            // 
            // ClearNeedsDefenseButton
            // 
            resources.ApplyResources(this.ClearNeedsDefenseButton, "ClearNeedsDefenseButton");
            this.ClearNeedsDefenseButton.Name = "ClearNeedsDefenseButton";
            this.ClearNeedsDefenseButton.UseVisualStyleBackColor = true;
            this.ClearNeedsDefenseButton.Click += new System.EventHandler(this.ClearNeedsDefense_Click);
            // 
            // toolStripMain
            // 
            resources.ApplyResources(this.toolStripMain, "toolStripMain");
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripButtonMain,
            this.SaveToolStripButtonMain,
            this.PrintToolStripButtonMain,
            this.toolStripSeparator,
            this.CopyToolStripButtonMain,
            this.toolStripSeparatorMain,
            this.HelpMeNiggaDamnToolStripButtonMain});
            this.toolStripMain.Name = "toolStripMain";
            // 
            // toolStripSeparator
            // 
            resources.ApplyResources(this.toolStripSeparator, "toolStripSeparator");
            this.toolStripSeparator.Name = "toolStripSeparator";
            // 
            // toolStripSeparatorMain
            // 
            resources.ApplyResources(this.toolStripSeparatorMain, "toolStripSeparatorMain");
            this.toolStripSeparatorMain.Name = "toolStripSeparatorMain";
            // 
            // ClearGrowButton
            // 
            resources.ApplyResources(this.ClearGrowButton, "ClearGrowButton");
            this.ClearGrowButton.Name = "ClearGrowButton";
            this.ClearGrowButton.UseVisualStyleBackColor = true;
            this.ClearGrowButton.Click += new System.EventHandler(this.ClearGrow_Click);
            // 
            // CheckNDButton
            // 
            resources.ApplyResources(this.CheckNDButton, "CheckNDButton");
            this.CheckNDButton.Name = "CheckNDButton";
            this.CheckNDButton.UseVisualStyleBackColor = true;
            this.CheckNDButton.Click += new System.EventHandler(this.CheckND_Click);
            // 
            // SortDefensesBySystemButton
            // 
            resources.ApplyResources(this.SortDefensesBySystemButton, "SortDefensesBySystemButton");
            this.SortDefensesBySystemButton.Name = "SortDefensesBySystemButton";
            this.SortDefensesBySystemButton.UseVisualStyleBackColor = true;
            this.SortDefensesBySystemButton.Click += new System.EventHandler(this.SortDefensesBySystem_Click);
            // 
            // SortGrowingBySystemButton
            // 
            resources.ApplyResources(this.SortGrowingBySystemButton, "SortGrowingBySystemButton");
            this.SortGrowingBySystemButton.Name = "SortGrowingBySystemButton";
            this.SortGrowingBySystemButton.UseVisualStyleBackColor = true;
            this.SortGrowingBySystemButton.Click += new System.EventHandler(this.SortGrowingBySystem_Click);
            // 
            // FindBuildsButton
            // 
            resources.ApplyResources(this.FindBuildsButton, "FindBuildsButton");
            this.FindBuildsButton.Name = "FindBuildsButton";
            this.FindBuildsButton.UseVisualStyleBackColor = true;
            // 
            // FindDeconstructButton
            // 
            resources.ApplyResources(this.FindDeconstructButton, "FindDeconstructButton");
            this.FindDeconstructButton.Name = "FindDeconstructButton";
            this.FindDeconstructButton.UseVisualStyleBackColor = true;
            // 
            // FindColonialInfoButton
            // 
            resources.ApplyResources(this.FindColonialInfoButton, "FindColonialInfoButton");
            this.FindColonialInfoButton.Name = "FindColonialInfoButton";
            this.FindColonialInfoButton.UseVisualStyleBackColor = true;
            // 
            // OpenToolStripButtonMain
            // 
            resources.ApplyResources(this.OpenToolStripButtonMain, "OpenToolStripButtonMain");
            this.OpenToolStripButtonMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenToolStripButtonMain.Name = "OpenToolStripButtonMain";
            this.OpenToolStripButtonMain.Click += new System.EventHandler(this.OpenToolStripButtonMain_Click);
            // 
            // SaveToolStripButtonMain
            // 
            resources.ApplyResources(this.SaveToolStripButtonMain, "SaveToolStripButtonMain");
            this.SaveToolStripButtonMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveToolStripButtonMain.Name = "SaveToolStripButtonMain";
            this.SaveToolStripButtonMain.Click += new System.EventHandler(this.SaveToolStripButtonMain_Click);
            // 
            // PrintToolStripButtonMain
            // 
            resources.ApplyResources(this.PrintToolStripButtonMain, "PrintToolStripButtonMain");
            this.PrintToolStripButtonMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintToolStripButtonMain.Name = "PrintToolStripButtonMain";
            this.PrintToolStripButtonMain.Click += new System.EventHandler(this.PrintToolStripButtonMain_Click);
            // 
            // CopyToolStripButtonMain
            // 
            resources.ApplyResources(this.CopyToolStripButtonMain, "CopyToolStripButtonMain");
            this.CopyToolStripButtonMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopyToolStripButtonMain.Name = "CopyToolStripButtonMain";
            // 
            // HelpMeNiggaDamnToolStripButtonMain
            // 
            resources.ApplyResources(this.HelpMeNiggaDamnToolStripButtonMain, "HelpMeNiggaDamnToolStripButtonMain");
            this.HelpMeNiggaDamnToolStripButtonMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HelpMeNiggaDamnToolStripButtonMain.Name = "HelpMeNiggaDamnToolStripButtonMain";
            this.HelpMeNiggaDamnToolStripButtonMain.Click += new System.EventHandler(this.HelpMeNiggaDamnToolStripButtonMain_Click);
            // 
            // pictureBoxMain
            // 
            resources.ApplyResources(this.pictureBoxMain, "pictureBoxMain");
            this.pictureBoxMain.Image = global::StarportExcel.Properties.Resources.StarDockMatte;
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.TabStop = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.FindColonialInfoButton);
            this.Controls.Add(this.FindDeconstructButton);
            this.Controls.Add(this.FindBuildsButton);
            this.Controls.Add(this.SortGrowingBySystemButton);
            this.Controls.Add(this.SortDefensesBySystemButton);
            this.Controls.Add(this.CheckNDButton);
            this.Controls.Add(this.ClearGrowButton);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.ClearNeedsDefenseButton);
            this.Controls.Add(this.ReturnPlanetButton);
            this.Controls.Add(this.ReplacePlanetButton);
            this.Controls.Add(this.ClearZoundsButton);
            this.Controls.Add(this.itsMyWindowTextBox);
            this.Controls.Add(this.PlanetOrganizerTextBox);
            this.Controls.Add(this.CheckParenthesisButton);
            this.Controls.Add(this.FindNeedsDefenseButton);
            this.Controls.Add(this.FindTotalsButton);
            this.Controls.Add(this.FindZoundsButton);
            this.Controls.Add(this.CheckGrowButton);
            this.Controls.Add(this.FindGrowingButton);
            this.Controls.Add(this.CreateQuoteButton);
            this.Controls.Add(this.pictureBoxMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateQuoteButton;
        private System.Windows.Forms.Button FindGrowingButton;
        private System.Windows.Forms.Button CheckGrowButton;
        private System.Windows.Forms.Button FindZoundsButton;
        private System.Windows.Forms.Button FindTotalsButton;
        private System.Windows.Forms.Button FindNeedsDefenseButton;
        private System.Windows.Forms.Button CheckParenthesisButton;
        private System.Windows.Forms.TextBox PlanetOrganizerTextBox;
        private System.Windows.Forms.TextBox itsMyWindowTextBox;
        private System.Windows.Forms.Button ClearZoundsButton;
        private System.Windows.Forms.Button ReplacePlanetButton;
        private System.Windows.Forms.Button ReturnPlanetButton;
        private System.Windows.Forms.Button ClearNeedsDefenseButton;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton OpenToolStripButtonMain;
        private System.Windows.Forms.ToolStripButton SaveToolStripButtonMain;
        private System.Windows.Forms.ToolStripButton PrintToolStripButtonMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton CopyToolStripButtonMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorMain;
        private System.Windows.Forms.ToolStripButton HelpMeNiggaDamnToolStripButtonMain;
        private System.Windows.Forms.Button ClearGrowButton;
        private System.Windows.Forms.Button CheckNDButton;
        private System.Windows.Forms.Button SortDefensesBySystemButton;
        private System.Windows.Forms.Button SortGrowingBySystemButton;
        private System.Windows.Forms.Button FindBuildsButton;
        private System.Windows.Forms.Button FindDeconstructButton;
        private System.Windows.Forms.Button FindColonialInfoButton;
        private System.Windows.Forms.PictureBox pictureBoxMain;
    }
}

