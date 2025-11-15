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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                string palavra1 = textBox1.Text;
                string palavra2 = textBox2.Text;

                if (palavra1 == palavra2)
                {
                    label2.Text = "AS PALAVRAS DIGITADAS SÃO IGUAIS.";
                }
                else
                {
                    if (palavra1.Length == palavra2.Length)
                    {
                        label2.Text = "As palavras digitas são diferentes, mas de igual comprimento.";
                    } else if (palavra1.Length > palavra2.Length)
                    {
                        label2.Text = "A primeira palavra tem maior comprimento.";
                    }
                    else
                    {
                        label2.Text = "A segunda palavra tem maior comprimento.";
                    }

                    if (palavra1.Contains(palavra2))
                    {
                        label2.Text += "\nA segunda palavra é subString da primeira.";
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os Campos!");
            }
        }
    }
}
