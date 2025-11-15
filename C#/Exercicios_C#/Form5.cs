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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void n1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
        private void n2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
        private void n3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (n1.Text != "" && n2.Text != "" && n3.Text != "")
            {
                double a = double.Parse(n1.Text);
                double b = double.Parse(n2.Text);
                double c = double.Parse(n3.Text);

                double[] numeros = new double[3];
                numeros[0] = a;
                numeros[1] = b;
                numeros[2] = c;

                Array.Sort(numeros);
                Array.Reverse(numeros);

                label2.Text = "Maior: " + numeros[0] + "\nIntermediário: " + numeros[1] + "\nMenor: " + numeros[2];
            }
            else
            {
                MessageBox.Show("Preencha todos os Campos.");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
