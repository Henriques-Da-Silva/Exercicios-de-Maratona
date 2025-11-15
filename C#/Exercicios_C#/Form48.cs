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
    public partial class Form48 : Form
    {
        public Form48()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int i = 1;
        Dictionary<string, double> list_func = new Dictionary<string, double>();

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower() == "fim")
            {
                label4.Text = "";
                double media = Math.Round(list_func.Values.Average(), 2);
                double salarioAlto = list_func.Values.Max();
                double salarioBaixo = list_func.Values.Min();

                label6.Text += "Média dos Salários: " + media.ToString();
                label6.Text += "\nSalário Mais Alto: " + salarioAlto.ToString() + " Nome: " + (list_func.FirstOrDefault(par => par.Value == salarioAlto).Key).ToString();
                label6.Text += "\nSalário Mais Baixo: " + salarioBaixo.ToString() + " Nome: " + (list_func.FirstOrDefault(par => par.Value == salarioBaixo).Key).ToString();

                return;
            }
            if (textBox1.Text != "" && numericUpDown2.Value != 0)
            {
                list_func[textBox1.Text] = (double)numericUpDown2.Value;
                textBox1.Text = "";
                numericUpDown2.Value = 0;

                i++;
                label5.Text = "Funcionário " + i.ToString();
            }
            else { MessageBox.Show("Preencha bem os campos!"); }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
