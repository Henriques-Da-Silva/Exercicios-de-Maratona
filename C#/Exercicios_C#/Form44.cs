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
    public partial class Form44 : Form
    {
        public Form44()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        List<int> numeros = new List<int>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0)
            {
                int n = (int)numericUpDown1.Value;
                if (n == 9999)
                {
                    if (numeros.Count != 0)
                    {
                        int[] pares = numeros.Where(n => n % 2 == 0).ToArray();
                        int[] impares = numeros.Where(n => n % 2 != 0).ToArray();

                        label2.Text = "";
                        label2.Text += "Pares = " + pares.Length.ToString();
                        label2.Text += "\nImpares = " + impares.Length.ToString();
                    }
                }
                else
                {
                    numeros.Add(n);
                    numericUpDown1.Value = 0;
                }
            }
            else { MessageBox.Show("Digite um número!"); }
        }
    }
}
