namespace Projeto_final.Forms.Funcionarios
{
    partial class Funcionario
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
            lblContato = new Label();
            txtContato = new TextBox();
            lblCpf = new Label();
            txtCpf = new TextBox();
            btnCadastrar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            dgvFuncionarios = new DataGridView();
            panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).BeginInit();
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
            panelContainer.Controls.Add(lblContato);
            panelContainer.Controls.Add(txtContato);
            panelContainer.Controls.Add(lblCpf);
            panelContainer.Controls.Add(txtCpf);
            panelContainer.Controls.Add(btnCadastrar);
            panelContainer.Controls.Add(btnEditar);
            panelContainer.Controls.Add(btnExcluir);
            panelContainer.Controls.Add(dgvFuncionarios);
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
            lblTitulo.Location = new Point(200, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(300, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cadastro de Funcionários";
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
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 25);
            txtNome.TabIndex = 2;
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Font = new Font("Segoe UI", 10F);
            lblContato.Location = new Point(240, 55);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(62, 19);
            lblContato.TabIndex = 3;
            lblContato.Text = "Contato:";
            // 
            // txtContato
            // 
            txtContato.Font = new Font("Segoe UI", 10F);
            txtContato.Location = new Point(240, 75);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(150, 25);
            txtContato.TabIndex = 4;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Segoe UI", 10F);
            lblCpf.Location = new Point(410, 55);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(36, 19);
            lblCpf.TabIndex = 5;
            lblCpf.Text = "CPF:";
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Segoe UI", 10F);
            txtCpf.Location = new Point(410, 75);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(150, 25);
            txtCpf.TabIndex = 6;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(72, 168, 255);
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(20, 110);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(180, 30);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(255, 193, 7);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(220, 110);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(180, 30);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(220, 53, 69);
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(420, 110);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(180, 30);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dgvFuncionarios
            // 
            dgvFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFuncionarios.Location = new Point(20, 150);
            dgvFuncionarios.MultiSelect = false;
            dgvFuncionarios.Name = "dgvFuncionarios";
            dgvFuncionarios.ReadOnly = true;
            dgvFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFuncionarios.Size = new Size(650, 220);
            dgvFuncionarios.TabIndex = 10;
            dgvFuncionarios.SelectionChanged += dgvFuncionarios_SelectionChanged;
            // 
            // Funcionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(730, 430);
            Controls.Add(panelContainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Funcionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Funcionários";
            Load += Funcionario_Load;
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContainer;
        private Label lblTitulo;
        private Label lblNome;
        private Label lblContato;
        private Label lblCpf;
        private TextBox txtNome;
        private TextBox txtContato;
        private TextBox txtCpf;
        private Button btnCadastrar;
        private Button btnEditar;
        private Button btnExcluir;
        private DataGridView dgvFuncionarios;
    }
}
