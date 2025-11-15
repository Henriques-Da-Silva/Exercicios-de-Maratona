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
    public partial class Form24 : Form
    {
        public Form24()
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int baseN = int.Parse(textBox1.Text);

                if (baseN < 5 || baseN > 15)
                {
                    MessageBox.Show("Digite um número entre 5 e 15.");
                    return;
                }

                string resultado = "";
                for (int i = 1; i <= baseN; i += 2)
                {
                    resultado += new string('#', i) + "\n";
                }

                label2.Text = resultado;

            }
        }
    }
}
