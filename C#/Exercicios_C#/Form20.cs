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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";

            char[] vogais = ['a', 'e', 'i', 'o', 'u'];
            char[] digits = ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'];
            int n_vogais = 0;
            int n_digits = 0;

            if (textBox1.Text != "")
            {
                string texto = textBox1.Text;
                string texto_invertido = new string(texto.Reverse().ToArray());

                label2.Text += "A palavra contém " + (texto.Length).ToString() + " caracteres\n";
                label2.Text += "Palavra em maiúscula: " + texto.ToUpper();

                foreach (char caracter in texto)
                {
                    if (vogais.Contains(caracter)) { n_vogais++; }
                }
                label2.Text += "\nA palavra contém: " + n_vogais.ToString() + " vogais.\n";

                if (texto.ToLower().StartsWith("uni"))
                {
                    label2.Text += "A palavra começa com UNI\n";
                }

                if (texto.ToLower().EndsWith("rio"))
                {
                    label2.Text += "A palavra termina com RIO\n";
                }

                foreach (char digito in texto)
                {
                    if (digits.Contains(digito)) { n_digits++; }
                }
                label2.Text += "\nA palavra contém: " + n_digits.ToString() + " dígitos.\n";

                if (texto.ToLower() == texto_invertido.ToLower())
                {
                    label2.Text += "A palavra é palíndromo.\n";
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
