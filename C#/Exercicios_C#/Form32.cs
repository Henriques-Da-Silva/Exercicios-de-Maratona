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
    public partial class Form32 : Form
    {
        public Form32()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form32_Load(object sender, EventArgs e)
        {
            int grãos = 1;

            for (int i = 1; i < 64; i++)
            {
                grãos += grãos * 2;
            }

            label1.Text += grãos.ToString() + " grãos.";
        }
    }
}
