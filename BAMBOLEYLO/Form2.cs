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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Text = "Угадай число";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            Random rnd = new Random();
            int value = rnd.Next(1, 100);
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
            if (e.KeyChar == value)
            {
                label1.Text="Поздравляю ,ты угадал";
            }
            else label1.Text = "Попробуй еще раз";
        }
    }
}
