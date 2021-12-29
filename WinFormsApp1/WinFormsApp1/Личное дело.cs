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
    public partial class Личное_дело : Form
    {
        public Личное_дело()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Меню mn = new Меню();//переход на другую форму
            mn.Owner = this;
            mn.Show();
            Hide();
        }

        private void Личное_дело_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=SystemDataBase.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "SELECT * FROM Таблица1";
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
                    dataGridView1.Rows.Add(dbReader["ID"], dbReader["ФИО"], dbReader["Дата_рождения"], dbReader["Гражданство"], dbReader["Пол"], dbReader["Домашний_адрес"], dbReader["Телефон"], dbReader["Данные_о_родителях"]);
                }
            }

            dbReader.Close();
            dbConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Проверим количество выбранных строк
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            //Запомним выбранную строку
            int index = dataGridView1.SelectedRows[0].Index;

            //Проверим данные в таблицы
            if (dataGridView1.Rows[index].Cells[0].Value == null ||
                dataGridView1.Rows[index].Cells[1].Value == null ||
                dataGridView1.Rows[index].Cells[2].Value == null ||
                dataGridView1.Rows[index].Cells[3].Value == null ||
                dataGridView1.Rows[index].Cells[4].Value == null ||
                dataGridView1.Rows[index].Cells[5].Value == null ||
                dataGridView1.Rows[index].Cells[6].Value == null ||
                dataGridView1.Rows[index].Cells[7].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            //Считаем данные
            var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
            var data = dataGridView1.Rows[index].Cells[2].Value.ToString();
            var graj = dataGridView1.Rows[index].Cells[3].Value.ToString();
            var sex = dataGridView1.Rows[index].Cells[4].Value.ToString();
            var homeA = dataGridView1.Rows[index].Cells[5].Value.ToString();
            var number = dataGridView1.Rows[index].Cells[6].Value.ToString();
            var infoP = dataGridView1.Rows[index].Cells[7].Value.ToString();


            //Создаем соеденение
            string connectionString = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=SystemDataBase.mdb";//строка соеденения
            OleDbConnection dbConnection = new OleDbConnection(connectionString);//создаем соеденение

            //Выполянем запрос к БД
            dbConnection.Open();//открываем соеденение
            string query = "INSERT INTO Таблица1 VALUES (" + id + ", '" + name + "', '" + data + "', '" + graj + "', '" + sex + "', '"+homeA+"', "+number+", '"+infoP+"')";//строка запроса
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);//команда

            //Выполняем запрос
            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
                MessageBox.Show("Данные добавлены!", "Внимание!");

            //Закрываем соеденение с БД
            dbConnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Проверим количество выбранных строк
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            //Запомним выбранную строку
            int index = dataGridView1.SelectedRows[0].Index;

            //Проверим данные в таблицы
            if (dataGridView1.Rows[index].Cells[0].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            //Считаем данные
            string id = dataGridView1.Rows[index].Cells[0].Value.ToString();

            //Создаем соеденение
            string connectionString = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=SystemDataBase.mdb";//строка соеденения
            OleDbConnection dbConnection = new OleDbConnection(connectionString);//создаем соеденение

            //Выполянем запрос к БД
            dbConnection.Open();//открываем соеденение
            string query = "DELETE FROM Таблица1 WHERE ID= " + id;//строка запроса
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);//команда

            //Выполняем запрос
            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
            {
                MessageBox.Show("Данные удалены!", "Внимание!");
                //Удаляем данные из таблицы в форме
                dataGridView1.Rows.RemoveAt(index);
            }

            //Закрываем соеденение с БД
            dbConnection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Проверим количество выбранных строк
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            //Запомним выбранную строку
            int index = dataGridView1.SelectedRows[0].Index;

            //Проверим данные в таблицы
            if (dataGridView1.Rows[index].Cells[0].Value == null ||
                dataGridView1.Rows[index].Cells[1].Value == null ||
                dataGridView1.Rows[index].Cells[2].Value == null ||
                dataGridView1.Rows[index].Cells[3].Value == null ||
                dataGridView1.Rows[index].Cells[4].Value == null ||
                dataGridView1.Rows[index].Cells[5].Value == null ||
                dataGridView1.Rows[index].Cells[6].Value == null ||
                dataGridView1.Rows[index].Cells[7].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            //Считаем данные
            var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
            var data = dataGridView1.Rows[index].Cells[2].Value.ToString();
            var graj = dataGridView1.Rows[index].Cells[3].Value.ToString();
            var sex = dataGridView1.Rows[index].Cells[4].Value.ToString();
            var homeA = dataGridView1.Rows[index].Cells[5].Value.ToString();
            var number = dataGridView1.Rows[index].Cells[6].Value.ToString();
            var infoP = dataGridView1.Rows[index].Cells[7].Value.ToString();

            //Создаем соеденение
            string connectionString = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=SystemDataBase.mdb";//строка соеденения
            OleDbConnection dbConnection = new OleDbConnection(connectionString);//создаем соеденение

            //Выполянем запрос к БД
            dbConnection.Open();//открываем соеденение
            string query = "UPDATE Таблица1 SET ФИО= '" + name + "',Дата_Рождения='" + data + "',Гражданство='" + graj + "',Пол = '" + sex + "',Домашний_Адрес = '" + homeA + "', Телефон = " + number + ", Данные_о_родителях = '"+infoP+"' WHERE ID = " + id;//строка запроса
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);//команда

            //Выполняем запрос
            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
                MessageBox.Show("Данные добавлены!", "Внимание!");

            //Закрываем соеденение с БД
            dbConnection.Close();
        }
    }
}
