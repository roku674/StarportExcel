using System;

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
            this.CheckGrow = new System.Windows.Forms.Button();
            this.FindZounds = new System.Windows.Forms.Button();
            this.FindTotals = new System.Windows.Forms.Button();
            this.FindNeedsDefense = new System.Windows.Forms.Button();
            this.CheckParenthesis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateQuote
            // 
            this.CreateQuote.Location = new System.Drawing.Point(245, 379);
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
            this.FindZounds.Location = new System.Drawing.Point(458, 71);
            this.FindZounds.Name = "FindZounds";
            this.FindZounds.Size = new System.Drawing.Size(109, 23);
            this.FindZounds.TabIndex = 3;
            this.FindZounds.Text = "Find Zounds";
            this.FindZounds.UseVisualStyleBackColor = true;
            this.FindZounds.Click += new System.EventHandler(this.FindZounds_Click);
            // 
            // FindTotals
            // 
            this.FindTotals.Location = new System.Drawing.Point(458, 42);
            this.FindTotals.Name = "FindTotals";
            this.FindTotals.Size = new System.Drawing.Size(109, 23);
            this.FindTotals.TabIndex = 4;
            this.FindTotals.Text = "Find Totals";
            this.FindTotals.UseVisualStyleBackColor = true;
            this.FindTotals.Click += new System.EventHandler(this.FindTotals_Click);
            // 
            // FindNeedsDefense
            // 
            this.FindNeedsDefense.Location = new System.Drawing.Point(245, 42);
            this.FindNeedsDefense.Name = "FindNeedsDefense";
            this.FindNeedsDefense.Size = new System.Drawing.Size(109, 36);
            this.FindNeedsDefense.TabIndex = 6;
            this.FindNeedsDefense.Text = "Find Needs Defense";
            this.FindNeedsDefense.UseVisualStyleBackColor = true;
            this.FindNeedsDefense.Click += new System.EventHandler(this.FindNeedsDefense_Click);
            // 
            // CheckParenthesis
            // 
            this.CheckParenthesis.Location = new System.Drawing.Point(31, 378);
            this.CheckParenthesis.Name = "CheckParenthesis";
            this.CheckParenthesis.Size = new System.Drawing.Size(109, 23);
            this.CheckParenthesis.TabIndex = 7;
            this.CheckParenthesis.Text = "Check Parenthesis";
            this.CheckParenthesis.UseVisualStyleBackColor = true;
            this.CheckParenthesis.Click += new System.EventHandler(this.CheckParenthesis_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(590, 434);
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

        }



        #endregion

        private System.Windows.Forms.Button CreateQuote;
        private System.Windows.Forms.Button FindGrowing;
        private System.Windows.Forms.Button CheckGrow;
        private System.Windows.Forms.Button FindZounds;
        private System.Windows.Forms.Button FindTotals;
        private System.Windows.Forms.Button FindNeedsDefense;
        private System.Windows.Forms.Button CheckParenthesis;
    }
}

