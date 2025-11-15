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
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form25_Load(object sender, EventArgs e)
        {
            int soma = 0;

            for (int i = 1; i  <= 500; i++)
            {
                if (i % 2 != 0)
                {
                    if (i % 3 == 0)
                    {
                        soma += i;
                    }
                }
            }

            label1.Text += soma.ToString();
        }
    }
}
