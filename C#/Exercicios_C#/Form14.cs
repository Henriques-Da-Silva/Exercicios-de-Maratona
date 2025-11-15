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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void n1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsAsciiLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string[] lista_nomes = textBox1.Text.Split(' ');
                string[] abreviaturas = new string[lista_nomes.Length];

                int i = 0;
                foreach (string nome in lista_nomes)
                {
                    if (nome.Length > 2)
                    {
                        abreviaturas[i] = nome[0].ToString().ToUpper() + ".";
                        i++;
                    } 
                    else
                    {
                        abreviaturas[i] = nome;
                        i++;
                    }
                }

                label2.Text = "";
                foreach (string abrv in abreviaturas)
                {
                    label2.Text += abrv + " ";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
