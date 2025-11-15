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
    public partial class Form31 : Form
    {
        public Form31()
        {
            InitializeComponent();
        }

        private void Form31_Load(object sender, EventArgs e)
        {
            StringBuilder resultado = new StringBuilder();
            int soma = 0;

            for (int i = 85; i >= 31; i--)
            {
                if (i % 2 == 0)
                {
                    resultado.Append(i + " ");
                    soma += i;
                }
            }

            resultado.AppendLine();
            resultado.AppendLine($"Soma dos pares: {soma}");

            label2.Text = resultado.ToString();
        }
    }
}