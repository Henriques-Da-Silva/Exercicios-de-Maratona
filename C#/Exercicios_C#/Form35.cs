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
    public partial class Form35 : Form
    {
        public Form35()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int i = 1;
        int n = 0;
        Dictionary<string, double> list_func = new Dictionary<string, double>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Número de funcionários Inválido!");
            }
            else
            {
                n = (int)numericUpDown1.Value;
                numericUpDown1.Enabled = false;
                button1.Enabled = false;
                textBox1.Enabled = true;
                button3.Enabled = true;
                numericUpDown2.Enabled = true;

                label1.Text = "Funcionário " + i.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && numericUpDown2.Value != 0)
            {
                if (i <= n)
                {
                    list_func[textBox1.Text] = (double)numericUpDown2.Value;
                    textBox1.Text = "";
                    numericUpDown2.Value = 0;

                    i++;
                    label1.Text = "Funcionário " + i.ToString();
                }
                if (i > n)
                {
                    label4.Text = "";
                    double media = Math.Round(list_func.Values.Average(), 2);
                    double salarioAlto = list_func.Values.Max();
                    double salarioBaixo = list_func.Values.Min();

                    label4.Text += "Média dos Salários: " + media.ToString();
                    label4.Text += "\nSalário Mais Alto: " + salarioAlto.ToString() + " Nome: " + (list_func.FirstOrDefault(par => par.Value == salarioAlto).Key).ToString();
                    label4.Text += "\nSalário Mais Baixo: " + salarioBaixo.ToString() + " Nome: " + (list_func.FirstOrDefault(par => par.Value == salarioBaixo).Key).ToString();
                }
            }
            else{ MessageBox.Show("Preencha bem os campos!"); }
        }
    }
}
