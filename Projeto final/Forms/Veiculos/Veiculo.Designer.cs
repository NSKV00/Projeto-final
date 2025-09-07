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
            panelContainer = new Panel();
            lblTitulo = new Label();

            lblCpfCliente = new Label();
            Textnamecliente = new TextBox();

            lblMarca = new Label();
            Textmarca = new TextBox();

            lblModelo = new Label();
            Textmodelo = new TextBox();

            lblPlaca = new Label();
            Textplaca = new TextBox();

            lblAno = new Label();
            Textanodefab = new TextBox();

            btnSalvar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();

            dgvVeiculos = new DataGridView();

            panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVeiculos).BeginInit();
            SuspendLayout();

            // 
            // panelContainer
            // 
            panelContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContainer.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            panelContainer.BorderStyle = BorderStyle.FixedSingle;
            panelContainer.Controls.Add(lblTitulo);

            panelContainer.Controls.Add(lblCpfCliente);
            panelContainer.Controls.Add(Textnamecliente);

            panelContainer.Controls.Add(lblMarca);
            panelContainer.Controls.Add(Textmarca);

            panelContainer.Controls.Add(lblModelo);
            panelContainer.Controls.Add(Textmodelo);

            panelContainer.Controls.Add(lblPlaca);
            panelContainer.Controls.Add(Textplaca);

            panelContainer.Controls.Add(lblAno);
            panelContainer.Controls.Add(Textanodefab);

            panelContainer.Controls.Add(btnSalvar);
            panelContainer.Controls.Add(btnEditar);
            panelContainer.Controls.Add(btnExcluir);

            panelContainer.Controls.Add(dgvVeiculos);

            panelContainer.Location = new System.Drawing.Point(10, 10);
            panelContainer.Size = new System.Drawing.Size(760, 400);
            panelContainer.Padding = new Padding(10);

            // 
            // lblTitulo
            // 
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblTitulo.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            lblTitulo.Location = new System.Drawing.Point(200, 10);
            lblTitulo.Size = new System.Drawing.Size(350, 40);
            lblTitulo.Text = "Cadastro de Veículos";
            lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblCpfCliente
            // 
            lblCpfCliente.AutoSize = true;
            lblCpfCliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblCpfCliente.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            lblCpfCliente.Location = new System.Drawing.Point(20, 70);
            lblCpfCliente.Text = "CPF do Cliente:";

            // 
            // Textnamecliente
            // 
            Textnamecliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            Textnamecliente.Location = new System.Drawing.Point(20, 95);
            Textnamecliente.Size = new System.Drawing.Size(180, 25);

            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblMarca.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            lblMarca.Location = new System.Drawing.Point(220, 70);
            lblMarca.Text = "Marca:";

            // 
            // Textmarca
            // 
            Textmarca.Font = new System.Drawing.Font("Segoe UI", 10F);
            Textmarca.Location = new System.Drawing.Point(220, 95);
            Textmarca.Size = new System.Drawing.Size(150, 25);

            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblModelo.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            lblModelo.Location = new System.Drawing.Point(400, 70);
            lblModelo.Text = "Modelo:";

            // 
            // Textmodelo
            // 
            Textmodelo.Font = new System.Drawing.Font("Segoe UI", 10F);
            Textmodelo.Location = new System.Drawing.Point(400, 95);
            Textmodelo.Size = new System.Drawing.Size(150, 25);

            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblPlaca.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            lblPlaca.Location = new System.Drawing.Point(580, 70);
            lblPlaca.Text = "Placa:";

            // 
            // Textplaca
            // 
            Textplaca.Font = new System.Drawing.Font("Segoe UI", 10F);
            Textplaca.Location = new System.Drawing.Point(580, 95);
            Textplaca.Size = new System.Drawing.Size(150, 25);

            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblAno.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            lblAno.Location = new System.Drawing.Point(20, 135);
            lblAno.Text = "Ano de Fabricação:";

            // 
            // Textanodefab
            // 
            Textanodefab.Font = new System.Drawing.Font("Segoe UI", 10F);
            Textanodefab.Location = new System.Drawing.Point(20, 160);
            Textanodefab.Size = new System.Drawing.Size(180, 25);

            // 
            // Botões
            // 
            btnSalvar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnSalvar.BackColor = System.Drawing.Color.LightSteelBlue;
            btnSalvar.Location = new System.Drawing.Point(220, 155);
            btnSalvar.Size = new System.Drawing.Size(120, 30);
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;

            btnEditar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnEditar.BackColor = System.Drawing.Color.LightGreen;
            btnEditar.Location = new System.Drawing.Point(360, 155);
            btnEditar.Size = new System.Drawing.Size(120, 30);
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;

            btnExcluir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnExcluir.BackColor = System.Drawing.Color.IndianRed;
            btnExcluir.Location = new System.Drawing.Point(500, 155);
            btnExcluir.Size = new System.Drawing.Size(120, 30);
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;

            // 
            // dgvVeiculos
            // 
            dgvVeiculos.Location = new System.Drawing.Point(20, 210);
            dgvVeiculos.Size = new System.Drawing.Size(710, 170);
            dgvVeiculos.ReadOnly = true;
            dgvVeiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVeiculos.MultiSelect = false;
            dgvVeiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // Veiculo Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(780, 420);
            Controls.Add(panelContainer);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Veiculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Veículos";

            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVeiculos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContainer;
        private Label lblTitulo;

        private Label lblCpfCliente;
        private TextBox Textnamecliente;

        private Label lblMarca;
        private TextBox Textmarca;

        private Label lblModelo;
        private TextBox Textmodelo;

        private Label lblPlaca;
        private TextBox Textplaca;

        private Label lblAno;
        private TextBox Textanodefab;

        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;

        private DataGridView dgvVeiculos;
    }
}
