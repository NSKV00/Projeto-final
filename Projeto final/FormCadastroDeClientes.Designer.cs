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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(460, 77);
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
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(649, 246);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 2;
            label3.Text = "telefone";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(478, 246);
            label4.Name = "label4";
            label4.Size = new Size(40, 25);
            label4.TabIndex = 3;
            label4.Text = "cep";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(88, 142);
            label5.Name = "label5";
            label5.Size = new Size(226, 169);
            label5.TabIndex = 4;
            label5.Text = "Cadastro de \r\nclientes\r\n";
            // 
            // txtCpf
            // 
            txtCpf.Anchor = AnchorStyles.None;
            txtCpf.Location = new Point(622, 142);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(150, 31);
            txtCpf.TabIndex = 14;
            txtCpf.TextChanged += txtCpf_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.None;
            txtNome.Location = new Point(426, 142);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(150, 31);
            txtNome.TabIndex = 10;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtCep
            // 
            txtCep.Anchor = AnchorStyles.None;
            txtCep.Location = new Point(426, 291);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(150, 31);
            txtCep.TabIndex = 7;
            txtCep.TextChanged += txtCep_TextChanged;
            // 
            // txtTelefone
            // 
            txtTelefone.Anchor = AnchorStyles.None;
            txtTelefone.Location = new Point(622, 291);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(150, 31);
            txtTelefone.TabIndex = 8;
            txtTelefone.TextChanged += txtTelefone_TextChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(484, 370);
            button1.Name = "button1";
            button1.Size = new Size(241, 34);
            button1.TabIndex = 9;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(671, 77);
            label6.Name = "label6";
            label6.Size = new Size(37, 25);
            label6.TabIndex = 13;
            label6.Text = "cpf";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label5);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 468);
            panel1.TabIndex = 15;
            // 
            // FormCadastroDeClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(txtTelefone);
            Controls.Add(txtCep);
            Controls.Add(txtNome);
            Controls.Add(txtCpf);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCadastroDeClientes";
            Text = "FormCadastro";
            panel1.ResumeLayout(false);
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
        private Panel panel1;
    }
}