using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Olmp.Forms
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
            bool pr = true;
            string password = "";
            string hash = "";
            if (tb_email.Text == String.Empty)
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Введите email";
                return;
            }
            else if (tb_password.Text == String.Empty)
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Введите пароль";
                return;

            }
            else if (!IsEmail(tb_email.Text))
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Неверная почта";
                return;
            }
            else
            {
                hash = CreateMD5Hash(tb_password.Text);
                DB dB = new DB();
                dB.SignIn(tb_email.Text, out password, out pr);
                if (hash.ToLower() == password && pr == true)
                {
                    Account account = new Account();
                    Account.email = tb_email.Text;
                    Main main = new Main();
                    Main.SignIN = true;
                    Main.email = tb_email.Text;
                    account.Show();
                    this.Hide();
            }
                else
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Неправильный логин или пароль";
            }
        }
           

        }

        public string CreateMD5Hash(string input)
        {

            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }
        static bool IsEmail(string email)
        {
            string cond = @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)";
            if (Regex.IsMatch(email, cond))
                return true;
            else 
                return false;

        }

        private void btn_main_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Close();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
