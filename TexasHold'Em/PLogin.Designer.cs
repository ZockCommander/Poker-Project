﻿
namespace TexasHold_Em
{
    partial class f_plogin
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_plogin = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(16, 49);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(45, 17);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(16, 101);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(69, 17);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Password";
            // 
            // btn_plogin
            // 
            this.btn_plogin.Location = new System.Drawing.Point(28, 277);
            this.btn_plogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_plogin.Name = "btn_plogin";
            this.btn_plogin.Size = new System.Drawing.Size(191, 96);
            this.btn_plogin.TabIndex = 2;
            this.btn_plogin.Text = "Login";
            this.btn_plogin.UseVisualStyleBackColor = true;
            this.btn_plogin.Click += new System.EventHandler(this.btn_plogin_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(95, 46);
            this.tb_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(172, 22);
            this.tb_name.TabIndex = 3;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // tb_pw
            // 
            this.tb_pw.Location = new System.Drawing.Point(95, 97);
            this.tb_pw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.Size = new System.Drawing.Size(172, 22);
            this.tb_pw.TabIndex = 4;
            this.tb_pw.TextChanged += new System.EventHandler(this.tb_pw_TextChanged);
            // 
            // f_plogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 414);
            this.Controls.Add(this.tb_pw);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.btn_plogin);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_name);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "f_plogin";
            this.Text = "PLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_plogin;
        private System.Windows.Forms.TextBox tb_pw;
        public System.Windows.Forms.TextBox tb_name;
    }
}