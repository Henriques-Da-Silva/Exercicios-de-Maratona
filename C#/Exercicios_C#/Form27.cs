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
    public partial class Form27 : Form
    {
        public Form27()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        Dictionary<int, int> code_Horas_Professores_M = new Dictionary<int, int>();
        Dictionary<int, int> code_Horas_Professores_F = new Dictionary<int, int>();

        private void button2_Click(object sender, EventArgs e)
        {
            if (code.Value != 0 && sexo.Text != "" && horas.Value != 0)
            {
                if (sexo.Text == "M")
                {
                    code_Horas_Professores_M.Add((int)code.Value, (int)horas.Value);
                    code.Value = 0;
                    horas.Value = 0;
                }
                else if (sexo.Text == "F")
                {
                    code_Horas_Professores_F.Add((int)code.Value, (int)horas.Value);
                    code.Value = 0;
                    horas.Value = 0;
                }
                else { MessageBox.Show("Sexo Inválido."); }
            } 
            else if (code.Value == 99999)
            {
                if (code_Horas_Professores_M.Count > 0)
                {
                    foreach (var profM in code_Horas_Professores_M)
                    {
                        double salarioBruto = profM.Value * 30;
                        double salarioLiquido = salarioBruto - (salarioBruto * 0.1);

                        label9.Text += profM.Key.ToString() + "\n";
                        label10.Text += salarioBruto.ToString() + "\n";
                        label11.Text += salarioLiquido.ToString() + "\n";
                    }
                }
                if (code_Horas_Professores_F.Count > 0)
                {
                    foreach (var profF in code_Horas_Professores_F)
                    {
                        double salarioBruto = profF.Value * 30;
                        double salarioLiquido = salarioBruto - (salarioBruto * 0.1);

                        label9.Text += profF.Key.ToString() + "\n";
                        label10.Text += salarioBruto.ToString() + "\n";
                        label11.Text += salarioLiquido.ToString() + "\n";
                    }
                }

            } else { MessageBox.Show("Preencha todos os campos."); }
        }
    }
}
