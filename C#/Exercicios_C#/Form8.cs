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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            int quantidade = 15;
            int[] sequencia_fibonacci = new int[quantidade];

            if (quantidade >= 1) { sequencia_fibonacci[0] = 0; }
            if (quantidade >= 2) { sequencia_fibonacci[1] = 1; }

            for (int i = 2; i < quantidade; i++)
            {
                int novo = sequencia_fibonacci[i - 1] + sequencia_fibonacci[i - 2];
                sequencia_fibonacci[i] = novo;
            }

            foreach (int num in sequencia_fibonacci)
            {
                label2.Text += num.ToString() + "\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
