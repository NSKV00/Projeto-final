namespace Projeto_final.Forms.OrdemServico
{
    partial class OS
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

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblProblema = new System.Windows.Forms.Label();
            this.lblServico = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();

            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbVeiculo = new System.Windows.Forms.ComboBox();
            this.cmbFuncionario = new System.Windows.Forms.ComboBox();

            this.txtProblema = new System.Windows.Forms.TextBox();
            this.txtServico = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();

            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFecharOS = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();

            this.dgvOS = new System.Windows.Forms.DataGridView();

            // Filtros
            this.lblFiltroCliente = new System.Windows.Forms.Label();
            this.lblFiltroVeiculo = new System.Windows.Forms.Label();
            this.lblFiltroStatus = new System.Windows.Forms.Label();
            this.lblFiltroPeriodo = new System.Windows.Forms.Label();

            this.cmbFiltroCliente = new System.Windows.Forms.ComboBox();
            this.cmbFiltroVeiculo = new System.Windows.Forms.ComboBox();
            this.cmbFiltroStatus = new System.Windows.Forms.ComboBox();
            this.dtpFiltroInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFiltroFim = new System.Windows.Forms.DateTimePicker();

            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).BeginInit();
            this.SuspendLayout();

            // --------------------- CONTROLES PRINCIPAIS ---------------------
            // lblCliente
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(30, 30);
            this.lblCliente.Text = "Cliente";
            // cmbCliente
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.Location = new System.Drawing.Point(120, 27);
            this.cmbCliente.Size = new System.Drawing.Size(220, 28);

            // lblVeiculo
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Location = new System.Drawing.Point(380, 30);
            this.lblVeiculo.Text = "Veículo";
            // cmbVeiculo
            this.cmbVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVeiculo.Location = new System.Drawing.Point(460, 27);
            this.cmbVeiculo.Size = new System.Drawing.Size(220, 28);

            // lblFuncionario
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(30, 75);
            this.lblFuncionario.Text = "Funcionário";
            // cmbFuncionario
            this.cmbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncionario.Location = new System.Drawing.Point(120, 72);
            this.cmbFuncionario.Size = new System.Drawing.Size(220, 28);

            // lblProblema
            this.lblProblema.AutoSize = true;
            this.lblProblema.Location = new System.Drawing.Point(30, 120);
            this.lblProblema.Text = "Problema";
            // txtProblema
            this.txtProblema.Location = new System.Drawing.Point(120, 117);
            this.txtProblema.Multiline = true;
            this.txtProblema.Size = new System.Drawing.Size(560, 60);

            // lblServico
            this.lblServico.AutoSize = true;
            this.lblServico.Location = new System.Drawing.Point(30, 190);
            this.lblServico.Text = "Serviço";
            // txtServico
            this.txtServico.Location = new System.Drawing.Point(120, 187);
            this.txtServico.Multiline = true;
            this.txtServico.Size = new System.Drawing.Size(560, 60);

            // lblData
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(30, 260);
            this.lblData.Text = "Data OS";
            // dtpData
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(120, 257);
            this.dtpData.Size = new System.Drawing.Size(220, 27);

            // --------------------- BOTOES PRINCIPAIS ---------------------
            this.btnSalvar.Location = new System.Drawing.Point(120, 310);
            this.btnSalvar.Size = new System.Drawing.Size(100, 35);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);

            this.btnEditar.Location = new System.Drawing.Point(240, 310);
            this.btnEditar.Size = new System.Drawing.Size(100, 35);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);

            this.btnExcluir.Location = new System.Drawing.Point(360, 310);
            this.btnExcluir.Size = new System.Drawing.Size(100, 35);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);

            this.btnFecharOS.Location = new System.Drawing.Point(480, 310);
            this.btnFecharOS.Size = new System.Drawing.Size(120, 35);
            this.btnFecharOS.Text = "Fechar OS";
            this.btnFecharOS.Click += new System.EventHandler(this.btnFecharOS_Click);

            // --------------------- DATAGRID ---------------------
            this.dgvOS.Location = new System.Drawing.Point(30, 400);
            this.dgvOS.Size = new System.Drawing.Size(650, 200);
            this.dgvOS.ReadOnly = true;
            this.dgvOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // --------------------- FILTROS ---------------------
            // lblFiltroCliente
            this.lblFiltroCliente.AutoSize = true;
            this.lblFiltroCliente.Location = new System.Drawing.Point(30, 620);
            this.lblFiltroCliente.Text = "Cliente";
            // cmbFiltroCliente
            this.cmbFiltroCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroCliente.Location = new System.Drawing.Point(90, 617);
            this.cmbFiltroCliente.Size = new System.Drawing.Size(150, 28);

            // lblFiltroVeiculo
            this.lblFiltroVeiculo.AutoSize = true;
            this.lblFiltroVeiculo.Location = new System.Drawing.Point(250, 620);
            this.lblFiltroVeiculo.Text = "Veículo";
            // cmbFiltroVeiculo
            this.cmbFiltroVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroVeiculo.Location = new System.Drawing.Point(310, 617);
            this.cmbFiltroVeiculo.Size = new System.Drawing.Size(150, 28);

            // lblFiltroStatus
            this.lblFiltroStatus.AutoSize = true;
            this.lblFiltroStatus.Location = new System.Drawing.Point(470, 620);
            this.lblFiltroStatus.Text = "Status";
            // cmbFiltroStatus
            this.cmbFiltroStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroStatus.Items.AddRange(new object[] { "Todas", "Aberta", "Fechada" });
            this.cmbFiltroStatus.Location = new System.Drawing.Point(520, 617);
            this.cmbFiltroStatus.Size = new System.Drawing.Size(100, 28);

            // lblFiltroPeriodo
            this.lblFiltroPeriodo.AutoSize = true;
            this.lblFiltroPeriodo.Location = new System.Drawing.Point(30, 660);
            this.lblFiltroPeriodo.Text = "Período";
            // dtpFiltroInicio
            this.dtpFiltroInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltroInicio.Location = new System.Drawing.Point(90, 655);
            this.dtpFiltroInicio.Size = new System.Drawing.Size(120, 27);
            // dtpFiltroFim
            this.dtpFiltroFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltroFim.Location = new System.Drawing.Point(220, 655);
            this.dtpFiltroFim.Size = new System.Drawing.Size(120, 27);

            // btnFiltrar
            this.btnFiltrar.Location = new System.Drawing.Point(360, 652);
            this.btnFiltrar.Size = new System.Drawing.Size(100, 35);
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);

            // --------------------- FORM ---------------------
            this.ClientSize = new System.Drawing.Size(720, 720);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblVeiculo);
            this.Controls.Add(this.cmbVeiculo);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.cmbFuncionario);
            this.Controls.Add(this.lblProblema);
            this.Controls.Add(this.txtProblema);
            this.Controls.Add(this.lblServico);
            this.Controls.Add(this.txtServico);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dtpData);

            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnFecharOS);

            this.Controls.Add(this.dgvOS);

            this.Controls.Add(this.lblFiltroCliente);
            this.Controls.Add(this.cmbFiltroCliente);
            this.Controls.Add(this.lblFiltroVeiculo);
            this.Controls.Add(this.cmbFiltroVeiculo);
            this.Controls.Add(this.lblFiltroStatus);
            this.Controls.Add(this.cmbFiltroStatus);
            this.Controls.Add(this.lblFiltroPeriodo);
            this.Controls.Add(this.dtpFiltroInicio);
            this.Controls.Add(this.dtpFiltroFim);
            this.Controls.Add(this.btnFiltrar);

            this.Name = "OS";
            this.Text = "Ordem de Serviço";
            this.Load += new System.EventHandler(this.OS_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblProblema;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.Label lblData;

        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbVeiculo;
        private System.Windows.Forms.ComboBox cmbFuncionario;

        private System.Windows.Forms.TextBox txtProblema;
        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.DateTimePicker dtpData;

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnFecharOS;
        private System.Windows.Forms.Button btnFiltrar;

        private System.Windows.Forms.DataGridView dgvOS;

        // Filtros
        private System.Windows.Forms.Label lblFiltroCliente;
        private System.Windows.Forms.Label lblFiltroVeiculo;
        private System.Windows.Forms.Label lblFiltroStatus;
        private System.Windows.Forms.Label lblFiltroPeriodo;

        private System.Windows.Forms.ComboBox cmbFiltroCliente;
        private System.Windows.Forms.ComboBox cmbFiltroVeiculo;
        private System.Windows.Forms.ComboBox cmbFiltroStatus;
        private System.Windows.Forms.DateTimePicker dtpFiltroInicio;
        private System.Windows.Forms.DateTimePicker dtpFiltroFim;
    }
}
