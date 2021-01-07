using System;
using System.Windows.Forms;

namespace StarportExcel
{
    partial class PlanetTypeForm
    {
        private Button Arctics;
        private Button Deserts;
        private Button Earths;
        private Button Greenhouses;
        private Button Mountains;
        private Button Oceanics;
        private Button Paradises;
        private Button Rockies;
        private Button Volcanics;

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
            this.Arctics = new System.Windows.Forms.Button();
            this.Deserts = new System.Windows.Forms.Button();
            this.Earths = new System.Windows.Forms.Button();
            this.Greenhouses = new System.Windows.Forms.Button();
            this.Mountains = new System.Windows.Forms.Button();
            this.Oceanics = new System.Windows.Forms.Button();
            this.Paradises = new System.Windows.Forms.Button();
            this.Rockies = new System.Windows.Forms.Button();
            this.Volcanics = new System.Windows.Forms.Button();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.NeedsDefenses = new System.Windows.Forms.Button();
            this.Growing = new System.Windows.Forms.Button();
            this.ClearOutput = new System.Windows.Forms.Button();
            this.LineBreak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Arctics
            // 
            resources.ApplyResources(this.Arctics, "Arctics");
            this.Arctics.Name = "Arctics";
            this.Arctics.UseVisualStyleBackColor = true;
            this.Arctics.Click += new System.EventHandler(this.Arctics_Click);
            // 
            // Deserts
            // 
            resources.ApplyResources(this.Deserts, "Deserts");
            this.Deserts.Name = "Deserts";
            this.Deserts.UseVisualStyleBackColor = true;
            this.Deserts.Click += new System.EventHandler(this.Deserts_Click);
            // 
            // Earths
            // 
            resources.ApplyResources(this.Earths, "Earths");
            this.Earths.Name = "Earths";
            this.Earths.UseVisualStyleBackColor = true;
            this.Earths.Click += new System.EventHandler(this.Earths_Click);
            // 
            // Greenhouses
            // 
            resources.ApplyResources(this.Greenhouses, "Greenhouses");
            this.Greenhouses.Name = "Greenhouses";
            this.Greenhouses.UseVisualStyleBackColor = true;
            this.Greenhouses.Click += new System.EventHandler(this.Greenhouses_Click);
            // 
            // Mountains
            // 
            resources.ApplyResources(this.Mountains, "Mountains");
            this.Mountains.Name = "Mountains";
            this.Mountains.UseVisualStyleBackColor = true;
            this.Mountains.Click += new System.EventHandler(this.Mountains_Click);
            // 
            // Oceanics
            // 
            resources.ApplyResources(this.Oceanics, "Oceanics");
            this.Oceanics.Name = "Oceanics";
            this.Oceanics.UseVisualStyleBackColor = true;
            this.Oceanics.Click += new System.EventHandler(this.Oceanics_Click);
            // 
            // Paradises
            // 
            resources.ApplyResources(this.Paradises, "Paradises");
            this.Paradises.Name = "Paradises";
            this.Paradises.UseVisualStyleBackColor = true;
            this.Paradises.Click += new System.EventHandler(this.Paradises_Click);
            // 
            // Rockies
            // 
            resources.ApplyResources(this.Rockies, "Rockies");
            this.Rockies.Name = "Rockies";
            this.Rockies.UseVisualStyleBackColor = true;
            this.Rockies.Click += new System.EventHandler(this.Rockies_Click);
            // 
            // Volcanics
            // 
            resources.ApplyResources(this.Volcanics, "Volcanics");
            this.Volcanics.Name = "Volcanics";
            this.Volcanics.UseVisualStyleBackColor = true;
            this.Volcanics.Click += new System.EventHandler(this.Volcanics_Click);
            // 
            // numberBox
            // 
            resources.ApplyResources(this.numberBox, "numberBox");
            this.numberBox.Name = "numberBox";
            // 
            // NeedsDefenses
            // 
            resources.ApplyResources(this.NeedsDefenses, "NeedsDefenses");
            this.NeedsDefenses.Name = "NeedsDefenses";
            this.NeedsDefenses.UseVisualStyleBackColor = true;
            this.NeedsDefenses.Click += new System.EventHandler(this.NeedsDefenses_Click);
            // 
            // Growing
            // 
            resources.ApplyResources(this.Growing, "Growing");
            this.Growing.Name = "Growing";
            this.Growing.UseVisualStyleBackColor = true;
            this.Growing.Click += new System.EventHandler(this.Growing_Click);
            // 
            // ClearOutput
            // 
            resources.ApplyResources(this.ClearOutput, "ClearOutput");
            this.ClearOutput.Name = "ClearOutput";
            this.ClearOutput.UseVisualStyleBackColor = true;
            this.ClearOutput.Click += new System.EventHandler(this.ClearOutput_Click);
            // 
            // LineBreak
            // 
            resources.ApplyResources(this.LineBreak, "LineBreak");
            this.LineBreak.Name = "LineBreak";
            this.LineBreak.UseVisualStyleBackColor = true;
            this.LineBreak.Click += new System.EventHandler(this.LineBreak_Click);
            // 
            // PlanetTypeForm
            // 
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.LineBreak);
            this.Controls.Add(this.ClearOutput);
            this.Controls.Add(this.Growing);
            this.Controls.Add(this.NeedsDefenses);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.Volcanics);
            this.Controls.Add(this.Rockies);
            this.Controls.Add(this.Paradises);
            this.Controls.Add(this.Oceanics);
            this.Controls.Add(this.Mountains);
            this.Controls.Add(this.Greenhouses);
            this.Controls.Add(this.Earths);
            this.Controls.Add(this.Deserts);
            this.Controls.Add(this.Arctics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "PlanetTypeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlanetTypeForm_FormClosing);
            this.Load += new System.EventHandler(this.PlanetTypeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        } //init

        private System.Windows.Forms.TextBox numberBox;
        private Button NeedsDefenses;
        private Button Growing;
        private Button ClearOutput;
        private Button LineBreak;
    }//class
}//namespace