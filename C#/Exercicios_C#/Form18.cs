using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios_C_
{
    public partial class Form18 : Form
    {
        public Form18()
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
        
        int numero_divisoes = 0;

        bool VerificarPrimos(int n)
        {
            if (n <= 1) { return false; }
            if (n == 2) { return true; }

            for (int i = 2; i < n; i++)
            {
                numero_divisoes++;
                if (n % i == 0) {  return false; }
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";

            if (textBox1.Text != "")
            {
                int fim = int.Parse(textBox1.Text);
                for (int i = 0; i <= fim; i++)
                {
                    if (VerificarPrimos(i))
                    {
                        label2.Text += i.ToString() + " é primo.\n";
                    }
                }
                label2.Text += "\n\nForam executadas " + numero_divisoes.ToString() + " divisões.";
            }
            else
            {
                MessageBox.Show("Digite o Número limite.");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
