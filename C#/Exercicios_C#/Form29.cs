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
    public partial class Form29 : Form
    {
        public Form29()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form29_Load(object sender, EventArgs e)
        {
            int[] valores = {12, -5, 7, 0, -3, 18, 25, -10, 4, -1, 9, 6, -8, 15, -12, 3, 11, -7, 2, 5,-4, 13, -6, 8, 10, -9, 14, -2, 1, 17,-11, 20, -13, 19, -14, 16, -15, 21, -16, 22, -17, 23, -18, 24, -19, 26, -20, 27, -21, 28};

            int somaPositivos = 0;
            int qtdNegativos = 0;

            foreach (int num in valores)
            {
                if (num > 0)
                {
                    somaPositivos += num;
                }
                else if (num < 0)
                {
                    qtdNegativos++;
                }
            }

            label1.Text += string.Join(", ", valores);
            label2.Text = $"Soma dos números positivos: {somaPositivos}\n" +
                          $"Quantidade de valores negativos: {qtdNegativos}";

        }
    }
}
