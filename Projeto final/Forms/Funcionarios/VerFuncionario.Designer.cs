namespace Projeto_final.Forms.Funcionarios
{
    partial class VerFuncionario
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewFuncionarios;
        private Button btnCarregarFuncionarios;
        private Label lblTitulo;

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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewFuncionarios = new DataGridView();
            this.btnCarregarFuncionarios = new Button();
            this.lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(776, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Lista de Funcionários";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCarregarFuncionarios
            // 
            this.btnCarregarFuncionarios.Location = new System.Drawing.Point(320, 70);
            this.btnCarregarFuncionarios.Name = "btnCarregarFuncionarios";
            this.btnCarregarFuncionarios.Size = new System.Drawing.Size(160, 35);
            this.btnCarregarFuncionarios.TabIndex = 1;
            this.btnCarregarFuncionarios.Text = "Recarregar";
            this.btnCarregarFuncionarios.UseVisualStyleBackColor = true;
            this.btnCarregarFuncionarios.Click += new System.EventHandler(this.btnCarregarFuncionarios_Click);
            // 
            // dataGridViewFuncionarios
            // 
            this.dataGridViewFuncionarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                        | System.Windows.Forms.AnchorStyles.Left)
                                                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFuncionarios.Location = new System.Drawing.Point(12, 120);
            this.dataGridViewFuncionarios.Name = "dataGridViewFuncionarios";
            this.dataGridViewFuncionarios.RowHeadersVisible = false;
            this.dataGridViewFuncionarios.RowTemplate.Height = 28;
            this.dataGridViewFuncionarios.Size = new System.Drawing.Size(776, 318);
            this.dataGridViewFuncionarios.TabIndex = 2;
            // 
            // VerFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewFuncionarios);
            this.Controls.Add(this.btnCarregarFuncionarios);
            this.Controls.Add(this.lblTitulo);
            this.Name = "VerFuncionario";
            this.Text = "Ver Funcionários";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionarios)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
