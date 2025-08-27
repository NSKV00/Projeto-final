namespace Projeto_final.Forms.Funcionarios
{
    partial class Funcionario
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

        private void InitializeComponent()
        {
            labelTitulo = new Label();
            labelNome = new Label();
            labelContato = new Label();
            labelCpf = new Label();
            txtNome = new TextBox();
            txtContato = new TextBox();
            txtCpf = new TextBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitulo.Location = new Point(220, 20);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(336, 46);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Cadastro de Funcionários";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(120, 110);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(62, 25);
            labelNome.TabIndex = 1;
            labelNome.Text = "Nome:";
            // 
            // labelContato
            // 
            labelContato.AutoSize = true;
            labelContato.Location = new Point(120, 190);
            labelContato.Name = "labelContato";
            labelContato.Size = new Size(76, 25);
            labelContato.TabIndex = 2;
            labelContato.Text = "Contato:";
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Location = new Point(120, 270);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(42, 25);
            labelCpf.TabIndex = 3;
            labelCpf.Text = "CPF:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(220, 110);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(250, 31);
            txtNome.TabIndex = 4;
            // 
            // txtContato
            // 
            txtContato.Location = new Point(220, 190);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(250, 31);
            txtContato.TabIndex = 5;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(220, 270);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(250, 31);
            txtCpf.TabIndex = 6;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(220, 340);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(250, 40);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Cadastrar Funcionário";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // Funcionario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 450);
            Controls.Add(btnSalvar);
            Controls.Add(txtCpf);
            Controls.Add(txtContato);
            Controls.Add(txtNome);
            Controls.Add(labelCpf);
            Controls.Add(labelContato);
            Controls.Add(labelNome);
            Controls.Add(labelTitulo);
            Name = "Funcionario";
            Text = "Cadastro de Funcionários";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Label labelNome;
        private Label labelContato;
        private Label labelCpf;
        private TextBox txtNome;
        private TextBox txtContato;
        private TextBox txtCpf;
        private Button btnSalvar;
    }
}
