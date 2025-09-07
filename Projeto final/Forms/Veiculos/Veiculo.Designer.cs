using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Projeto_final.Forms.Veiculos
{
    partial class Veiculo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            Textnamecliente = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Textmarca = new TextBox();
            label3 = new Label();
            Textmodelo = new TextBox();
            label4 = new Label();
            Textplaca = new TextBox();
            label5 = new Label();
            Textanodefab = new TextBox();
            btnSalvar = new Button();

            SuspendLayout();

            // 
            // label1 - CPF do Cliente
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 40);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Regular);
            label1.Text = "CPF do Proprietário";

            // 
            // Textnamecliente
            // 
            Textnamecliente.Location = new Point(40, 65);
            Textnamecliente.Size = new Size(200, 27);
            Textnamecliente.Font = new System.Drawing.Font("Segoe UI", 10);

            // 
            // label2 - Marca
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 105);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.Font = new System.Drawing.Font("Segoe UI", 10);
            label2.Text = "Marca do Carro";

            // 
            // Textmarca
            // 
            Textmarca.Location = new Point(40, 130);
            Textmarca.Size = new Size(200, 27);
            Textmarca.Font = new System.Drawing.Font("Segoe UI", 10);

            // 
            // label3 - Modelo
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 170);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.Font = new System.Drawing.Font("Segoe UI", 10);
            label3.Text = "Modelo do Carro";

            // 
            // Textmodelo
            // 
            Textmodelo.Location = new Point(40, 195);
            Textmodelo.Size = new Size(200, 27);
            Textmodelo.Font = new System.Drawing.Font("Segoe UI", 10);

            // 
            // label4 - Placa
            // 
            label4.AutoSize = true;
            label4.Location = new Point(280, 40);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.Font = new System.Drawing.Font("Segoe UI", 10);
            label4.Text = "Placa Veículo";

            // 
            // Textplaca
            // 
            Textplaca.Location = new Point(280, 65);
            Textplaca.Size = new Size(150, 27);
            Textplaca.Font = new System.Drawing.Font("Segoe UI", 10);

            // 
            // label5 - Ano de Fabricação
            // 
            label5.AutoSize = true;
            label5.Location = new Point(280, 105);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.Font = new System.Drawing.Font("Segoe UI", 10);
            label5.Text = "Ano de Fabricação";

            // 
            // Textanodefab
            // 
            Textanodefab.Location = new Point(280, 130);
            Textanodefab.Size = new Size(150, 27);
            Textanodefab.Font = new System.Drawing.Font("Segoe UI", 10);

            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(280, 180);
            btnSalvar.Size = new Size(150, 35);
            btnSalvar.BackColor = Color.LightSteelBlue;
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Bold);
            btnSalvar.Text = "Salvar Veículo";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;

            // 
            // Veiculo Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 280);
            Controls.Add(label1);
            Controls.Add(Textnamecliente);
            Controls.Add(label2);
            Controls.Add(Textmarca);
            Controls.Add(label3);
            Controls.Add(Textmodelo);
            Controls.Add(label4);
            Controls.Add(Textplaca);
            Controls.Add(label5);
            Controls.Add(Textanodefab);
            Controls.Add(btnSalvar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Veiculo";
            Text = "Cadastro de Veículos";
            Load += Veiculo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Textnamecliente;
        private Label label1;
        private Label label2;
        private TextBox Textmarca;
        private Label label3;
        private TextBox Textmodelo;
        private Label label4;
        private TextBox Textplaca;
        private Label label5;
        private TextBox Textanodefab;
        private Button btnSalvar;
    }
}
