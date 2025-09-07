namespace Projeto_final.Forms.Clientes
{
    partial class Cliente
    {
        private System.ComponentModel.IContainer components = null;

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
            panelContainer = new Panel();
            lblTitulo = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            lblCpf = new Label();
            txtCpf = new TextBox();
            lblCep = new Label();
            txtCep = new TextBox();
            lblTelefone = new Label();
            txtTelefone = new TextBox();
            btnCadastrar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            dgvClientes = new DataGridView();

            panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dgvClientes)).BeginInit();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContainer.BackColor = Color.FromArgb(245, 245, 245);
            panelContainer.BorderStyle = BorderStyle.FixedSingle;
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
            panelContainer.Controls.Add(btnEditar);
            panelContainer.Controls.Add(btnExcluir);
            panelContainer.Controls.Add(dgvClientes);
            panelContainer.Location = new Point(12, 12);
            panelContainer.Name = "panelContainer";
            panelContainer.Padding = new Padding(12);
            panelContainer.Size = new Size(700, 400);
            panelContainer.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(33, 37, 41);
            lblTitulo.Location = new Point(150, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(400, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cadastro de Clientes";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 10F);
            lblNome.Location = new Point(20, 55);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(49, 19);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 10F);
            txtNome.Location = new Point(20, 75);
            txtNome.Size = new Size(200, 25);
            txtNome.TabIndex = 2;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Segoe UI", 10F);
            lblCpf.Location = new Point(240, 55);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(36, 19);
            lblCpf.TabIndex = 3;
            lblCpf.Text = "CPF:";
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Segoe UI", 10F);
            txtCpf.Location = new Point(240, 75);
            txtCpf.Size = new Size(150, 25);
            txtCpf.TabIndex = 4;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 10F);
            lblTelefone.Location = new Point(410, 55);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(62, 19);
            lblTelefone.TabIndex = 5;
            lblTelefone.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 10F);
            txtTelefone.Location = new Point(410, 75);
            txtTelefone.Size = new Size(120, 25);
            txtTelefone.TabIndex = 6;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Font = new Font("Segoe UI", 10F);
            lblCep.Location = new Point(550, 55);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(36, 19);
            lblCep.TabIndex = 7;
            lblCep.Text = "CEP:";
            // 
            // txtCep
            // 
            txtCep.Font = new Font("Segoe UI", 10F);
            txtCep.Location = new Point(550, 75);
            txtCep.Size = new Size(120, 25);
            txtCep.TabIndex = 8;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(72, 168, 255);
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCadastrar.Location = new Point(20, 110);
            btnCadastrar.Size = new Size(200, 30);
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(255, 193, 7);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEditar.Location = new Point(240, 110);
            btnEditar.Size = new Size(200, 30);
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(220, 53, 69);
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExcluir.Location = new Point(460, 110);
            btnExcluir.Size = new Size(200, 30);
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.Location = new Point(20, 150);
            dgvClientes.Size = new Size(650, 220);
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.MultiSelect = false;
            dgvClientes.ReadOnly = true;
            dgvClientes.TabIndex = 12;
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;

            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(730, 430);
            Controls.Add(panelContainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Name = "Cliente";
            Text = "Cadastro de Clientes";
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(dgvClientes)).EndInit();
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
        private Button btnEditar;
        private Button btnExcluir;
        private DataGridView dgvClientes;
    }
}
