using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Npgsql;
using OpenXmlPowerTools;

namespace Olmp.Forms
{
    class DB
    {
        public string connectionString = "Host=localhost;Username=postgres;Password=' ';Database=DB";
        public void SigUp(string email, string password)
        {
                NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
                npgSqlConnection.Open();
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"INSERT INTO users(email, password) VALUES ('{email}', '{password}')", npgSqlConnection);
                npgSqlCommand.ExecuteNonQuery();
                npgSqlConnection.Close();
        }

        public void CheckEmail(string email, out bool checkEmail) {
            checkEmail = false;
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"SELECT email FROM users WHERE email = '{email}';", npgSqlConnection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
            if (!npgSqlDataReader.HasRows)
                checkEmail = true;
            npgSqlConnection.Close();
        }


        public void SignIn(string email, out string password, out bool pr)
        {
            password = "";
            pr = true;
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"SELECT password FROM users WHERE email = '{email}';", npgSqlConnection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
            if (npgSqlDataReader.HasRows)
                foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
                    password = dbDataRecord["password"].ToString();
            if (!npgSqlDataReader.HasRows)
                pr = false;
            npgSqlConnection.Close();
        }


        public void amountApp(string email, out int amount)
        {
            amount = 0;
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"SELECT name FROM app WHERE email = '{email}';", npgSqlConnection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
            if (npgSqlDataReader.HasRows)
                foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
                    amount++;
            npgSqlConnection.Close();
        }

        public void addApp(string name, string ucode, string email)
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"INSERT INTO app(email, name, ucode, date, view, edit) VALUES ('{email}', '{name}', '{ucode}', '{DateTime.Now:g}', '0', '1')", npgSqlConnection);
            npgSqlCommand.ExecuteNonQuery();
            npgSqlConnection.Close();
        }

        public void appList(string email, DataGridView gridListApp, DataTable dt)
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            view(email);
            NpgsqlCommand comm = new NpgsqlCommand
            {
                Connection = npgSqlConnection,
                CommandType = CommandType.Text,
                CommandText = $"SELECT name, ucode, date FROM app WHERE email = '{email}'"
            };
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                dt = new DataTable();
                dt.Load(dr);
                gridListApp.DataSource = dt;
            }
            comm.Dispose();               
            npgSqlConnection.Close();
        }
        public void CheckUCode(string ucode, out bool check)
        {
            check = false;
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"SELECT ucode FROM app Where ucode = '{ucode}'", npgSqlConnection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
            if (npgSqlDataReader.HasRows)
                check = true;
            npgSqlConnection.Close();
        }

        public void statsApp (string email, Chart chrt)
        {
            int view=1 , edit=1;
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"SELECT view, edit FROM app Where email = '{email}'", npgSqlConnection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
            if (npgSqlDataReader.HasRows)
                foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
                {
                    view = int.Parse(dbDataRecord["view"].ToString());
                    edit = int.Parse(dbDataRecord["edit"].ToString());
                }
            chrt.Series[0].Points.AddXY("Просмотров", view);
            chrt.Series[0].Points.AddXY("Изменений", edit);
            npgSqlConnection.Close();     
        }

        public void view (string email)
        {
            int view = 0;
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"SELECT view FROM app WHERE email = '{email}';", npgSqlConnection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
            if (npgSqlDataReader.HasRows)
                foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
                    view = int.Parse(dbDataRecord["view"].ToString());
            view++;
            npgSqlCommand = new NpgsqlCommand($"UPDARE app Set view = {view} where email = '{email}'", npgSqlConnection);
            npgSqlCommand.ExecuteNonQuery();
            npgSqlConnection.Close();
        }
    }
}
