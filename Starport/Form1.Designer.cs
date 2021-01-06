using System;

namespace StarportExcel
{
    partial class Form1 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CreateQuote = new System.Windows.Forms.Button();
            this.FindGrowing = new System.Windows.Forms.Button();
            this.CheckGrow = new System.Windows.Forms.Button();
            this.FindZounds = new System.Windows.Forms.Button();
            this.FindTotals = new System.Windows.Forms.Button();
            this.FindNeedsDefense = new System.Windows.Forms.Button();
            this.CheckParenthesis = new System.Windows.Forms.Button();
            this.PlanetOrganizer = new System.Windows.Forms.TextBox();
            this.itsMyWindow = new System.Windows.Forms.TextBox();
            this.PlanetSorter = new System.Windows.Forms.Button();
            this.ClearZounds = new System.Windows.Forms.Button();
            this.ReplacePlanet = new System.Windows.Forms.Button();
            this.ReturnPlanet = new System.Windows.Forms.Button();
            this.ClearNeedsDefense = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewFileToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.OpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PrintToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.HelpMeNiggaDamnToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateQuote
            // 
            this.CreateQuote.Location = new System.Drawing.Point(332, 359);
            this.CreateQuote.Name = "CreateQuote";
            this.CreateQuote.Size = new System.Drawing.Size(109, 23);
            this.CreateQuote.TabIndex = 0;
            this.CreateQuote.Text = "Create Quote";
            this.CreateQuote.UseVisualStyleBackColor = true;
            this.CreateQuote.Click += new System.EventHandler(this.CreateQuote_Click);
            // 
            // FindGrowing
            // 
            this.FindGrowing.Location = new System.Drawing.Point(31, 42);
            this.FindGrowing.Name = "FindGrowing";
            this.FindGrowing.Size = new System.Drawing.Size(109, 23);
            this.FindGrowing.TabIndex = 1;
            this.FindGrowing.Text = "Find Growing";
            this.FindGrowing.UseVisualStyleBackColor = true;
            this.FindGrowing.Click += new System.EventHandler(this.FindGrowing_Click);
            // 
            // CheckGrow
            // 
            this.CheckGrow.Location = new System.Drawing.Point(146, 41);
            this.CheckGrow.Name = "CheckGrow";
            this.CheckGrow.Size = new System.Drawing.Size(110, 23);
            this.CheckGrow.TabIndex = 2;
            this.CheckGrow.Text = "Check Grow";
            this.CheckGrow.UseVisualStyleBackColor = true;
            this.CheckGrow.Click += new System.EventHandler(this.CheckGrow_Click);
            // 
            // FindZounds
            // 
            this.FindZounds.Location = new System.Drawing.Point(32, 100);
            this.FindZounds.Name = "FindZounds";
            this.FindZounds.Size = new System.Drawing.Size(108, 23);
            this.FindZounds.TabIndex = 3;
            this.FindZounds.Text = "Find Zounds";
            this.FindZounds.UseVisualStyleBackColor = true;
            this.FindZounds.Click += new System.EventHandler(this.FindZounds_Click);
            // 
            // FindTotals
            // 
            this.FindTotals.Location = new System.Drawing.Point(332, 42);
            this.FindTotals.Name = "FindTotals";
            this.FindTotals.Size = new System.Drawing.Size(246, 105);
            this.FindTotals.TabIndex = 4;
            this.FindTotals.Text = "Find Totals";
            this.FindTotals.UseVisualStyleBackColor = true;
            this.FindTotals.Click += new System.EventHandler(this.FindTotals_Click);
            // 
            // FindNeedsDefense
            // 
            this.FindNeedsDefense.Location = new System.Drawing.Point(32, 70);
            this.FindNeedsDefense.Name = "FindNeedsDefense";
            this.FindNeedsDefense.Size = new System.Drawing.Size(109, 23);
            this.FindNeedsDefense.TabIndex = 6;
            this.FindNeedsDefense.Text = "Find Needs Defense";
            this.FindNeedsDefense.UseVisualStyleBackColor = true;
            this.FindNeedsDefense.Click += new System.EventHandler(this.FindNeedsDefense_Click);
            // 
            // CheckParenthesis
            // 
            this.CheckParenthesis.Location = new System.Drawing.Point(469, 199);
            this.CheckParenthesis.Name = "CheckParenthesis";
            this.CheckParenthesis.Size = new System.Drawing.Size(109, 23);
            this.CheckParenthesis.TabIndex = 7;
            this.CheckParenthesis.Text = "Check Parenthesis";
            this.CheckParenthesis.UseVisualStyleBackColor = true;
            this.CheckParenthesis.Click += new System.EventHandler(this.CheckParenthesis_Click);
            // 
            // PlanetOrganizer
            // 
            this.PlanetOrganizer.Location = new System.Drawing.Point(332, 173);
            this.PlanetOrganizer.Name = "PlanetOrganizer";
            this.PlanetOrganizer.Size = new System.Drawing.Size(246, 20);
            this.PlanetOrganizer.TabIndex = 8;
            this.PlanetOrganizer.Text = "Insert Planet Name";
            // 
            // itsMyWindow
            // 
            this.itsMyWindow.Location = new System.Drawing.Point(332, 333);
            this.itsMyWindow.Name = "itsMyWindow";
            this.itsMyWindow.Size = new System.Drawing.Size(246, 20);
            this.itsMyWindow.TabIndex = 9;
            // 
            // PlanetSorter
            // 
            this.PlanetSorter.Location = new System.Drawing.Point(332, 199);
            this.PlanetSorter.Name = "PlanetSorter";
            this.PlanetSorter.Size = new System.Drawing.Size(109, 23);
            this.PlanetSorter.TabIndex = 10;
            this.PlanetSorter.Text = "Sort Planet";
            this.PlanetSorter.UseVisualStyleBackColor = true;
            this.PlanetSorter.Click += new System.EventHandler(this.PlanetSorter_Click);
            // 
            // ClearZounds
            // 
            this.ClearZounds.Location = new System.Drawing.Point(146, 100);
            this.ClearZounds.Name = "ClearZounds";
            this.ClearZounds.Size = new System.Drawing.Size(110, 23);
            this.ClearZounds.TabIndex = 11;
            this.ClearZounds.Text = "Clear Zounds";
            this.ClearZounds.UseVisualStyleBackColor = true;
            this.ClearZounds.Click += new System.EventHandler(this.ClearZounds_Click);
            // 
            // ReplacePlanet
            // 
            this.ReplacePlanet.Location = new System.Drawing.Point(332, 228);
            this.ReplacePlanet.Name = "ReplacePlanet";
            this.ReplacePlanet.Size = new System.Drawing.Size(109, 23);
            this.ReplacePlanet.TabIndex = 12;
            this.ReplacePlanet.Text = "Replace Planet";
            this.ReplacePlanet.UseVisualStyleBackColor = true;
            this.ReplacePlanet.Click += new System.EventHandler(this.ReplacePlanet_Click);
            // 
            // ReturnPlanet
            // 
            this.ReturnPlanet.Location = new System.Drawing.Point(332, 257);
            this.ReturnPlanet.Name = "ReturnPlanet";
            this.ReturnPlanet.Size = new System.Drawing.Size(109, 23);
            this.ReturnPlanet.TabIndex = 13;
            this.ReturnPlanet.Text = "Return Planet";
            this.ReturnPlanet.UseVisualStyleBackColor = true;
            this.ReturnPlanet.Click += new System.EventHandler(this.ReturnPlanet_Click);
            // 
            // ClearNeedsDefense
            // 
            this.ClearNeedsDefense.Location = new System.Drawing.Point(147, 70);
            this.ClearNeedsDefense.Name = "ClearNeedsDefense";
            this.ClearNeedsDefense.Size = new System.Drawing.Size(109, 23);
            this.ClearNeedsDefense.TabIndex = 14;
            this.ClearNeedsDefense.Text = "Clear ND";
            this.ClearNeedsDefense.UseVisualStyleBackColor = true;
            this.ClearNeedsDefense.Click += new System.EventHandler(this.ClearNeedsDefense_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFileToolStripButton,
            this.OpenToolStripButton,
            this.SaveToolStripButton,
            this.PrintToolStripButton,
            this.toolStripSeparator,
            this.copyToolStripButton,
            this.toolStripSeparator1,
            this.HelpMeNiggaDamnToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(590, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NewFileToolStripButton
            // 
            this.NewFileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewFileToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NewFileToolStripButton.Image")));
            this.NewFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewFileToolStripButton.Name = "NewFileToolStripButton";
            this.NewFileToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.NewFileToolStripButton.Text = "&New";
            this.NewFileToolStripButton.Click += new System.EventHandler(this.NewFileToolStripButton_Click);
            // 
            // OpenToolStripButton
            // 
            this.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripButton.Image")));
            this.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripButton.Name = "OpenToolStripButton";
            this.OpenToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.OpenToolStripButton.Text = "&Open";
            this.OpenToolStripButton.Click += new System.EventHandler(this.OpenToolStripButton_Click);
            // 
            // SaveToolStripButton
            // 
            this.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripButton.Image")));
            this.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripButton.Name = "SaveToolStripButton";
            this.SaveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.SaveToolStripButton.Text = "&Save";
            // 
            // PrintToolStripButton
            // 
            this.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("PrintToolStripButton.Image")));
            this.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintToolStripButton.Name = "PrintToolStripButton";
            this.PrintToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.PrintToolStripButton.Text = "&Print";
            this.PrintToolStripButton.Click += new System.EventHandler(this.PrintToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // HelpMeNiggaDamnToolStripButton
            // 
            this.HelpMeNiggaDamnToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HelpMeNiggaDamnToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("HelpMeNiggaDamnToolStripButton.Image")));
            this.HelpMeNiggaDamnToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpMeNiggaDamnToolStripButton.Name = "HelpMeNiggaDamnToolStripButton";
            this.HelpMeNiggaDamnToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.HelpMeNiggaDamnToolStripButton.Text = "He&lp";
            this.HelpMeNiggaDamnToolStripButton.Click += new System.EventHandler(this.HelpMeNiggaDamnToolStripButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(590, 434);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ClearNeedsDefense);
            this.Controls.Add(this.ReturnPlanet);
            this.Controls.Add(this.ReplacePlanet);
            this.Controls.Add(this.ClearZounds);
            this.Controls.Add(this.PlanetSorter);
            this.Controls.Add(this.itsMyWindow);
            this.Controls.Add(this.PlanetOrganizer);
            this.Controls.Add(this.CheckParenthesis);
            this.Controls.Add(this.FindNeedsDefense);
            this.Controls.Add(this.FindTotals);
            this.Controls.Add(this.FindZounds);
            this.Controls.Add(this.CheckGrow);
            this.Controls.Add(this.FindGrowing);
            this.Controls.Add(this.CreateQuote);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button CreateQuote;
        private System.Windows.Forms.Button FindGrowing;
        private System.Windows.Forms.Button CheckGrow;
        private System.Windows.Forms.Button FindZounds;
        private System.Windows.Forms.Button FindTotals;
        private System.Windows.Forms.Button FindNeedsDefense;
        private System.Windows.Forms.Button CheckParenthesis;
        private System.Windows.Forms.TextBox PlanetOrganizer;
        private System.Windows.Forms.TextBox itsMyWindow;
        private System.Windows.Forms.Button PlanetSorter;
        private System.Windows.Forms.Button ClearZounds;
        private System.Windows.Forms.Button ReplacePlanet;
        private System.Windows.Forms.Button ReturnPlanet;
        private System.Windows.Forms.Button ClearNeedsDefense;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewFileToolStripButton;
        private System.Windows.Forms.ToolStripButton OpenToolStripButton;
        private System.Windows.Forms.ToolStripButton SaveToolStripButton;
        private System.Windows.Forms.ToolStripButton PrintToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton HelpMeNiggaDamnToolStripButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

