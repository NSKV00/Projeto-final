//namespace Projeto_final.Forms.OrdemServico
//{
//    partial class OS
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
//            SuspendLayout();
//            // 
//            // OS
//            // 
//            AutoScaleDimensions = new SizeF(10F, 25F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(800, 450);
//            Name = "OS";
//            Text = "OS";
//            Load += OS_Load;
//            ResumeLayout(false);
//        }

//        #endregion
//    }
//}


using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Xml.Linq;

namespace Projeto_final.Forms.OrdemServico
{
    partial class OS
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblCpfCliente;
        private TextBox txtCpfCliente;
        private Label lblPlacaVeiculo;
        private TextBox txtPlacaVeiculo;
        private Label lblCpfFuncionario;
        private TextBox txtCpfFuncionario;
        private Label lblProblema;
        private TextBox txtProblema;
        private Label lblServico;
        private TextBox txtServico;
        private Label lblData;
        private DateTimePicker dtpData;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
        private DataGridView dgvOS;
        private Label lblOS;


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
            lblCpfCliente = new Label();
            txtCpfCliente = new TextBox();
            lblPlacaVeiculo = new Label();
            txtPlacaVeiculo = new TextBox();
            lblCpfFuncionario = new Label();
            txtCpfFuncionario = new TextBox();
            lblProblema = new Label();
            txtProblema = new TextBox();
            lblServico = new Label();
            txtServico = new TextBox();
            lblData = new Label();
            dtpData = new DateTimePicker();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            dgvOS = new DataGridView();
            lblOS = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOS).BeginInit();
            SuspendLayout();
            // 
            // lblCpfCliente
            // 
            lblCpfCliente.AutoSize = true;
            lblCpfCliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblCpfCliente.Location = new Point(20, 80);
            lblCpfCliente.Name = "lblCpfCliente";
            lblCpfCliente.Size = new Size(95, 23);
            lblCpfCliente.Text = "CPF Cliente";
            // 
            // txtCpfCliente
            // 
            txtCpfCliente.Location = new Point(140, 78);
            txtCpfCliente.Size = new Size(200, 27);
            txtCpfCliente.Name = "txtCpfCliente";
            // 
            // lblPlacaVeiculo
            // 
            lblPlacaVeiculo.AutoSize = true;
            lblPlacaVeiculo.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblPlacaVeiculo.Location = new Point(380, 80);
            lblPlacaVeiculo.Name = "lblPlacaVeiculo";
            lblPlacaVeiculo.Size = new Size(112, 23);
            lblPlacaVeiculo.Text = "Placa Veículo";
            // 
            // txtPlacaVeiculo
            // 
            txtPlacaVeiculo.Location = new Point(500, 78);
            txtPlacaVeiculo.Size = new Size(200, 27);
            txtPlacaVeiculo.Name = "txtPlacaVeiculo";
            // 
            // lblCpfFuncionario
            // 
            lblCpfFuncionario.AutoSize = true;
            lblCpfFuncionario.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblCpfFuncionario.Location = new Point(20, 120);
            lblCpfFuncionario.Name = "lblCpfFuncionario";
            lblCpfFuncionario.Size = new Size(127, 23);
            lblCpfFuncionario.Text = "CPF Funcionário";
            // 
            // txtCpfFuncionario
            // 
            txtCpfFuncionario.Location = new Point(160, 118);
            txtCpfFuncionario.Size = new Size(200, 27);
            txtCpfFuncionario.Name = "txtCpfFuncionario";
            // 
            // lblProblema
            // 
            lblProblema.AutoSize = true;
            lblProblema.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblProblema.Location = new Point(20, 160);
            lblProblema.Name = "lblProblema";
            lblProblema.Size = new Size(79, 23);
            lblProblema.Text = "Problema";
            // 
            // txtProblema
            // 
            txtProblema.Location = new Point(120, 158);
            txtProblema.Multiline = true;
            txtProblema.Size = new Size(580, 50);
            txtProblema.Name = "txtProblema";
            // 
            // lblServico
            // 
            lblServico.AutoSize = true;
            lblServico.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblServico.Location = new Point(20, 220);
            lblServico.Name = "lblServico";
            lblServico.Size = new Size(64, 23);
            lblServico.Text = "Serviço";
            // 
            // txtServico
            // 
            txtServico.Location = new Point(120, 218);
            txtServico.Multiline = true;
            txtServico.Size = new Size(580, 50);
            txtServico.Name = "txtServico";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblData.Location = new Point(20, 280);
            lblData.Name = "lblData";
            lblData.Size = new Size(81, 23);
            lblData.Text = "Data OS";
            // 
            // dtpData
            // 
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(120, 278);
            dtpData.Size = new Size(200, 27);
            dtpData.Name = "dtpData";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(192, 255, 192);
            btnSalvar.Location = new Point(20, 320);
            btnSalvar.Size = new Size(90, 35);
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(255, 255, 192);
            btnEditar.Location = new Point(120, 320);
            btnEditar.Size = new Size(90, 35);
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(255, 192, 192);
            btnExcluir.Location = new Point(220, 320);
            btnExcluir.Size = new Size(90, 35);
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dgvOS
            // 
            dgvOS.AllowUserToAddRows = false;
            dgvOS.AllowUserToDeleteRows = false;
            dgvOS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOS.Dock = DockStyle.Bottom;
            dgvOS.Location = new Point(0, 380);
            dgvOS.Size = new Size(800, 200);
            dgvOS.Name = "dgvOS";
            dgvOS.ReadOnly = true;
            dgvOS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // lblOS
            // 
            lblOS.Font = new System.Drawing.Font("Segoe UI", 16F);
            lblOS.Location = new Point(20, 20);
            lblOS.Size = new Size(500, 40);
            lblOS.Text = "Emissão de Ordem de Serviço";
            // 
            // OS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 580);
            Controls.Add(lblOS);
            Controls.Add(lblCpfCliente);
            Controls.Add(txtCpfCliente);
            Controls.Add(lblPlacaVeiculo);
            Controls.Add(txtPlacaVeiculo);
            Controls.Add(lblCpfFuncionario);
            Controls.Add(txtCpfFuncionario);
            Controls.Add(lblProblema);
            Controls.Add(txtProblema);
            Controls.Add(lblServico);
            Controls.Add(txtServico);
            Controls.Add(lblData);
            Controls.Add(dtpData);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(dgvOS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Ordens de Serviço";
            Load += OS_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
    #endregion
}
