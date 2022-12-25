namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.label4 = new System.Windows.Forms.Label();
            this.itemnumber = new System.Windows.Forms.TextBox();
            this.itemname = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.discount = new System.Windows.Forms.TextBox();
            this.itemgridview = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.updateitem = new System.Windows.Forms.Button();
            this.deleteitem = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ITEM NUMBER(AUTO GENERATE)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ITEM NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PRICE ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DISCOUNT";
            // 
            // itemnumber
            // 
            this.itemnumber.Location = new System.Drawing.Point(239, 40);
            this.itemnumber.Name = "itemnumber";
            this.itemnumber.Size = new System.Drawing.Size(95, 20);
            this.itemnumber.TabIndex = 4;
            // 
            // itemname
            // 
            this.itemname.Location = new System.Drawing.Point(160, 87);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(174, 20);
            this.itemname.TabIndex = 5;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(160, 140);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(174, 20);
            this.price.TabIndex = 6;
            // 
            // discount
            // 
            this.discount.Location = new System.Drawing.Point(160, 183);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(174, 20);
            this.discount.TabIndex = 7;
            // 
            // itemgridview
            // 
            this.itemgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemgridview.Location = new System.Drawing.Point(396, 12);
            this.itemgridview.Name = "itemgridview";
            this.itemgridview.Size = new System.Drawing.Size(616, 280);
            this.itemgridview.TabIndex = 8;
            this.itemgridview.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.itemgridview_CellMouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 54);
            this.button1.TabIndex = 9;
            this.button1.Text = "INSERT ITEM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateitem
            // 
            this.updateitem.Location = new System.Drawing.Point(205, 268);
            this.updateitem.Name = "updateitem";
            this.updateitem.Size = new System.Drawing.Size(109, 54);
            this.updateitem.TabIndex = 10;
            this.updateitem.Text = "UPDATE ITEM";
            this.updateitem.UseVisualStyleBackColor = true;
            this.updateitem.Click += new System.EventHandler(this.updateitem_Click);
            // 
            // deleteitem
            // 
            this.deleteitem.Location = new System.Drawing.Point(44, 364);
            this.deleteitem.Name = "deleteitem";
            this.deleteitem.Size = new System.Drawing.Size(109, 54);
            this.deleteitem.TabIndex = 11;
            this.deleteitem.Text = "REMOVE ITEM";
            this.deleteitem.UseVisualStyleBackColor = true;
            this.deleteitem.Click += new System.EventHandler(this.deleteitem_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(205, 364);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(109, 54);
            this.clearbutton.TabIndex = 12;
            this.clearbutton.Text = "CLEAR";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(205, 456);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(109, 40);
            this.logout.TabIndex = 13;
            this.logout.Text = "LOG OUT";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(57, 456);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(109, 40);
            this.backbutton.TabIndex = 14;
            this.backbutton.Text = "GO BACK";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 554);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.deleteitem);
            this.Controls.Add(this.updateitem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.itemgridview);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.price);
            this.Controls.Add(this.itemname);
            this.Controls.Add(this.itemnumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "ITEM";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox itemnumber;
        private System.Windows.Forms.TextBox itemname;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox discount;
        private System.Windows.Forms.DataGridView itemgridview;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button updateitem;
        private System.Windows.Forms.Button deleteitem;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button backbutton;
    }
}