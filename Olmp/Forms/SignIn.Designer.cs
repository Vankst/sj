﻿namespace Olmp.Forms
{
    partial class SignIn
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
            this.panellLogo = new System.Windows.Forms.Panel();
            this.lbl_error = new System.Windows.Forms.Label();
            this.btn_sign = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_signup = new System.Windows.Forms.Button();
            this.btn_main = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panellLogo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panellLogo
            // 
            this.panellLogo.Controls.Add(this.lbl_error);
            this.panellLogo.Controls.Add(this.btn_sign);
            this.panellLogo.Controls.Add(this.tb_password);
            this.panellLogo.Controls.Add(this.tb_email);
            this.panellLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panellLogo.Location = new System.Drawing.Point(220, 0);
            this.panellLogo.Name = "panellLogo";
            this.panellLogo.Size = new System.Drawing.Size(580, 449);
            this.panellLogo.TabIndex = 5;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(246, 274);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(51, 20);
            this.lbl_error.TabIndex = 6;
            this.lbl_error.Text = "label1";
            this.lbl_error.Visible = false;
            // 
            // btn_sign
            // 
            this.btn_sign.Location = new System.Drawing.Point(184, 348);
            this.btn_sign.Name = "btn_sign";
            this.btn_sign.Size = new System.Drawing.Size(195, 75);
            this.btn_sign.TabIndex = 5;
            this.btn_sign.Text = "Вход";
            this.btn_sign.UseVisualStyleBackColor = true;
            this.btn_sign.Click += new System.EventHandler(this.btn_sign_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(48, 158);
            this.tb_password.Multiline = true;
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(476, 42);
            this.tb_password.TabIndex = 1;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(48, 80);
            this.tb_email.Multiline = true;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(476, 42);
            this.tb_email.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btn_signup);
            this.panelMenu.Controls.Add(this.btn_main);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 449);
            this.panelMenu.TabIndex = 4;
            // 
            // btn_signup
            // 
            this.btn_signup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_signup.FlatAppearance.BorderSize = 0;
            this.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_signup.ForeColor = System.Drawing.Color.White;
            this.btn_signup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_signup.Location = new System.Drawing.Point(0, 140);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(220, 60);
            this.btn_signup.TabIndex = 4;
            this.btn_signup.Text = "Регистрация";
            this.btn_signup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // btn_main
            // 
            this.btn_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_main.FlatAppearance.BorderSize = 0;
            this.btn_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_main.ForeColor = System.Drawing.Color.White;
            this.btn_main.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_main.Location = new System.Drawing.Point(0, 80);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(220, 60);
            this.btn_main.TabIndex = 0;
            this.btn_main.Text = "На главную";
            this.btn_main.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_main.UseVisualStyleBackColor = true;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 1;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.panellLogo);
            this.Controls.Add(this.panelMenu);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SigIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.panellLogo.ResumeLayout(false);
            this.panellLogo.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panellLogo;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Button btn_sign;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Button btn_main;
        private System.Windows.Forms.Panel panelLogo;
    }
}