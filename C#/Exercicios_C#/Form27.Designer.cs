namespace Exercicios_C_
{
    partial class Form27
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            code = new NumericUpDown();
            sexo = new ComboBox();
            horas = new NumericUpDown();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)code).BeginInit();
            ((System.ComponentModel.ISupportInitialize)horas).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 99);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 138);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 3;
            label2.Text = "Sexo:";
            // 
            // code
            // 
            code.Location = new Point(365, 97);
            code.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            code.Name = "code";
            code.Size = new Size(120, 23);
            code.TabIndex = 5;
            // 
            // sexo
            // 
            sexo.FormattingEnabled = true;
            sexo.Items.AddRange(new object[] { "M", "F" });
            sexo.Location = new Point(364, 135);
            sexo.Name = "sexo";
            sexo.Size = new Size(121, 23);
            sexo.TabIndex = 6;
            sexo.Text = "M";
            // 
            // horas
            // 
            horas.Location = new Point(402, 175);
            horas.Name = "horas";
            horas.Size = new Size(120, 23);
            horas.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(286, 177);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 7;
            label3.Text = "Horas/aulas dadas: ";
            // 
            // button2
            // 
            button2.Location = new Point(354, 220);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Submeter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(242, 12);
            label4.Name = "label4";
            label4.Size = new Size(352, 32);
            label4.TabIndex = 10;
            label4.Text = "Folha de Sálario - Professores";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(344, 54);
            label5.Name = "label5";
            label5.Size = new Size(151, 15);
            label5.TabIndex = 11;
            label5.Text = "(Digite 99999 para encerrar)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(260, 260);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 12;
            label6.Text = "Código";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(365, 260);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 13;
            label7.Text = "Salário bruto(R$)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(500, 260);
            label8.Name = "label8";
            label8.Size = new Size(107, 15);
            label8.TabIndex = 14;
            label8.Text = "Salário líquido(R$)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(260, 289);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(385, 289);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(537, 289);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 17;
            // 
            // Form27
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(horas);
            Controls.Add(label3);
            Controls.Add(sexo);
            Controls.Add(code);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form27";
            Text = "Form27";
            ((System.ComponentModel.ISupportInitialize)code).EndInit();
            ((System.ComponentModel.ISupportInitialize)horas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private NumericUpDown code;
        private ComboBox sexo;
        private NumericUpDown horas;
        private Label label3;
        private Button button2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}