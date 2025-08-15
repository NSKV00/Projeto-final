using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Projeto_final
{
    partial class Cveiculos
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
            Textnamecliente.Location = new Point(226, 101);
            Textnamecliente.Margin = new Padding(4);
            Textnamecliente.Name = "Textnamecliente";
            Textnamecliente.Size = new Size(194, 31);
            Textnamecliente.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 72);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(187, 25);
            label1.TabIndex = 1;
            label1.Text = "Nome do proprietário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 185);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 2;
            label2.Text = "Marca do carro";
            // 
            // Textmarca
            // 
            Textmarca.Location = new Point(226, 214);
            Textmarca.Margin = new Padding(4);
            Textmarca.Name = "Textmarca";
            Textmarca.Size = new Size(194, 31);
            Textmarca.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(226, 290);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 4;
            label3.Text = "Modelo do carro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(651, 185);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(139, 25);
            label4.TabIndex = 5;
            label4.Text = "Placa do veículo";
            // 
            // Textmodelo
            // 
            Textmodelo.Location = new Point(226, 319);
            Textmodelo.Margin = new Padding(4);
            Textmodelo.Name = "Textmodelo";
            Textmodelo.Size = new Size(194, 31);
            Textmodelo.TabIndex = 6;
            Textmodelo.TextChanged += Textmodelo_TextChanged;
            // 
            // Textplaca
            // 
            Textplaca.Location = new Point(651, 214);
            Textplaca.Margin = new Padding(4);
            Textplaca.Name = "Textplaca";
            Textplaca.Size = new Size(194, 31);
            Textplaca.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(651, 72);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(156, 25);
            label5.TabIndex = 8;
            label5.Text = "Ano de fabricação";
            // 
            // Textanodefab
            // 
            Textanodefab.Location = new Point(651, 116);
            Textanodefab.Margin = new Padding(4);
            Textanodefab.Name = "Textanodefab";
            Textanodefab.Size = new Size(185, 31);
            Textanodefab.TabIndex = 9;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.DarkGray;
            btnSalvar.Location = new Point(1520, 560);
            btnSalvar.Margin = new Padding(4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(140, 49);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // Cveiculos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1709, 624);
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
            Margin = new Padding(4);
            Name = "Cveiculos";
            Text = "Form1";
            Load += Cveiculos_Load;
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