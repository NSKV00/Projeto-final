namespace Projeto_final.Forms.Clientes
{
    partial class Cliente
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
            panelContainer = new Panel();
            lblTitulo = new Label();
            lblNome = new Label();
            lblCpf = new Label();
            lblCep = new Label();
            lblTelefone = new Label();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            txtCep = new TextBox();
            txtTelefone = new TextBox();
            btnCadastrar = new Button();

            panelContainer.SuspendLayout();
            SuspendLayout();

            // 
            // panelContainer
            // 
            panelContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContainer.BackColor = Color.FromArgb(245, 245, 245);
            panelContainer.BorderStyle = BorderStyle.FixedSingle;
            panelContainer.Padding = new Padding(20);
            panelContainer.Location = new Point(30, 20);
            panelContainer.Size = new Size(740, 400);
            panelContainer.Controls.Add(lblTitulo);
            panelContainer.Controls.Add(lblNome);
            panelContainer.Controls.Add(txtNome);
            panelContainer.Controls.Add(lblCpf);
            panelContainer.Controls.Add(txtCpf);
            panelContainer.Controls.Add(lblCep);
            panelContainer.Controls.Add(txtCep);
            panelContainer.Controls.Add(lblTelefone);
            panelContainer.Controls.Add(txtTelefone);
            panelContainer.Controls.Add(btnCadastrar);

            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(33, 37, 41);
            lblTitulo.Text = "Cadastro de Clientes";
            lblTitulo.Location = new Point(150, 10);
            lblTitulo.Size = new Size(450, 50);
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 10F);
            lblNome.ForeColor = Color.FromArgb(55, 65, 81);
            lblNome.Text = "Nome:";
            lblNome.Location = new Point(50, 80);

            // 
            // txtNome
            // 
            txtNome.Location = new Point(50, 105);
            txtNome.Size = new Size(300, 30);
            txtNome.Font = new Font("Segoe UI", 10F);
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.BorderStyle = BorderStyle.FixedSingle;

            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Segoe UI", 10F);
            lblCpf.ForeColor = Color.FromArgb(55, 65, 81);
            lblCpf.Text = "CPF:";
            lblCpf.Location = new Point(400, 80);

            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(400, 105);
            txtCpf.Size = new Size(250, 30);
            txtCpf.Font = new Font("Segoe UI", 10F);
            txtCpf.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCpf.BorderStyle = BorderStyle.FixedSingle;

            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Font = new Font("Segoe UI", 10F);
            lblCep.ForeColor = Color.FromArgb(55, 65, 81);
            lblCep.Text = "CEP:";
            lblCep.Location = new Point(50, 160);

            // 
            // txtCep
            // 
            txtCep.Location = new Point(50, 185);
            txtCep.Size = new Size(300, 30);
            txtCep.Font = new Font("Segoe UI", 10F);
            txtCep.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCep.BorderStyle = BorderStyle.FixedSingle;

            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 10F);
            lblTelefone.ForeColor = Color.FromArgb(55, 65, 81);
            lblTelefone.Text = "Telefone:";
            lblTelefone.Location = new Point(400, 160);

            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(400, 185);
            txtTelefone.Size = new Size(250, 30);
            txtTelefone.Font = new Font("Segoe UI", 10F);
            txtTelefone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTelefone.BorderStyle = BorderStyle.FixedSingle;

            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(200, 260);
            btnCadastrar.Size = new Size(300, 40);
            btnCadastrar.BackColor = Color.FromArgb(72, 168, 255);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCadastrar.Text = "Cadastrar Cliente";
            btnCadastrar.Click += button1_Click;
            btnCadastrar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // 
            // Cliente Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Cliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Clientes";

            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContainer;
        private Label lblTitulo;
        private Label lblNome;
        private Label lblCpf;
        private Label lblCep;
        private Label lblTelefone;
        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtCep;
        private TextBox txtTelefone;
        private Button btnCadastrar;
    }
}
