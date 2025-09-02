namespace ControleOS
{
    partial class Form1
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
            lblCliente = new Label();
            txtCliente = new TextBox();
            lblData = new Label();
            dtpData = new DateTimePicker();
            lblDescricao = new Label();
            txtDescricao = new TextBox();
            lblValor = new Label();
            numValor = new NumericUpDown();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            btnSalvar = new Button();
            btnExcluir = new Button();
            lblLista = new Label();
            dgvOS = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnEditar = new Button();
            label1 = new Label();
            lblOS = new Label();
            ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOS).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 10F);
            lblCliente.Location = new Point(17, 102);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(63, 23);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(86, 98);
            txtCliente.Margin = new Padding(3, 4, 3, 4);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(313, 27);
            txtCliente.TabIndex = 1;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 10F);
            lblData.Location = new Point(446, 102);
            lblData.Name = "lblData";
            lblData.Size = new Size(46, 23);
            lblData.TabIndex = 2;
            lblData.Text = "Data";
            // 
            // dtpData
            // 
            dtpData.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(498, 98);
            dtpData.Margin = new Padding(3, 4, 3, 4);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(212, 27);
            dtpData.TabIndex = 3;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI", 10F);
            lblDescricao.Location = new Point(17, 141);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(83, 23);
            lblDescricao.TabIndex = 4;
            lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(117, 141);
            txtDescricao.Margin = new Padding(3, 4, 3, 4);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(669, 30);
            txtDescricao.TabIndex = 5;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 10F);
            lblValor.Location = new Point(17, 197);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(49, 23);
            lblValor.TabIndex = 6;
            lblValor.Text = "Valor";
            // 
            // numValor
            // 
            numValor.DecimalPlaces = 2;
            numValor.Location = new Point(86, 197);
            numValor.Margin = new Padding(3, 4, 3, 4);
            numValor.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numValor.Name = "numValor";
            numValor.Size = new Size(269, 27);
            numValor.TabIndex = 7;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.Location = new Point(384, 198);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(56, 23);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Aberta", "Em Andamento", "Finalizada" });
            cmbStatus.Location = new Point(458, 196);
            cmbStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(231, 28);
            cmbStatus.TabIndex = 9;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(192, 255, 192);
            btnSalvar.Location = new Point(17, 252);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(85, 38);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(255, 192, 192);
            btnExcluir.Location = new Point(199, 252);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(85, 38);
            btnExcluir.TabIndex = 16;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.Font = new Font("Segoe UI", 15F);
            lblLista.Location = new Point(17, 320);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(310, 35);
            lblLista.TabIndex = 14;
            lblLista.Text = "Lista de Ordens de Serviço";
            // 
            // dgvOS
            // 
            dgvOS.AllowUserToAddRows = false;
            dgvOS.AllowUserToDeleteRows = false;
            dgvOS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOS.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvOS.Dock = DockStyle.Bottom;
            dgvOS.Location = new Point(0, 368);
            dgvOS.Margin = new Padding(3, 4, 3, 4);
            dgvOS.Name = "dgvOS";
            dgvOS.ReadOnly = true;
            dgvOS.RowHeadersVisible = false;
            dgvOS.RowHeadersWidth = 51;
            dgvOS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOS.Size = new Size(798, 184);
            dgvOS.TabIndex = 15;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Cliente";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(255, 255, 192);
            btnEditar.Location = new Point(108, 252);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(85, 38);
            btnEditar.TabIndex = 17;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // lblOS
            // 
            lblOS.Font = new Font("Segoe UI", 20F);
            lblOS.Location = new Point(15, 23);
            lblOS.Name = "lblOS";
            lblOS.Size = new Size(502, 47);
            lblOS.TabIndex = 18;
            lblOS.Text = "Emissão de Ordem de Serviço";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 552);
            Controls.Add(lblOS);
            Controls.Add(label1);
            Controls.Add(dgvOS);
            Controls.Add(lblLista);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(numValor);
            Controls.Add(lblValor);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(dtpData);
            Controls.Add(lblData);
            Controls.Add(txtCliente);
            Controls.Add(lblCliente);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Emissão e Controle de OS";
            ((System.ComponentModel.ISupportInitialize)numValor).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.NumericUpDown numValor;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.DataGridView dgvOS;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button btnEditar;
        private Label label1;
        private Label lblOS;
    }
}
