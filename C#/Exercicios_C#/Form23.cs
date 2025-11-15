using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exercicios_C_
{
    public partial class Form23 : Form
    {
        public Form23()
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

        int i = 1;
        List<int> list_numeros = new List<int>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                i++;
                if (i < 21)
                {
                    list_numeros.Add(int.Parse(textBox1.Text));
                    label1.Text = "Digite o " + i.ToString() + "º número: ";
                    textBox1.Text = "";
                }
                else
                {
                    label2.Text = "O maior valor digitado foi: " + (list_numeros.Max()).ToString() + "\nPosição: " + (list_numeros.IndexOf(list_numeros.Max())+1).ToString();
                }
            }
            else { MessageBox.Show("Preencha o campo."); }
        }
    }
}
