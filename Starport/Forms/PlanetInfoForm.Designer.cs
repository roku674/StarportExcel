
namespace StarportExcel
{
    partial class PlanetInfoForm
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
            this.InfoBox = new System.Windows.Forms.RichTextBox();
            this.AddInfoButton = new System.Windows.Forms.Button();
            this.SortBuildsButton = new System.Windows.Forms.Button();
            this.ClearBuildsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoBox
            // 
            this.InfoBox.Location = new System.Drawing.Point(35, 51);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(707, 351);
            this.InfoBox.TabIndex = 0;
            this.InfoBox.Text = "";
            // 
            // AddInfoButton
            // 
            this.AddInfoButton.Location = new System.Drawing.Point(35, 408);
            this.AddInfoButton.Name = "AddInfoButton";
            this.AddInfoButton.Size = new System.Drawing.Size(707, 61);
            this.AddInfoButton.TabIndex = 2;
            this.AddInfoButton.Text = "Add Info To Excel";
            this.AddInfoButton.UseVisualStyleBackColor = true;
            this.AddInfoButton.Click += new System.EventHandler(this.AddColonyInfoButton_Click);
            // 
            // SortBuildsButton
            // 
            this.SortBuildsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SortBuildsButton.Location = new System.Drawing.Point(748, 49);
            this.SortBuildsButton.Name = "SortBuildsButton";
            this.SortBuildsButton.Size = new System.Drawing.Size(109, 23);
            this.SortBuildsButton.TabIndex = 13;
            this.SortBuildsButton.Text = "Sort Builds System";
            this.SortBuildsButton.UseVisualStyleBackColor = true;
            this.SortBuildsButton.Click += new System.EventHandler(this.SortBuildsButton_Click);
            // 
            // ClearBuildsButton
            // 
            this.ClearBuildsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ClearBuildsButton.Location = new System.Drawing.Point(748, 97);
            this.ClearBuildsButton.Name = "ClearBuildsButton";
            this.ClearBuildsButton.Size = new System.Drawing.Size(109, 23);
            this.ClearBuildsButton.TabIndex = 14;
            this.ClearBuildsButton.Text = "Clear Builds";
            this.ClearBuildsButton.UseVisualStyleBackColor = true;
            this.ClearBuildsButton.Click += new System.EventHandler(this.ClearBuildsButton_Click);
            // 
            // PlanetInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(865, 511);
            this.Controls.Add(this.ClearBuildsButton);
            this.Controls.Add(this.SortBuildsButton);
            this.Controls.Add(this.AddInfoButton);
            this.Controls.Add(this.InfoBox);
            this.Name = "PlanetInfoForm";
            this.Text = "PlanetInfoForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox InfoBox;
        private System.Windows.Forms.Button AddInfoButton;
        private System.Windows.Forms.Button SortBuildsButton;
        private System.Windows.Forms.Button ClearBuildsButton;
    }
}