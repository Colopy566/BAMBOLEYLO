using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BamboleyLO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "НАЧАТЬ";
            this.Text = "Угадай число";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Компьютер загадывает число от 1 до 100," +
                " а вы пытаетесь его угадать за минимальное число попыток");
            var f = new Form2();
            f.Show();

        }
    }
}
