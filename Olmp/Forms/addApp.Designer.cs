
namespace Olmp.Forms
{
    partial class addApp
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
            this.tb_name = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_acc = new System.Windows.Forms.Button();
            this.btn_main = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panellLogo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panellLogo
            // 
            this.panellLogo.Controls.Add(this.tb_name);
            this.panellLogo.Controls.Add(this.btn_add);
            this.panellLogo.Controls.Add(this.lbl_error);
            this.panellLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panellLogo.Location = new System.Drawing.Point(220, 0);
            this.panellLogo.Name = "panellLogo";
            this.panellLogo.Size = new System.Drawing.Size(580, 449);
            this.panellLogo.TabIndex = 9;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(102, 155);
            this.tb_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(322, 26);
            this.tb_name.TabIndex = 3;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(178, 348);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(188, 83);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Создать";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(206, 266);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(104, 29);
            this.lbl_error.TabIndex = 0;
            this.lbl_error.Text = "lbl_error";
            this.lbl_error.Visible = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btn_exit);
            this.panelMenu.Controls.Add(this.btn_acc);
            this.panelMenu.Controls.Add(this.btn_main);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 449);
            this.panelMenu.TabIndex = 8;
            // 
            // btn_exit
            // 
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(0, 200);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(220, 60);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Выйти";
            this.btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_acc
            // 
            this.btn_acc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_acc.FlatAppearance.BorderSize = 0;
            this.btn_acc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_acc.ForeColor = System.Drawing.Color.White;
            this.btn_acc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_acc.Location = new System.Drawing.Point(0, 140);
            this.btn_acc.Name = "btn_acc";
            this.btn_acc.Size = new System.Drawing.Size(220, 60);
            this.btn_acc.TabIndex = 4;
            this.btn_acc.Text = "Аккаунт";
            this.btn_acc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_acc.UseVisualStyleBackColor = true;
            this.btn_acc.Click += new System.EventHandler(this.btn_acc_Click);
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
            // addApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.panellLogo);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "addApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить приложение";
            this.Load += new System.EventHandler(this.addApp_Load);
            this.panellLogo.ResumeLayout(false);
            this.panellLogo.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panellLogo;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_acc;
        private System.Windows.Forms.Button btn_main;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_name;
    }
}