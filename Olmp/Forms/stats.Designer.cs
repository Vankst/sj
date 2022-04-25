namespace Olmp.Forms
{
    partial class stats
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panellLogo = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_applist = new System.Windows.Forms.Button();
            this.btn_main = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.chrt = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panellLogo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt)).BeginInit();
            this.SuspendLayout();
            // 
            // panellLogo
            // 
            this.panellLogo.Controls.Add(this.chrt);
            this.panellLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panellLogo.Location = new System.Drawing.Point(220, 0);
            this.panellLogo.Name = "panellLogo";
            this.panellLogo.Size = new System.Drawing.Size(580, 450);
            this.panellLogo.TabIndex = 9;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btn_exit);
            this.panelMenu.Controls.Add(this.btn_applist);
            this.panelMenu.Controls.Add(this.btn_main);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 450);
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
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Выйти";
            this.btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_applist
            // 
            this.btn_applist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_applist.FlatAppearance.BorderSize = 0;
            this.btn_applist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_applist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_applist.ForeColor = System.Drawing.Color.White;
            this.btn_applist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_applist.Location = new System.Drawing.Point(0, 140);
            this.btn_applist.Name = "btn_applist";
            this.btn_applist.Size = new System.Drawing.Size(220, 60);
            this.btn_applist.TabIndex = 4;
            this.btn_applist.Text = "Аккаунт";
            this.btn_applist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_applist.UseVisualStyleBackColor = true;
            this.btn_applist.Click += new System.EventHandler(this.btn_applist_Click);
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
            // chrt
            // 
            chartArea1.Name = "ChartArea1";
            this.chrt.ChartAreas.Add(chartArea1);
            this.chrt.IsSoftShadows = false;
            legend1.Name = "Legend1";
            this.chrt.Legends.Add(legend1);
            this.chrt.Location = new System.Drawing.Point(0, 80);
            this.chrt.Name = "chrt";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.CustomProperties = "PieLabelStyle=Disabled";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.SmartLabelStyle.Enabled = false;
            this.chrt.Series.Add(series1);
            this.chrt.Size = new System.Drawing.Size(580, 370);
            this.chrt.TabIndex = 0;
            this.chrt.Text = "chart1";
            // 
            // stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panellLogo);
            this.Controls.Add(this.panelMenu);
            this.Name = "stats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "stats";
            this.Load += new System.EventHandler(this.stats_Load);
            this.panellLogo.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panellLogo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_applist;
        private System.Windows.Forms.Button btn_main;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt;
    }
}