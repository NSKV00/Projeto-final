namespace Projeto_final.Forms.Funcionarios
{
    partial class Funcionario
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
            txtNome = new TextBox();
            lblContato = new Label();
            txtContato = new TextBox();
            lblCpf = new Label();
            txtCpf = new TextBox();
            btnSalvar = new Button();
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
            panelContainer.Controls.Add(btnSalvar);
            panelContainer.Controls.Add(btnEditar);
            panelContainer.Controls.Add(btnExcluir);
            panelContainer.Controls.Add(dgvFuncionarios);
            panelContainer.Location = new Point(12, 12);
            panelContainer.Name = "panelContainer";
            panelContainer.Padding = new Padding(14, 12, 14, 12);
            panelContainer.Size = new Size(600, 400);
            panelContainer.TabIndex = 0;

            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(33, 37, 41);
            lblTitulo.Location = new Point(20, 10);
            lblTitulo.Size = new Size(560, 40);
            lblTitulo.Text = "Cadastro de Funcionários";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 10F);
            lblNome.ForeColor = Color.FromArgb(55, 65, 81);
            lblNome.Location = new Point(20, 60);
            lblNome.Text = "Nome:";

            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 10F);
            txtNome.Location = new Point(20, 80);
            txtNome.Size = new Size(250, 25);

            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Font = new Font("Segoe UI", 10F);
            lblContato.ForeColor = Color.FromArgb(55, 65, 81);
            lblContato.Location = new Point(290, 60);
            lblContato.Text = "Contato:";

            // 
            // txtContato
            // 
            txtContato.Font = new Font("Segoe UI", 10F);
            txtContato.Location = new Point(290, 80);
            txtContato.Size = new Size(250, 25);

            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Segoe UI", 10F);
            lblCpf.ForeColor = Color.FromArgb(55, 65, 81);
            lblCpf.Location = new Point(20, 115);
            lblCpf.Text = "CPF:";

            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Segoe UI", 10F);
            txtCpf.Location = new Point(20, 135);
            txtCpf.Size = new Size(250, 25);

            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalvar.BackColor = Color.FromArgb(72, 168, 255);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(290, 135);
            btnSalvar.Size = new Size(80, 27);
            btnSalvar.Text = "Cadastrar";
            btnSalvar.Click += btnSalvar_Click;

            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEditar.BackColor = Color.LightGoldenrodYellow;
            btnEditar.Location = new Point(380, 135);
            btnEditar.Size = new Size(80, 27);
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;

            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExcluir.BackColor = Color.LightCoral;
            btnExcluir.Location = new Point(470, 135);
            btnExcluir.Size = new Size(80, 27);
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;

            // 
            // dgvFuncionarios
            // 
            dgvFuncionarios.Location = new Point(20, 175);
            dgvFuncionarios.Size = new Size(560, 200);
            dgvFuncionarios.ReadOnly = true;
            dgvFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFuncionarios.MultiSelect = false;
            dgvFuncionarios.AllowUserToAddRows = false;

            // 
            // Form Funcionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(630, 430);
            Controls.Add(panelContainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Funcionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão de Funcionários";
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
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
        private DataGridView dgvFuncionarios;
    }
}
