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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        List<int> lista_numeros = new List<int>();

        private void n1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (textBox1.Text != "")
            {
                int numero = int.Parse(textBox1.Text);

                if (numero >= 0)
                {
                    lista_numeros.Add(numero);
                    textBox1.Text = "";
                }
                else
                {
                    int soma = 0;

                    if (lista_numeros.Count != 0)
                    {
                        foreach (int num in lista_numeros)
                        {
                            soma += num;
                        }

                        double media = soma / lista_numeros.Count;
                        label2.Text = "Média: " + media;
                        lista_numeros.Clear();

                        textBox1.Text = "";
                    }
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
