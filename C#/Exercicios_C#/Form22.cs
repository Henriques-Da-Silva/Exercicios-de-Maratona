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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int i = 1;
        List<string> list_nomes = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                i++;
                if (i < 11)
                {
                    list_nomes.Add(textBox1.Text);
                    label1.Text = "Digite o nome da " + i.ToString() + "ª pessoa: ";
                    textBox1.Text = "";
                }
                else
                {
                    textBox1.Visible = false;
                    textBox2.Visible = true;

                    label1.Text = "Digite o outro nome: ";
                    if (textBox2.Text != "")
                    {
                        if (list_nomes.Contains(textBox2.Text)) { label2.Text = "ACHEI!"; }
                        else { label2.Text = "NÃO ACHEI."; }
                    }
                    else { MessageBox.Show("Preencha o campo."); }
                }
            }
            else { MessageBox.Show("Preencha o campo."); }
        }
    }
}
