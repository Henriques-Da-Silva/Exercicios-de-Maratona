namespace Exercicios_C_
{
    partial class Form4
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
            n1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // n3
            // 
            n3.Location = new Point(416, 215);
            n3.Name = "n3";
            n3.PlaceholderText = "Lado 3";
            n3.Size = new Size(100, 23);
            n3.TabIndex = 14;
            n3.KeyPress += n3_KeyPress;
            // 
            // n2
            // 
            n2.Location = new Point(310, 215);
            n2.Name = "n2";
            n2.PlaceholderText = "Lado 2";
            n2.Size = new Size(100, 23);
            n2.TabIndex = 13;
            n2.KeyPress += n2_KeyPress;
            // 
            // n1
            // 
            n1.Location = new Point(204, 215);
            n1.Name = "n1";
            n1.PlaceholderText = "Lado 1";
            n1.Size = new Size(100, 23);
            n1.TabIndex = 12;
            n1.KeyPress += n1_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(340, 265);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(522, 215);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Determinar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 159);
            label1.Name = "label1";
            label1.Size = new Size(278, 30);
            label1.TabIndex = 9;
            label1.Text = "Determinação de Triângulo";
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(12, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 15;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // Form4
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
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox n3;
        private TextBox n2;
        private TextBox n1;
        private Label label2;
        private Button button1;
        private Label label1;
        private Button btnVoltar;
    }
}