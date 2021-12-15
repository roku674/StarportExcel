
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
            this.RemoveDuplicatesButton = new System.Windows.Forms.Button();
            this.DefendedCheckBox = new System.Windows.Forms.CheckBox();
            this.RenameTextBox = new System.Windows.Forms.RichTextBox();
            this.ChangeNameButton = new System.Windows.Forms.Button();
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
            this.ClearBuildsButton.Location = new System.Drawing.Point(748, 155);
            this.ClearBuildsButton.Name = "ClearBuildsButton";
            this.ClearBuildsButton.Size = new System.Drawing.Size(109, 23);
            this.ClearBuildsButton.TabIndex = 14;
            this.ClearBuildsButton.Text = "Clear Builds";
            this.ClearBuildsButton.UseVisualStyleBackColor = true;
            this.ClearBuildsButton.Click += new System.EventHandler(this.ClearBuildsButton_Click);
            // 
            // RemoveDuplicatesButton
            // 
            this.RemoveDuplicatesButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RemoveDuplicatesButton.Location = new System.Drawing.Point(748, 126);
            this.RemoveDuplicatesButton.Name = "RemoveDuplicatesButton";
            this.RemoveDuplicatesButton.Size = new System.Drawing.Size(109, 23);
            this.RemoveDuplicatesButton.TabIndex = 15;
            this.RemoveDuplicatesButton.Text = "Remove Duplicates";
            this.RemoveDuplicatesButton.UseVisualStyleBackColor = true;
            this.RemoveDuplicatesButton.Click += new System.EventHandler(this.RemoveDuplicatesButton_Click);
            // 
            // DefendedCheckBox
            // 
            this.DefendedCheckBox.AutoSize = true;
            this.DefendedCheckBox.Location = new System.Drawing.Point(748, 222);
            this.DefendedCheckBox.Name = "DefendedCheckBox";
            this.DefendedCheckBox.Size = new System.Drawing.Size(73, 17);
            this.DefendedCheckBox.TabIndex = 17;
            this.DefendedCheckBox.Text = "Defended";
            this.DefendedCheckBox.UseVisualStyleBackColor = true;
            // 
            // RenameTextBox
            // 
            this.RenameTextBox.Location = new System.Drawing.Point(748, 356);
            this.RenameTextBox.Name = "RenameTextBox";
            this.RenameTextBox.Size = new System.Drawing.Size(109, 23);
            this.RenameTextBox.TabIndex = 19;
            this.RenameTextBox.Text = "";
            // 
            // ChangeNameButton
            // 
            this.ChangeNameButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChangeNameButton.Location = new System.Drawing.Point(748, 385);
            this.ChangeNameButton.Name = "ChangeNameButton";
            this.ChangeNameButton.Size = new System.Drawing.Size(109, 23);
            this.ChangeNameButton.TabIndex = 20;
            this.ChangeNameButton.Text = "Change Name";
            this.ChangeNameButton.UseVisualStyleBackColor = true;
            this.ChangeNameButton.Click += new System.EventHandler(this.ChangeNameButton_Click);
            // 
            // PlanetInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(865, 511);
            this.Controls.Add(this.ChangeNameButton);
            this.Controls.Add(this.RenameTextBox);
            this.Controls.Add(this.DefendedCheckBox);
            this.Controls.Add(this.RemoveDuplicatesButton);
            this.Controls.Add(this.ClearBuildsButton);
            this.Controls.Add(this.SortBuildsButton);
            this.Controls.Add(this.AddInfoButton);
            this.Controls.Add(this.InfoBox);
            this.Name = "PlanetInfoForm";
            this.Text = "PlanetInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox InfoBox;
        private System.Windows.Forms.Button AddInfoButton;
        private System.Windows.Forms.Button SortBuildsButton;
        private System.Windows.Forms.Button ClearBuildsButton;
        private System.Windows.Forms.Button RemoveDuplicatesButton;
        private System.Windows.Forms.CheckBox DefendedCheckBox;
        private System.Windows.Forms.RichTextBox RenameTextBox;
        private System.Windows.Forms.Button ChangeNameButton;
    }
}