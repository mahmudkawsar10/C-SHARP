namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idtextbox = new System.Windows.Forms.TextBox();
            this.usrntextbox = new System.Windows.Forms.TextBox();
            this.passtextbox = new System.Windows.Forms.TextBox();
            this.plabel = new System.Windows.Forms.Label();
            this.positiontextbox = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.usrgridview = new System.Windows.Forms.DataGridView();
            this.remove = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.gotoitemtable = new System.Windows.Forms.Button();
            this.gotoselltable = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usrgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " UNIQUE ID(AUTO GENERATE)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "USER NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD";
            // 
            // idtextbox
            // 
            this.idtextbox.Location = new System.Drawing.Point(201, 48);
            this.idtextbox.Name = "idtextbox";
            this.idtextbox.Size = new System.Drawing.Size(179, 20);
            this.idtextbox.TabIndex = 3;
            // 
            // usrntextbox
            // 
            this.usrntextbox.Location = new System.Drawing.Point(106, 102);
            this.usrntextbox.Name = "usrntextbox";
            this.usrntextbox.Size = new System.Drawing.Size(274, 20);
            this.usrntextbox.TabIndex = 4;
            // 
            // passtextbox
            // 
            this.passtextbox.Location = new System.Drawing.Point(106, 153);
            this.passtextbox.Name = "passtextbox";
            this.passtextbox.Size = new System.Drawing.Size(274, 20);
            this.passtextbox.TabIndex = 5;
            // 
            // plabel
            // 
            this.plabel.AutoSize = true;
            this.plabel.Location = new System.Drawing.Point(12, 202);
            this.plabel.Name = "plabel";
            this.plabel.Size = new System.Drawing.Size(58, 13);
            this.plabel.TabIndex = 6;
            this.plabel.Text = "POSITION";
            // 
            // positiontextbox
            // 
            this.positiontextbox.Location = new System.Drawing.Point(106, 199);
            this.positiontextbox.Name = "positiontextbox";
            this.positiontextbox.Size = new System.Drawing.Size(274, 20);
            this.positiontextbox.TabIndex = 7;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(106, 365);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(140, 47);
            this.add.TabIndex = 8;
            this.add.Text = "ADD USER";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(328, 364);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(140, 47);
            this.update.TabIndex = 10;
            this.update.Text = "UPDATE USER";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.button3_Click);
            // 
            // usrgridview
            // 
            this.usrgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usrgridview.Location = new System.Drawing.Point(410, 12);
            this.usrgridview.Name = "usrgridview";
            this.usrgridview.Size = new System.Drawing.Size(657, 320);
            this.usrgridview.TabIndex = 11;
            this.usrgridview.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.usrgridview_CellMouseClick);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(542, 366);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(125, 46);
            this.remove.TabIndex = 12;
            this.remove.Text = "REMOVE USER";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.button4_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(723, 365);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(116, 46);
            this.clear.TabIndex = 13;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.button5_Click);
            // 
            // gotoitemtable
            // 
            this.gotoitemtable.Location = new System.Drawing.Point(106, 449);
            this.gotoitemtable.Name = "gotoitemtable";
            this.gotoitemtable.Size = new System.Drawing.Size(168, 38);
            this.gotoitemtable.TabIndex = 14;
            this.gotoitemtable.Text = "CHECK ITEM";
            this.gotoitemtable.UseVisualStyleBackColor = true;
            this.gotoitemtable.Click += new System.EventHandler(this.gotoitemtable_Click);
            // 
            // gotoselltable
            // 
            this.gotoselltable.Location = new System.Drawing.Point(300, 449);
            this.gotoselltable.Name = "gotoselltable";
            this.gotoselltable.Size = new System.Drawing.Size(168, 38);
            this.gotoselltable.TabIndex = 15;
            this.gotoselltable.Text = "CHECK SELL";
            this.gotoselltable.UseVisualStyleBackColor = true;
            this.gotoselltable.Click += new System.EventHandler(this.gotoselltable_Click);
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(509, 449);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(168, 38);
            this.backbutton.TabIndex = 16;
            this.backbutton.Text = "LOG OUT";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 586);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.gotoselltable);
            this.Controls.Add(this.gotoitemtable);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.usrgridview);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.positiontextbox);
            this.Controls.Add(this.plabel);
            this.Controls.Add(this.passtextbox);
            this.Controls.Add(this.usrntextbox);
            this.Controls.Add(this.idtextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Admin Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usrgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idtextbox;
        private System.Windows.Forms.TextBox usrntextbox;
        private System.Windows.Forms.TextBox passtextbox;
        private System.Windows.Forms.Label plabel;
        private System.Windows.Forms.TextBox positiontextbox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.DataGridView usrgridview;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button gotoitemtable;
        private System.Windows.Forms.Button gotoselltable;
        private System.Windows.Forms.Button backbutton;
    }
}