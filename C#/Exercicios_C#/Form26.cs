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
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();
        }

        private void n1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        List<int> list_numeros = new List<int>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                list_numeros.Add(int.Parse(textBox1.Text));
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Preencha o campo.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int soma = list_numeros.Sum();
            int total = list_numeros.Count;

            double media = soma / total;

            int positivos = list_numeros.Count(n => n > 0);
            int negativos = list_numeros.Count(n => n < 0);

            double percentual_positivos = ((double)positivos / total) * 100;
            double percentual_negativos = ((double)negativos / total) * 100;

            label2.Text = "";
            label2.Text += "Média: " + media.ToString();
            label2.Text += "\n" + positivos.ToString() + " Positivos\n";
            label2.Text += negativos.ToString() + " Negativos\n";
            label2.Text += "Percentual de Positivos: " + percentual_positivos.ToString() + "%\n";
            label2.Text += "Percentual de Negativos: " + percentual_negativos.ToString() + "%\n";
        }
    }
}
