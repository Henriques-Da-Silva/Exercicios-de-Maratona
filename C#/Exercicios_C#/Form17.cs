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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            double pop1 = 80000;
            double pop2 = 200000;
            double taxa1 = 0.03;
            double taxa2 = 0.015;
            int anos = 0;

            while (pop1 < pop2)
            {
                pop1 += (pop1*taxa1);
                pop2 += (pop2*taxa2);
                anos++;
            }

            label5.Text += anos.ToString();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
