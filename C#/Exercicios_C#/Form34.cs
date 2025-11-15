using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios_C_
{
    public partial class Form34 : Form
    {
        public Form34()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";

            int numero = (int)numericUpDown1.Value;

            for (int i = 1; i <= 13; i++)
            {
                label2.Text += numero.ToString() + " x " + i.ToString() + " = " + (numero * i) + "\n";
            }
        }
    }
}
