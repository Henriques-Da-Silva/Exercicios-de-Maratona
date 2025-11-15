namespace Exercicios_C_
{
    partial class Form3
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
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            n1 = new TextBox();
            n2 = new TextBox();
            n3 = new TextBox();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(310, 67);
            label1.Name = "label1";
            label1.Size = new Size(182, 30);
            label1.TabIndex = 0;
            label1.Text = "Cálculo da Média";
            // 
            // button1
            // 
            button1.Location = new Point(522, 111);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(340, 161);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 5;
            // 
            // n1
            // 
            n1.Location = new Point(204, 111);
            n1.Name = "n1";
            n1.PlaceholderText = "Nota 1";
            n1.Size = new Size(100, 23);
            n1.TabIndex = 6;
            n1.KeyPress += n1_KeyPress;
            // 
            // n2
            // 
            n2.Location = new Point(310, 111);
            n2.Name = "n2";
            n2.PlaceholderText = "Nota 2";
            n2.Size = new Size(100, 23);
            n2.TabIndex = 7;
            n2.KeyPress += n2_KeyPress;
            // 
            // n3
            // 
            n3.Location = new Point(416, 111);
            n3.Name = "n3";
            n3.PlaceholderText = "Nota 3";
            n3.Size = new Size(100, 23);
            n3.TabIndex = 8;
            n3.KeyPress += n3_KeyPress;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(12, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 9;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(n3);
            Controls.Add(n2);
            Controls.Add(n1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox n1;
        private TextBox n2;
        private TextBox n3;
        private Button btnVoltar;
    }
}