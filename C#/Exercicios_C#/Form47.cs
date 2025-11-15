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
    public partial class Form47 : Form
    {
        public Form47()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && numericUpDown1.Value != 0 && numericUpDown2.Value != 0 && numericUpDown3.Value != 0 && numericUpDown4.Value != 0)
            {
                string nome1 = textBox1.Text;
                string nome2 = textBox2.Text;
                double altura1 = (int)numericUpDown1.Value;
                double altura2 = (int)numericUpDown4.Value;
                double peso1 = (int)numericUpDown2.Value;
                double peso2 = (int)numericUpDown3.Value;

                string maisPesada = peso1 > peso2 ? nome1 : nome2;
                double maiorPeso = peso1 > peso2 ? peso1 : peso2;

                string maisAlta = altura1 > altura2 ? nome1 : nome2;
                double maiorAltura = altura1 > altura2 ? altura1 : altura2;
                
                label9.Text += "\nMais pesada: " + maisPesada + " com " + maiorPeso.ToString() + " kg";
                label9.Text += "\n Mais alta: " + maisAlta + " com " + maiorAltura.ToString() + "m";
            }
            else { MessageBox.Show("Preencha todos os campos!"); }
        }
    }
}
