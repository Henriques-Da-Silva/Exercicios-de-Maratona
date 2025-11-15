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
    public partial class Form13 : Form
    {
        public Form13()
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

        List<int> lista_numeros = new List<int>();
        int i = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            string numero = textBox1.Text;
        
            if (i != 10)
            {
                lista_numeros.Add(int.Parse(numero));
                i++;

                label1.Text = "Digite o " + i.ToString() + "º número";
            }
            else {
                textBox1.Visible = false;   
                textBox2.Visible = true;   

                label1.Text = "Digite o número de comparação";

                if (textBox2.Text != "")
                {
                    int numero_comparacao = int.Parse(textBox2.Text);
                    int cont_numeros_inferiores = 0;

                    foreach (int num in lista_numeros)
                    {
                        if (num < numero_comparacao) { cont_numeros_inferiores++; }
                    }

                    label2.Text = "Foram digitados " + cont_numeros_inferiores.ToString() + " números inferiores a " + numero_comparacao;
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
