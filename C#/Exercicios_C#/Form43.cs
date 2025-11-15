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
    public partial class Form43 : Form
    {
        public Form43()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = (int)numericUpDown1.Value;
            int num2 = (int)numericUpDown2.Value;

            if (num1 < 0 || num2 <= 0){ MessageBox.Show("Ambos os números devem ser inteiros positivos e o divisor maior que zero."); return; }

            int quociente = 0;
            int resto = num1;

            while (resto >= num2)
            {
                resto -= num2;
                quociente++;
            }

            label4.Text = "";
            label4.Text += "Quociente = " + quociente.ToString();
            label4.Text += "\nResto = " + resto.ToString();
        }
    }
}
