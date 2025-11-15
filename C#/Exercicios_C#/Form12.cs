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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private int SomaDivs(int number) {

            int soma = 0;

            for (int i = 1; i <= number/2; i++){
                if (number % i == 0)
                {
                    soma += i;
                }
            }
            return soma;
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            for (int num1 = 1; num1 <= 10000; num1++)
            {
                int soma1 = SomaDivs(num1);

                if (soma1 > num1) { 
                    int soma2 = SomaDivs(soma1);

                    if (soma2 == num1)
                    {
                        label2.Text += num1.ToString() + " e " + soma1.ToString() + " São amigos.\n";
                    }
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
