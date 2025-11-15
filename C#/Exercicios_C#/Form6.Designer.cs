namespace Exercicios_C_
{
    partial class Form6
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
            n3 = new TextBox();
            n2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            btnVoltar = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // n3
            // 
            n3.Location = new Point(416, 220);
            n3.Name = "n3";
            n3.PlaceholderText = "Valor 2";
            n3.Size = new Size(100, 23);
            n3.TabIndex = 26;
            n3.KeyPress += n3_KeyPress;
            // 
            // n2
            // 
            n2.Location = new Point(310, 220);
            n2.Name = "n2";
            n2.PlaceholderText = "Valor 1";
            n2.Size = new Size(100, 23);
            n2.TabIndex = 25;
            n2.KeyPress += n2_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(340, 270);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 23;
            // 
            // button1
            // 
            button1.Location = new Point(522, 220);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 22;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(280, 161);
            label1.Name = "label1";
            label1.Size = new Size(227, 30);
            label1.TabIndex = 21;
            label1.Text = "Operação Matemática";
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(12, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 27;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBox1.Location = new Point(204, 221);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 28;
            comboBox1.KeyPress += n1_KeyPress;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(btnVoltar);
            Controls.Add(n3);
            Controls.Add(n2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox n3;
        private TextBox n2;
        private Label label2;
        private Button button1;
        private Label label1;
        private Button btnVoltar;
        private ComboBox comboBox1;
    }
}