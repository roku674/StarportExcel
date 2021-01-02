namespace Starport
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
            this.SuspendLayout();
            // 
            // CreateQuote
            // 
            this.CreateQuote.Location = new System.Drawing.Point(38, 42);
            this.CreateQuote.Name = "CreateQuote";
            this.CreateQuote.Size = new System.Drawing.Size(109, 23);
            this.CreateQuote.TabIndex = 0;
            this.CreateQuote.Text = "Create Quote";
            this.CreateQuote.UseVisualStyleBackColor = true;
            this.CreateQuote.Click += new System.EventHandler(this.CreateQuote_Click);
            // 
            // FindGrowing
            // 
            this.FindGrowing.Location = new System.Drawing.Point(38, 72);
            this.FindGrowing.Name = "FindGrowing";
            this.FindGrowing.Size = new System.Drawing.Size(109, 23);
            this.FindGrowing.TabIndex = 1;
            this.FindGrowing.Text = "Find Growing";
            this.FindGrowing.UseVisualStyleBackColor = true;
            this.FindGrowing.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(590, 434);
            this.Controls.Add(this.FindGrowing);
            this.Controls.Add(this.CreateQuote);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateQuote;
        private System.Windows.Forms.Button FindGrowing;
    }
}

