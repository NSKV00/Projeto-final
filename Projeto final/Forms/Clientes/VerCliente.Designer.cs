namespace Projeto_final.Forms.Clientes
{
    partial class VerCliente
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelContainer = new Panel();
            lblTitulo = new Label();
            btnCarregarClientes = new Button();
            dataGridViewClientes = new DataGridView();
            panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContainer.BackColor = Color.FromArgb(245, 245, 245);
            panelContainer.BorderStyle = BorderStyle.FixedSingle;
            panelContainer.Controls.Add(lblTitulo);
            panelContainer.Controls.Add(btnCarregarClientes);
            panelContainer.Controls.Add(dataGridViewClientes);
            panelContainer.Location = new Point(20, 20);
            panelContainer.Name = "panelContainer";
            panelContainer.Padding = new Padding(20);
            panelContainer.Size = new Size(760, 410);
            panelContainer.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(33, 37, 41);
            lblTitulo.Location = new Point(180, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(400, 50);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Lista de Clientes";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCarregarClientes
            // 
            btnCarregarClientes.Anchor = AnchorStyles.Top;
            btnCarregarClientes.BackColor = Color.FromArgb(72, 168, 255);
            btnCarregarClientes.FlatAppearance.BorderSize = 0;
            btnCarregarClientes.FlatStyle = FlatStyle.Flat;
            btnCarregarClientes.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCarregarClientes.ForeColor = Color.White;
            btnCarregarClientes.Location = new Point(280, 70);
            btnCarregarClientes.Name = "btnCarregarClientes";
            btnCarregarClientes.Size = new Size(200, 40);
            btnCarregarClientes.TabIndex = 1;
            btnCarregarClientes.Text = "Carregar Clientes";
            btnCarregarClientes.UseVisualStyleBackColor = false;
            btnCarregarClientes.Click += btnCarregarClientes_Click;
            // 
            // dataGridViewClientes
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 230, 230);
            dataGridViewClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClientes.BackgroundColor = Color.White;
            dataGridViewClientes.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewClientes.ColumnHeadersHeight = 34;
            dataGridViewClientes.EnableHeadersVisualStyles = false;
            dataGridViewClientes.Location = new Point(20, 130);
            dataGridViewClientes.MultiSelect = false;
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.ReadOnly = true;
            dataGridViewClientes.RowHeadersWidth = 62;
            dataGridViewClientes.RowTemplate.Height = 30;
            dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClientes.Size = new Size(720, 250);
            dataGridViewClientes.TabIndex = 2;
            // 
            // VerCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "VerCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            Load += VerCliente_Load;
            panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContainer;
        private Label lblTitulo;
        private Button btnCarregarClientes;
        private DataGridView dataGridViewClientes;
    }
}
