using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Olmp.Forms;

namespace Olmp.Forms
{
    public partial class viewApp : Form
    {
        public viewApp()
        {
            InitializeComponent();
        }
        public static string email;
        private void btn_main_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Main.email = email;
            Main.SignIN = true;
            main.Show();
            this.Close();
        }
        private DataTable dt = new DataTable();
        private void viewApp_Load(object sender, EventArgs e)
        {
            DB dB = new DB();
            dB.appList(email, gridListApp, dt);
        }

        private void btn_acc_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Main.email = string.Empty;
            Main.SignIN = false;
            main.Show();
            this.Close();
        }
    }
}
