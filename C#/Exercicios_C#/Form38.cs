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
    public partial class Form38 : Form
    {
        public Form38()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                double massaInicial = (double)numericUpDown1.Value;
                int tempo = 0;
                double massa = massaInicial;

                while (massa >= 0.05)
                {
                    massa /= 2;
                    tempo += 50;
                }

                label1.Text = "";
                label1.Text = "Tempo: " + tempo.ToString() + " segundos.";
            }
        }
    }
}
