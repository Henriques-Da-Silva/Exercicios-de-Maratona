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
    public partial class Form39 : Form
    {
        public Form39()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = (int)numericUpDown1.Value;
            int n2 = (int)numericUpDown2.Value;
            int soma = 0;

            for (int i = 0; i < n2; i++)
            {
                soma += n1;
            }

            label3.Text = soma.ToString();
        }
    }
}
