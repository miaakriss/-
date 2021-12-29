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
    public partial class Образование : Form
    {
        public Образование()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Меню mn1 = new Меню();
            mn1.Owner = this;
            mn1.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
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
                    dataGridView1.Rows.Add(dbReader["ID"], dbReader["ФИО"], dbReader["Выбранная_специальность"], dbReader["Законченное_образование"], dbReader["Год_окончания"], dbReader["Изучаемый_язык"], dbReader["Средний_балл"]);
                }
            }

           
            dbReader.Close();
            dbConnection.Close();

            

            //Выполянем запрос к БД
            dbConnection.Open();//открываем соеденение
            string query2 = "DELETE FROM Таблица2 WHERE Средний_балл <= 8.2";//строка запроса
            OleDbCommand dbCommand2 = new OleDbCommand(query2, dbConnection);//команда

            if (dbCommand2.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
            {
                MessageBox.Show("Данные удалены!", "Внимание!");
                //Удаляем данные из таблицы в форме
            }

            dbConnection.Close();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=SystemDataBase.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "SELECT * FROM Таблица2";
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
                    dataGridView1.Rows.Add(dbReader["ID"], dbReader["ФИО"], dbReader["Выбранная_специальность"], dbReader["Законченное_образование"], dbReader["Год_окончания"], dbReader["Изучаемый_язык"], dbReader["Средний_балл"]);
                }
            }

            dbReader.Close();
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
            if (dataGridView1.Rows[index].Cells[0].Value == null ||
                dataGridView1.Rows[index].Cells[1].Value == null ||
                dataGridView1.Rows[index].Cells[2].Value == null ||
                dataGridView1.Rows[index].Cells[3].Value == null ||
                dataGridView1.Rows[index].Cells[4].Value == null ||
                dataGridView1.Rows[index].Cells[5].Value == null ||
                dataGridView1.Rows[index].Cells[6].Value == null)
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
            double number = Convert.ToDouble(dataGridView1.Rows[index].Cells[6].Value);


            //Создаем соеденение
            string connectionString = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=SystemDataBase.mdb";//строка соеденения
            OleDbConnection dbConnection = new OleDbConnection(connectionString);//создаем соеденение

            //Выполянем запрос к БД
            dbConnection.Open();//открываем соеденение
            string query = "INSERT INTO Таблица2 VALUES (" + id + ", '" + name + "', '" + data + "', '" + graj + "', '" + sex + "', '" + homeA + "', " + number + ")";//строка запроса
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);//команда

            //Выполняем запрос
            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
                MessageBox.Show("Данные добавлены!", "Внимание!");

            //Закрываем соеденение с БД
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
            string query = "DELETE FROM Таблица2 WHERE ID= " + id;//строка запроса
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

        private void button1_Click(object sender, EventArgs e)
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
                dataGridView1.Rows[index].Cells[6].Value == null)
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

            //Создаем соеденение
            string connectionString = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=SystemDataBase.mdb";//строка соеденения
            OleDbConnection dbConnection = new OleDbConnection(connectionString);//создаем соеденение

            //Выполянем запрос к БД
            dbConnection.Open();//открываем соеденение
            string query = "UPDATE Таблица2 SET ФИО= '" + name + "',Выбранная_специальность='" + data + "',Законченное_образование='" + graj + "',Год_окончания = '" + sex + "',Изучаемый_язык = '"+homeA+"', Средний_балл = '"+number+"' WHERE ID = " + id;//строка запроса
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);//команда

            //Выполняем запрос
            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
                MessageBox.Show("Данные добавлены!", "Внимание!");

            //Закрываем соеденение с БД
            dbConnection.Close();
        }

        private void Образование_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    
}
