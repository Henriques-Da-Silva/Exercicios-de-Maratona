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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tempo_segundos = int.Parse(textBox1.Text);
            int horas = 0;
            int minutos = 0;

            if (tempo_segundos >= 3600)
            {
                horas = (int)(tempo_segundos / 3600);
                tempo_segundos -= (horas * 3600);
            }
            if (tempo_segundos >= 60)
            {
                minutos = (int)(tempo_segundos / 60);
                tempo_segundos -= (minutos * 60);
            }

            label2.Text = horas + " Horas\n" + minutos + " Minutos\n" + tempo_segundos + " Segundos";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}