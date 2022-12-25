namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.usernamelevel = new System.Windows.Forms.Label();
            this.passwordlevel = new System.Windows.Forms.Label();
            this.usernametextbox = new System.Windows.Forms.TextBox();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // usernamelevel
            // 
            this.usernamelevel.AutoSize = true;
            this.usernamelevel.Location = new System.Drawing.Point(80, 58);
            this.usernamelevel.Name = "usernamelevel";
            this.usernamelevel.Size = new System.Drawing.Size(71, 13);
            this.usernamelevel.TabIndex = 0;
            this.usernamelevel.Text = "USER NAME";
            // 
            // passwordlevel
            // 
            this.passwordlevel.AutoSize = true;
            this.passwordlevel.Location = new System.Drawing.Point(79, 121);
            this.passwordlevel.Name = "passwordlevel";
            this.passwordlevel.Size = new System.Drawing.Size(77, 13);
            this.passwordlevel.TabIndex = 1;
            this.passwordlevel.Text = "PASSWORED";
            // 
            // usernametextbox
            // 
            this.usernametextbox.Location = new System.Drawing.Point(177, 55);
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.Size = new System.Drawing.Size(231, 20);
            this.usernametextbox.TabIndex = 2;
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Location = new System.Drawing.Point(177, 118);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.Size = new System.Drawing.Size(231, 20);
            this.passwordtextbox.TabIndex = 3;
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(220, 163);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(123, 48);
            this.loginbutton.TabIndex = 4;
            this.loginbutton.Text = "LOG IN";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 289);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.passwordtextbox);
            this.Controls.Add(this.usernametextbox);
            this.Controls.Add(this.passwordlevel);
            this.Controls.Add(this.usernamelevel);
            this.Name = "Form1";
            this.Text = "LOG IN";
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernamelevel;
        private System.Windows.Forms.Label passwordlevel;
        private System.Windows.Forms.TextBox usernametextbox;
        private System.Windows.Forms.TextBox passwordtextbox;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
    }
}

