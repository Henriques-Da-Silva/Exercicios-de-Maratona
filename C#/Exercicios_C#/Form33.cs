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
    public partial class Form33 : Form
    {
        public Form33()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form33_Load(object sender, EventArgs e)
        {
            Dictionary<int, List<double>> alunos = new Dictionary<int, List<double>>();
            Random rnd = new Random();

            for (int i = 0; i < 45; i++)
            {
                int idade = rnd.Next(17, 26);
                double altura = Math.Round(rnd.NextDouble() * 0.5 + 1.5, 2);

                if (!alunos.ContainsKey(idade))
                {
                    alunos[idade] = new List<double>();
                }

                alunos[idade].Add(altura);
            }

            List<int> idadesMenoresDe170 = new List<int>();

            List<double> alturasMaioresQue20 = new List<double>();

            foreach (var par in alunos)
            {
                int idade = par.Key;
                foreach (double altura in par.Value)
                {
                    if (altura < 1.70)
                    {
                        idadesMenoresDe170.Add(idade);
                    }

                    if (idade > 20)
                    {
                        alturasMaioresQue20.Add(altura);
                    }
                }
            }

            double media1 = idadesMenoresDe170.Count > 0 ? Math.Round(idadesMenoresDe170.Average(), 2) : 0;
            double media2 = alturasMaioresQue20.Count > 0 ? Math.Round(alturasMaioresQue20.Average(), 2) : 0;

            label1.Text += media1.ToString();
            label2.Text += media2.ToString();
        }
    }
}
