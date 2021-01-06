using System;
using System.Windows.Forms;

namespace StarportExcel
{
    partial class GetPlanetByTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetPlanetByTypeForm));
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
            this.SuspendLayout();
            // 
            // Arctics
            // 
            this.Arctics.Location = new System.Drawing.Point(12, 41);
            this.Arctics.Name = "Arctics";
            this.Arctics.Size = new System.Drawing.Size(109, 24);
            this.Arctics.TabIndex = 0;
            this.Arctics.Text = "Arctics";
            this.Arctics.UseVisualStyleBackColor = true;
            this.Arctics.Click += new System.EventHandler(this.Arctics_Click);
            // 
            // Deserts
            // 
            this.Deserts.Location = new System.Drawing.Point(127, 41);
            this.Deserts.Name = "Deserts";
            this.Deserts.Size = new System.Drawing.Size(109, 24);
            this.Deserts.TabIndex = 1;
            this.Deserts.Text = "Deserts";
            this.Deserts.UseVisualStyleBackColor = true;
            this.Deserts.Click += new System.EventHandler(this.Deserts_Click);
            // 
            // Earths
            // 
            this.Earths.Location = new System.Drawing.Point(242, 41);
            this.Earths.Name = "Earths";
            this.Earths.Size = new System.Drawing.Size(109, 24);
            this.Earths.TabIndex = 2;
            this.Earths.Text = "Earths";
            this.Earths.UseVisualStyleBackColor = true;
            this.Earths.Click += new System.EventHandler(this.Earths_Click);
            // 
            // Greenhouses
            // 
            this.Greenhouses.Location = new System.Drawing.Point(357, 41);
            this.Greenhouses.Name = "Greenhouses";
            this.Greenhouses.Size = new System.Drawing.Size(109, 24);
            this.Greenhouses.TabIndex = 3;
            this.Greenhouses.Text = "Greenhouses";
            this.Greenhouses.UseVisualStyleBackColor = true;
            this.Greenhouses.Click += new System.EventHandler(this.Greenhouses_Click);
            // 
            // Mountains
            // 
            this.Mountains.Location = new System.Drawing.Point(12, 71);
            this.Mountains.Name = "Mountains";
            this.Mountains.Size = new System.Drawing.Size(109, 24);
            this.Mountains.TabIndex = 4;
            this.Mountains.Text = "Mountains";
            this.Mountains.UseVisualStyleBackColor = true;
            this.Mountains.Click += new System.EventHandler(this.Mountains_Click);
            // 
            // Oceanics
            // 
            this.Oceanics.Location = new System.Drawing.Point(127, 71);
            this.Oceanics.Name = "Oceanics";
            this.Oceanics.Size = new System.Drawing.Size(109, 24);
            this.Oceanics.TabIndex = 5;
            this.Oceanics.Text = "Oceanics";
            this.Oceanics.UseVisualStyleBackColor = true;
            this.Oceanics.Click += new System.EventHandler(this.Oceanics_Click);
            // 
            // Paradises
            // 
            this.Paradises.Location = new System.Drawing.Point(12, 101);
            this.Paradises.Name = "Paradises";
            this.Paradises.Size = new System.Drawing.Size(454, 51);
            this.Paradises.TabIndex = 6;
            this.Paradises.Text = "Paradises";
            this.Paradises.UseVisualStyleBackColor = true;
            this.Paradises.Click += new System.EventHandler(this.Paradises_Click);
            // 
            // Rockies
            // 
            this.Rockies.Location = new System.Drawing.Point(242, 71);
            this.Rockies.Name = "Rockies";
            this.Rockies.Size = new System.Drawing.Size(109, 24);
            this.Rockies.TabIndex = 7;
            this.Rockies.Text = "Rockies";
            this.Rockies.UseVisualStyleBackColor = true;
            this.Rockies.Click += new System.EventHandler(this.Rockies_Click);
            // 
            // Volcanics
            // 
            this.Volcanics.Location = new System.Drawing.Point(357, 71);
            this.Volcanics.Name = "Volcanics";
            this.Volcanics.Size = new System.Drawing.Size(109, 24);
            this.Volcanics.TabIndex = 8;
            this.Volcanics.Text = "Volcanics";
            this.Volcanics.UseVisualStyleBackColor = true;
            this.Volcanics.Click += new System.EventHandler(this.Volcanics_Click);
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(12, 12);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(454, 20);
            this.numberBox.TabIndex = 9;
            this.numberBox.Text = "Insert Planet Number here then press the planet type Button.";
            // 
            // CustomMessageBox
            // 
            this.ClientSize = new System.Drawing.Size(487, 164);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CustomMessageBox";
            this.Load += new System.EventHandler(this.CustomMessageBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        } //init

        private System.Windows.Forms.TextBox numberBox;
    }//class
}//namespace