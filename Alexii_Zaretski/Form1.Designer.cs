﻿namespace Alexii_Zaretski
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
            this.btnBook = new System.Windows.Forms.Button();
            this.btnFurn = new System.Windows.Forms.Button();
            this.displayBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(12, 12);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(371, 73);
            this.btnBook.TabIndex = 0;
            this.btnBook.Text = "Add Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnFurn
            // 
            this.btnFurn.Location = new System.Drawing.Point(417, 12);
            this.btnFurn.Name = "btnFurn";
            this.btnFurn.Size = new System.Drawing.Size(371, 73);
            this.btnFurn.TabIndex = 1;
            this.btnFurn.Text = "Add Furniture";
            this.btnFurn.UseVisualStyleBackColor = true;
            this.btnFurn.Click += new System.EventHandler(this.btnFurn_Click);
            // 
            // displayBtn
            // 
            this.displayBtn.Location = new System.Drawing.Point(12, 341);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(776, 97);
            this.displayBtn.TabIndex = 2;
            this.displayBtn.Text = "Display Items";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(776, 102);
            this.button1.TabIndex = 3;
            this.button1.Text = "Compare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.btnFurn);
            this.Controls.Add(this.btnBook);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnFurn;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.Button button1;
    }
}

