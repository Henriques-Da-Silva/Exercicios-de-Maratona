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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void n1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text != "" && txtInicio.Text != "" && txtFim.Text != "")
            {
                label5.Text = "";

                int num = int.Parse(txtNumero.Text);
                int inicio = int.Parse(txtInicio.Text);
                int fim = int.Parse(txtFim.Text); 
                
                if (inicio < fim)
                {
                    for (int i = inicio; i <= fim; i++)
                    {
                        label5.Text += num.ToString() + " x " + i.ToString() + " = " + (num * i).ToString() + "\n";
                    }
                }
                else { MessageBox.Show("Fim não pode ser menor ou igual que o início."); }
            }
            else { MessageBox.Show("Preencha todos os campos."); }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
