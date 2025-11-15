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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            for (int num = 1000; num <= 9999; num++)
            {
                string numero = num.ToString();

                int num1 = int.Parse(numero.Substring(0, 2));
                int num2 = int.Parse(numero.Substring(2, 2));

                int soma = num1 + num2;
                double resultado = Math.Pow(soma, 2);

                if (resultado == num)
                {
                    label2.Text += "\n" + num.ToString() + "\n";
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
