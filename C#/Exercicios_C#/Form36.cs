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
    public partial class Form36 : Form
    {
        public Form36()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int i = 1;
        List<int> list_nums = new List<int>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (i <= 10)
            {
                list_nums.Add((int)numericUpDown1.Value);
                numericUpDown1.Value = 0;
                i++;
                label1.Text = i.ToString() + "º Número: ";
            }
            if (i > 10)
            {
                label2.Text = "";
                double media = Math.Round(list_nums.Average(), 2);

                label2.Text += "Média: " + media.ToString();
                label2.Text += "\nMaior: " + (list_nums.Max()).ToString(); 
                label2.Text += "\nMenor: " + (list_nums.Min()).ToString(); 
            }
        }
    }
}
