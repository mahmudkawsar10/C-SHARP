﻿namespace WindowsFormsApplication1
{
    partial class Form5
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
            this.selldetailsgrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.selldetailsgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // selldetailsgrid
            // 
            this.selldetailsgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selldetailsgrid.Location = new System.Drawing.Point(22, 27);
            this.selldetailsgrid.Name = "selldetailsgrid";
            this.selldetailsgrid.Size = new System.Drawing.Size(832, 300);
            this.selldetailsgrid.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "GO BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(270, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 66);
            this.button2.TabIndex = 2;
            this.button2.Text = "LOG OUT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 491);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selldetailsgrid);
            this.Name = "Form5";
            this.Text = "SELL";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selldetailsgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView selldetailsgrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}