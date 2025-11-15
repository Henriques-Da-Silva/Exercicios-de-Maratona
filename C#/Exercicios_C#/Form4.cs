using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Exercicios_C_
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void n1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void n2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void n3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (n1.Text != "" && n2.Text != "" && n3.Text != "")
            {
                int a = int.Parse(n1.Text);
                int b = int.Parse(n2.Text);
                int c = int.Parse(n3.Text);

                if (a + b > c && a + c > b && b + c > a)
                {
                    if (a == b && a == c && b == c)
                    {
                        label2.Text = "Triângulo Equiláleto.";
                    }
                    else if (a == b || a == c || b == c)
                    {
                        label2.Text = "Triângulo Isósceles.";
                    }
                    else
                    {
                        label2.Text = "Triângulo Escaleno.";
                    }
                }
                else
                {
                    label2.Text = "Não formam um Triângulo.";
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
