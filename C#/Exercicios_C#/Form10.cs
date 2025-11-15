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
    public partial class Form10 : Form
    {
        public Form10()
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

        int segundos_timer1 = 0;
        int segundos_timer2 = 0;
        int tempo_aleatorio;
        int numero_aleatorio;

        private void Form10_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            tempo_aleatorio = random.Next(2, 6);
            numero_aleatorio = random.Next(1, 10);

            label2.Text = "Espere...";

            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos_timer1++;

            if (segundos_timer1 == tempo_aleatorio)
            {
                label2.Text = "Agora! Número: " + numero_aleatorio;
                button1.Enabled = true;
                timer1.Stop();

                timer2.Interval = 1000;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            segundos_timer2++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);
            int tempo = segundos_timer2;

            if (number == numero_aleatorio)
            {
                label3.Text = "Acertou o número🥳\nTempo: " + tempo;
            }
            else
            {
                label3.Text = "Número Errado!";
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
