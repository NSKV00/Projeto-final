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
            lblContato = new Label();
            lblCpf = new Label();
            txtNome = new TextBox();
            txtContato = new TextBox();
            txtCpf = new TextBox();
            btnSalvar = new Button();

            panelContainer.SuspendLayout();
            SuspendLayout();

            // 
            // panelContainer
            // 
            panelContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContainer.BackColor = Color.FromArgb(245, 245, 245);
            panelContainer.BorderStyle = BorderStyle.FixedSingle;
            panelContainer.Padding = new Padding(20);
            panelContainer.Location = new Point(50, 30);
            panelContainer.Size = new Size(600, 380);
            panelContainer.Controls.Add(lblTitulo);
            panelContainer.Controls.Add(lblNome);
            panelContainer.Controls.Add(txtNome);
            panelContainer.Controls.Add(lblContato);
            panelContainer.Controls.Add(txtContato);
            panelContainer.Controls.Add(lblCpf);
            panelContainer.Controls.Add(txtCpf);
            panelContainer.Controls.Add(btnSalvar);

            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(33, 37, 41);
            lblTitulo.Location = new Point(50, 20);
            lblTitulo.Size = new Size(500, 50);
            lblTitulo.Text = "Cadastro de Funcionário";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.ForeColor = Color.FromArgb(55, 65, 81);
            lblNome.Location = new Point(50, 100);
            lblNome.Text = "Nome:";

            // 
            // txtNome
            // 
            txtNome.Location = new Point(50, 125);
            txtNome.Size = new Size(500, 30);
            txtNome.Font = new Font("Segoe UI", 10F);
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Font = new Font("Segoe UI", 10F);
            lblContato.ForeColor = Color.FromArgb(55, 65, 81);
            lblContato.Location = new Point(50, 170);
            lblContato.Text = "Contato:";

            // 
            // txtContato
            // 
            txtContato.Location = new Point(50, 195);
            txtContato.Size = new Size(500, 30);
            txtContato.Font = new Font("Segoe UI", 10F);
            txtContato.BorderStyle = BorderStyle.FixedSingle;
            txtContato.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Segoe UI", 10F);
            lblCpf.ForeColor = Color.FromArgb(55, 65, 81);
            lblCpf.Location = new Point(50, 240);
            lblCpf.Text = "CPF:";

            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(50, 265);
            txtCpf.Size = new Size(500, 30);
            txtCpf.Font = new Font("Segoe UI", 10F);
            txtCpf.BorderStyle = BorderStyle.FixedSingle;
            txtCpf.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(50, 320);
            btnSalvar.Size = new Size(500, 40);
            btnSalvar.BackColor = Color.FromArgb(72, 168, 255);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSalvar.Text = "Cadastrar Funcionário";
            btnSalvar.Click += btnSalvar_Click;
            btnSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // 
            // Funcionario Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 450);
            Controls.Add(panelContainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Funcionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Funcionário";

            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
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
    }
}
