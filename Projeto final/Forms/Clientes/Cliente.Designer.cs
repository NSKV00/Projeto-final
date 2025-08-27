//namespace Projeto_final.Forms.Clientes
//{
//    partial class Cliente
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(800, 450);
//            this.Text = "Cliente";
//        }

//        #endregion
//    }
//}

using Org.BouncyCastle.Asn1.Crmf;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Projeto_final.Forms.Clientes
{
    partial class Cliente
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCpf = new TextBox();
            txtNome = new TextBox();
            txtCep = new TextBox();
            txtTelefone = new TextBox();
            button1 = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 107);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 0;
            label1.Text = "nome";
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(565, 270);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 2;
            label3.Text = "telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 270);
            label4.Name = "label4";
            label4.Size = new Size(40, 25);
            label4.TabIndex = 3;
            label4.Text = "cep";
            // 
            // label5
            // 
            label5.Font = new System.Drawing.Font("Segoe UI", 17F);
            label5.Location = new Point(219, 19);
            label5.Name = "label5";
            label5.Size = new Size(336, 46);
            label5.TabIndex = 4;
            label5.Text = "Cadastro de clientes";
            // A
            // txtCpf
            // 
            txtCpf.Location = new Point(525, 155);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(150, 31);
            txtCpf.TabIndex = 14;
            txtCpf.TextChanged += txtCpf_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(116, 155);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(150, 31);
            txtNome.TabIndex = 10;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(116, 313);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(150, 31);
            txtCep.TabIndex = 7;
            txtCep.TextChanged += txtCep_TextChanged;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(525, 313);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(150, 31);
            txtTelefone.TabIndex = 8;
            txtTelefone.TextChanged += txtTelefone_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(291, 380);
            button1.Name = "button1";
            button1.Size = new Size(241, 34);
            button1.TabIndex = 9;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(585, 112);
            label6.Name = "label6";
            label6.Size = new Size(37, 25);
            label6.TabIndex = 13;
            label6.Text = "cpf";
            // 
            // FormCadastroDeClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(txtTelefone);
            Controls.Add(txtCep);
            Controls.Add(txtNome);
            Controls.Add(txtCpf);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCadastroDeClientes";
            Text = "FormCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCpf;
        private TextBox txtNome;
        private TextBox txtCep;
        private TextBox txtTelefone;
        private Button button1;
        private Label label6;
    }
}