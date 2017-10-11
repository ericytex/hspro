using System;

namespace hspro
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public EventHandler frmLogin_Load { get; private set; }

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
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // usernametxt
            // 
            this.usernametxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.usernametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernametxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxt.Location = new System.Drawing.Point(84, 31);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(127, 19);
            this.usernametxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(19, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // passwordtxt
            // 
            this.passwordtxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.passwordtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordtxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.Location = new System.Drawing.Point(84, 62);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '*';
            this.passwordtxt.Size = new System.Drawing.Size(127, 19);
            this.passwordtxt.TabIndex = 4;
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbtn.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.SystemColors.Window;
            this.Loginbtn.Location = new System.Drawing.Point(15, 187);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(89, 26);
            this.Loginbtn.TabIndex = 5;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.ForeColor = System.Drawing.SystemColors.Window;
            this.cancelbtn.Location = new System.Drawing.Point(148, 187);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(86, 26);
            this.cancelbtn.TabIndex = 6;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.usernametxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.passwordtxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 109);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hspro.Properties.Resources.image2;
            this.pictureBox1.Location = new System.Drawing.Point(88, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(256, 233);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}