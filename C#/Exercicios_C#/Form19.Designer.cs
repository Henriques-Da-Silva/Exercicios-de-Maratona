namespace Exercicios_C_
{
    partial class Form19
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
            btnVoltar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNumero = new TextBox();
            txtInicio = new TextBox();
            txtFim = new TextBox();
            button1 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(12, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(252, 56);
            label1.Name = "label1";
            label1.Size = new Size(288, 32);
            label1.TabIndex = 1;
            label1.Text = "Montagem de Tabuadas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 114);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 2;
            label2.Text = "Montar a tabuada de: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F);
            label3.Location = new Point(275, 152);
            label3.Name = "label3";
            label3.Size = new Size(73, 13);
            label3.TabIndex = 3;
            label3.Text = "Começar por: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F);
            label4.Location = new Point(275, 186);
            label4.Name = "label4";
            label4.Size = new Size(68, 13);
            label4.TabIndex = 4;
            label4.Text = "Terminar em:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(404, 113);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 5;
            txtNumero.KeyPress += n1_KeyPress;
            // 
            // txtInicio
            // 
            txtInicio.Location = new Point(404, 148);
            txtInicio.Name = "txtInicio";
            txtInicio.Size = new Size(100, 23);
            txtInicio.TabIndex = 6;
            txtInicio.KeyPress += n1_KeyPress;
            // 
            // txtFim
            // 
            txtFim.Location = new Point(404, 182);
            txtFim.Name = "txtFim";
            txtFim.Size = new Size(100, 23);
            txtFim.TabIndex = 7;
            txtFim.KeyPress += n1_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(355, 223);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Montar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(355, 268);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 9;
            // 
            // Form19
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(txtFim);
            Controls.Add(txtInicio);
            Controls.Add(txtNumero);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVoltar);
            Name = "Form19";
            Text = "Form19";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNumero;
        private TextBox txtInicio;
        private TextBox txtFim;
        private Button button1;
        private Label label5;
    }
}