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
    public partial class Form46 : Form
    {
        public Form46()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form46_Load(object sender, EventArgs e)
        {
            int termo = 3;
            int soma = 0;

            while (termo <= 6561)
            {
                label3.Text += termo.ToString() + ", ";
                soma += termo;
                termo *= 3;
            }
            label2.Text += soma.ToString();
        }
    }
}
