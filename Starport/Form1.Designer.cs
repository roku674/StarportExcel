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
            this.FindGrowing.Location = new System.Drawing.Point(31, 71);
            this.FindGrowing.Name = "FindGrowing";
            this.FindGrowing.Size = new System.Drawing.Size(109, 23);
            this.FindGrowing.TabIndex = 1;
            this.FindGrowing.Text = "Find Growing";
            this.FindGrowing.UseVisualStyleBackColor = true;
            this.FindGrowing.Click += new System.EventHandler(this.FindGrowing_Click);
            // 
            // CheckGrow
            // 
            this.CheckGrow.Location = new System.Drawing.Point(31, 42);
            this.CheckGrow.Name = "CheckGrow";
            this.CheckGrow.Size = new System.Drawing.Size(109, 23);
            this.CheckGrow.TabIndex = 2;
            this.CheckGrow.Text = "Check Grow";
            this.CheckGrow.UseVisualStyleBackColor = true;
            this.CheckGrow.Click += new System.EventHandler(this.CheckGrow_Click);
            // 
            // FindZounds
            // 
            this.FindZounds.Location = new System.Drawing.Point(332, 265);
            this.FindZounds.Name = "FindZounds";
            this.FindZounds.Size = new System.Drawing.Size(109, 23);
            this.FindZounds.TabIndex = 3;
            this.FindZounds.Text = "Find Zounds";
            this.FindZounds.UseVisualStyleBackColor = true;
            this.FindZounds.Click += new System.EventHandler(this.FindZounds_Click);
            // 
            // FindTotals
            // 
            this.FindTotals.Location = new System.Drawing.Point(332, 42);
            this.FindTotals.Name = "FindTotals";
            this.FindTotals.Size = new System.Drawing.Size(173, 81);
            this.FindTotals.TabIndex = 4;
            this.FindTotals.Text = "Find Totals";
            this.FindTotals.UseVisualStyleBackColor = true;
            this.FindTotals.Click += new System.EventHandler(this.FindTotals_Click);
            // 
            // FindNeedsDefense
            // 
            this.FindNeedsDefense.Location = new System.Drawing.Point(31, 100);
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
            this.itsMyWindow.Size = new System.Drawing.Size(235, 20);
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
            this.ClearZounds.Location = new System.Drawing.Point(469, 237);
            this.ClearZounds.Name = "ClearZounds";
            this.ClearZounds.Size = new System.Drawing.Size(109, 23);
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
            this.ReplacePlanet.Text = "Replace";
            this.ReplacePlanet.UseVisualStyleBackColor = true;
            this.ReplacePlanet.Click += new System.EventHandler(this.ReplacePlanet_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(590, 434);
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
    }
}

