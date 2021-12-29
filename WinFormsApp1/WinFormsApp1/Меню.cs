using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Меню : Form
    {
        public Меню()
        {
            InitializeComponent();
        }

        private void Меню_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();//переход на другую форму
            fm.Owner = this;
            fm.Show();
            Hide();
        }

        private void prvtbuss_Click(object sender, EventArgs e)
        {
            Личное_дело ld = new Личное_дело();//переход на другую форму
            ld.Owner = this;
            ld.Show();
            Hide();
        }

        private void inform_Click(object sender, EventArgs e)
        {
            Образование ob = new Образование ();
            ob.Owner = this;
            ob.Show();
            Hide();
        }
    }
}
