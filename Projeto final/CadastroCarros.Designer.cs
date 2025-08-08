namespace Projeto_final
{
    partial class CadastroCarros
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Textnamecliente = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Textmarca = new TextBox();
            label3 = new Label();
            label4 = new Label();
            Textmodelo = new TextBox();
            Textplaca = new TextBox();
            label5 = new Label();
            Textanodefab = new TextBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // Textnamecliente
            // 
            Textnamecliente.Location = new Point(181, 81);
            Textnamecliente.Name = "Textnamecliente";
            Textnamecliente.Size = new Size(156, 27);
            Textnamecliente.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 58);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 1;
            label1.Text = "Nome do proprietário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 148);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 2;
            label2.Text = "Marca do carro";
            // 
            // Textmarca
            // 
            Textmarca.Location = new Point(181, 171);
            Textmarca.Name = "Textmarca";
            Textmarca.Size = new Size(156, 27);
            Textmarca.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(181, 232);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 4;
            label3.Text = "Modelo do carro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(521, 148);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 5;
            label4.Text = "Placa do veículo";
            // 
            // Textmodelo
            // 
            Textmodelo.Location = new Point(181, 255);
            Textmodelo.Name = "Textmodelo";
            Textmodelo.Size = new Size(156, 27);
            Textmodelo.TabIndex = 6;
            // 
            // Textplaca
            // 
            Textplaca.Location = new Point(521, 171);
            Textplaca.Name = "Textplaca";
            Textplaca.Size = new Size(156, 27);
            Textplaca.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(521, 58);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 8;
            label5.Text = "Ano de fabricação";
            // 
            // Textanodefab
            // 
            Textanodefab.Location = new Point(521, 93);
            Textanodefab.Name = "Textanodefab";
            Textanodefab.Size = new Size(149, 27);
            Textanodefab.TabIndex = 9;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Turquoise;
            btnSalvar.Location = new Point(667, 377);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 39);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // CadastroCarros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 471);
            Controls.Add(btnSalvar);
            Controls.Add(Textanodefab);
            Controls.Add(label5);
            Controls.Add(Textplaca);
            Controls.Add(Textmodelo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Textmarca);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Textnamecliente);
            Name = "CadastroCarros";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Textnamecliente;
        private Label label1;
        private Label label2;
        private TextBox Textmarca;
        private Label label3;
        private Label label4;
        private TextBox Textmodelo;
        private TextBox Textplaca;
        private Label label5;
        private TextBox Textanodefab;
        private Button btnSalvar;
    }
}
