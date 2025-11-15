using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercicios_C_
{
    public partial class Form49 : Form
    {
        public Form49()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero = (double)numericUpDown1.Value;

            if (numero <= 0)
            {
                MessageBox.Show("O número deve ser maior que zero.");
                return;
            }

            int contador = 0;

            while (numero >= 1)
            {
                numero /= 2;
                contador++;
            }

            label2.Text = "";
            label2.Text += "Resultado final: " + numero.ToString();
            label2.Text += "\nTotal de divisões: " + contador.ToString();
        }
    }
}
