namespace Projeto_final
{
    partial class FormCadastroDeClientes
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
            label1.Location = new Point(117, 86);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 0;
            label1.Text = "nome";
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 18);
            label2.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(452, 216);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(117, 216);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 3;
            label4.Text = "cep";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 17F);
            label5.Location = new Point(175, 15);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(269, 37);
            label5.TabIndex = 4;
            label5.Text = "Cadastro de clientes";
            label5.Click += label5_Click;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(420, 124);
            txtCpf.Margin = new Padding(2, 2, 2, 2);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(121, 27);
            txtCpf.TabIndex = 14;
            txtCpf.TextChanged += txtCpf_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(93, 124);
            txtNome.Margin = new Padding(2, 2, 2, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(121, 27);
            txtNome.TabIndex = 10;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(93, 250);
            txtCep.Margin = new Padding(2, 2, 2, 2);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(121, 27);
            txtCep.TabIndex = 7;
            txtCep.TextChanged += txtCep_TextChanged;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(420, 250);
            txtTelefone.Margin = new Padding(2, 2, 2, 2);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(121, 27);
            txtTelefone.TabIndex = 8;
            txtTelefone.TextChanged += txtTelefone_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(233, 304);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(193, 27);
            button1.TabIndex = 9;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(468, 90);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(30, 20);
            label6.TabIndex = 13;
            label6.Text = "cpf";
            // 
            // FormCadastroDeClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
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
            Margin = new Padding(2, 2, 2, 2);
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