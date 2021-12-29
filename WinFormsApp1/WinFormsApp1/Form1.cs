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

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            label2.Hide();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            label3.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string admin = "miaakriss";
            string adminPass = "qwerty";

            var log = Convert.ToString(textBox1.Text);

            var pas = Convert.ToString(textBox2.Text);


            string connectionString = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=AYTH.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);


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

            if (log == admin && pas == adminPass)
            {
                Меню mn = new Меню();
                mn.Owner = this;
                mn.Show();
                Hide();
            }

            else if (result == null && result1 == null || result == null || result1 == null)
            {
                MessageBox.Show("Данные введены не верно!");

            }

            else
            {
                Для_абитуриентов da = new Для_абитуриентов();
                da.Owner = this;
                da.Show();
                Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Регистрация rg = new Регистрация();
            rg.Owner = this;
            rg.Show();
            Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
