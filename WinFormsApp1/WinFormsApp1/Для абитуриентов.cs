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
    public partial class Для_абитуриентов : Form
    {
        public Для_абитуриентов()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Owner = this;
            log.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Для_абитуриентов_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Для_абитуриентов_Load(object sender, EventArgs e)
        {
            string connectionString = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=SystemDataBase.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "SELECT * FROM Таблица2 WHERE Средний_балл >= 8.2";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            if (dbReader.HasRows == false)
            {
                MessageBox.Show("Ошибка");
            }
            else
            {
                while (dbReader.Read())
                {
                    dataGridView1.Rows.Add(dbReader["ID"], dbReader["ФИО"]);
                }
            }

            dbReader.Close();
            dbConnection.Close();
        }
    }
}
