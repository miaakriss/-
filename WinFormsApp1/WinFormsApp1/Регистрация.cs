using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Регистрация : Form
    {
        public Регистрация()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3reg_Click(object sender, EventArgs e)
        {
           
                int id = Convert.ToInt32(textBox4.Text);
                string login = Convert.ToString(textBox1.Text);
                string password = Convert.ToString(textBox2.Text);
                string mail = Convert.ToString(textBox3.Text);


                Regex reg = new Regex(@"\b[^_+.+][-\w.]+@([A-z0-9][-A-z0-9]+\.)+[A-z]{2,4}\b", RegexOptions.IgnoreCase);
                MatchCollection mc = reg.Matches(mail);

                string connectionString = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=AYTH.mdb";//строка соеденения
                OleDbConnection dbConnection = new OleDbConnection(connectionString);//создаем соеденение


                OleDbCommand MyOleDbComm2 = new OleDbCommand();
                dbConnection.Open();

                MyOleDbComm2.CommandText = "Select Login from LogPas " +
                                           " Where LogPas.Login='" + textBox1.Text + "'";
                MyOleDbComm2.Connection = dbConnection;

                var result = MyOleDbComm2.ExecuteScalar();

                dbConnection.Close();

                OleDbCommand MyOleDbComm1 = new OleDbCommand();
                dbConnection.Open();

                MyOleDbComm1.CommandText = "Select Password from LogPas " +
                                           " Where LogPas.Password='" + textBox2.Text + "'";
                MyOleDbComm1.Connection = dbConnection;

                var result1 = MyOleDbComm1.ExecuteScalar();

                dbConnection.Close();


                if (mc.Count > 0 && result == null && result1 == null && login != "admin" && password != "admin")
                {

                    dbConnection.Open();//открываем соеденение
                    string query = "INSERT INTO LogPas VALUES (" + id + ", '" + login + "', '" + password + "', '" + mail + "')";//строка запроса
                    OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);//команда

                    //Выполняем запрос
                    if (dbCommand.ExecuteNonQuery() != 1)
                        MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
                    else
                        MessageBox.Show("Данные добавлены!", "Внимание!");

                    //Закрываем соеденение с БД
                    dbConnection.Close();

                }

                else
                {
                    MessageBox.Show("Данные введен не верно или такой пользователь уже существует!");

                }


            
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            label2.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label3.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label4.Hide();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            label5.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Hide();
        }

        private void Регистрация_Load(object sender, EventArgs e)
        {

        }



        private void textBox4_Click(object sender, EventArgs e)
        {
            label6.Hide();
        }

        private void Регистрация_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            label3.Hide();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            label4.Hide();
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            label5.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();//переход на другую форму
            fm.Owner = this;
            fm.Show();
            Hide();
        }
    }
}
