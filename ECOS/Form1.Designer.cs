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
            lblLista = new Label();
            dgvOS = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblOS = new Label();
            Editar = new Button();
            ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOS).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            txtCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCliente.Location = new Point(95, 98);
            txtCliente.Margin = new Padding(3, 4, 3, 4);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(313, 27);
            txtCliente.TabIndex = 1;
            // 
            // lblData
            // 
            lblData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dtpData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(498, 100);
            dtpData.Margin = new Padding(3, 4, 3, 4);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(333, 27);
            dtpData.TabIndex = 3;
            // 
            // lblDescricao
            // 
            lblDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI", 10F);
            lblDescricao.Location = new Point(19, 142);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(83, 23);
            lblDescricao.TabIndex = 4;
            lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDescricao.Location = new Point(117, 141);
            txtDescricao.Margin = new Padding(3, 4, 3, 4);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(821, 30);
            txtDescricao.TabIndex = 5;
            // 
            // lblValor
            // 
            lblValor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 10F);
            lblValor.Location = new Point(19, 196);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(49, 23);
            lblValor.TabIndex = 6;
            lblValor.Text = "Valor";
            // 
            // numValor
            // 
            numValor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.Location = new Point(393, 197);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(56, 23);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Aberta", "Em Andamento", "Finalizada" });
            cmbStatus.Location = new Point(465, 196);
            cmbStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(336, 28);
            cmbStatus.TabIndex = 9;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            // lblLista
            // 
            lblLista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLista.AutoSize = true;
            lblLista.Font = new Font("Segoe UI", 15F);
            lblLista.Location = new Point(15, 294);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(321, 35);
            lblLista.TabIndex = 14;
            lblLista.Text = "Lista das Ordens de Serviço";
            // 
            // dgvOS
            // 
            dgvOS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOS.ColumnHeadersHeight = 29;
            dgvOS.Location = new Point(17, 332);
            dgvOS.Name = "dgvOS";
            dgvOS.RowHeadersWidth = 51;
            dgvOS.Size = new Size(993, 220);
            dgvOS.TabIndex = 19;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Cliente";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // lblOS
            // 
            lblOS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblOS.Font = new Font("Segoe UI", 20F);
            lblOS.Location = new Point(15, 23);
            lblOS.Name = "lblOS";
            lblOS.Size = new Size(635, 47);
            lblOS.TabIndex = 18;
            lblOS.Text = "Emissão e Controle da Ordem de Serviço";
            // 
            // Editar
            // 
            Editar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Editar.BackColor = Color.FromArgb(255, 255, 192);
            Editar.Location = new Point(117, 252);
            Editar.Name = "Editar";
            Editar.Size = new Size(85, 38);
            Editar.TabIndex = 21;
            Editar.Text = "Editar";
            Editar.UseVisualStyleBackColor = false;
            Editar.Click += Editar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 556);
            Controls.Add(Editar);
            Controls.Add(lblOS);
            Controls.Add(dgvOS);
            Controls.Add(lblLista);
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
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ECOS";
            Load += Form1_Load_1;
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
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.DataGridView dgvOS;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Label lblOS;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Cliente;
        private Button button1;
        private Button Editar;
    }
}
