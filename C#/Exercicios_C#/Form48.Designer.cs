namespace Exercicios_C_
{
    partial class Form48
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
            button3 = new Button();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(378, 204);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 13;
            button3.Text = "Confirmar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(357, 175);
            numericUpDown2.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(152, 23);
            numericUpDown2.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(308, 177);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 11;
            label3.Text = "Salário: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(308, 139);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 10;
            label2.Text = "Nome:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(357, 136);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(239, 34);
            label1.Name = "label1";
            label1.Size = new Size(351, 30);
            label1.TabIndex = 14;
            label1.Text = "Preencha os dados do Funcionário";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(357, 77);
            label4.Name = "label4";
            label4.Size = new Size(129, 15);
            label4.TabIndex = 15;
            label4.Text = "Use \"fim\" para encerrar";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(369, 103);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 17;
            label5.Text = "Funcionário 1";
            // 
            // label6
            // 
            label6.Location = new Point(239, 239);
            label6.Name = "label6";
            label6.Size = new Size(351, 165);
            label6.TabIndex = 18;
            // 
            // Form48
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(numericUpDown2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Name = "Form48";
            Text = "Form48";
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private NumericUpDown numericUpDown2;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Label label4;
        private Button button1;
        private Label label5;
        private Label label6;
    }
}