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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void n1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != '*' && e.KeyChar != '/')
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
            if (comboBox1.Text != "" && n2.Text != "" && n3.Text != "")
            {
                string operador = (comboBox1.Text).ToString();
                double num1 = double.Parse(n2.Text);
                double num2 = double.Parse(n3.Text);

                if (operador == "+")
                {
                    label2.Text = "Resultado: " + (num1+num2);
                }
                else if (operador == "-")
                {
                    label2.Text = "Resultado: " + (num1 - num2);
                }
                else if (operador == "*")
                {
                    label2.Text = "Resultado: " + (num1 * num2);
                }
                else if (operador == "/")
                {
                    if (num2 == 0)
                    {
                        MessageBox.Show("Erro: Divisão por zero!.");
                    }
                    else
                    {
                        label2.Text = "Resultado: " + (num1 / num2);
                    }
                }
                else {
                    MessageBox.Show("Operador Inválido.");
                }
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
