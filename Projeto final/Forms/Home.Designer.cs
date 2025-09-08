namespace Projeto_final
{
    partial class Home
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
            painelLateral = new Panel();
            btnFuncionarios = new Button();
            btnOS = new Button();
            btnVeiculos = new Button();
            btnCliente = new Button();
            painelLogo = new Panel();
            TituloLogo = new Label();
            painelTopo = new Panel();
            btnClose = new Button();
            btnMinimize = new Button();
            btnMaximize = new Button();
            labelTitulo = new Label();
            painelDesktop = new Panel();
            painelLateral.SuspendLayout();
            painelLogo.SuspendLayout();
            painelTopo.SuspendLayout();
            SuspendLayout();
            // 
            // painelLateral
            // 
            painelLateral.BackColor = Color.FromArgb(51, 51, 76);
            painelLateral.Controls.Add(btnFuncionarios);
            painelLateral.Controls.Add(btnOS);
            painelLateral.Controls.Add(btnVeiculos);
            painelLateral.Controls.Add(btnCliente);
            painelLateral.Controls.Add(painelLogo);
            painelLateral.Dock = DockStyle.Left;
            painelLateral.Location = new Point(0, 0);
            painelLateral.Margin = new Padding(2, 2, 2, 2);
            painelLateral.Name = "painelLateral";
            painelLateral.Size = new Size(154, 360);
            painelLateral.TabIndex = 2;
            // 
            // btnFuncionarios
            // 
            btnFuncionarios.Dock = DockStyle.Top;
            btnFuncionarios.FlatAppearance.BorderSize = 0;
            btnFuncionarios.FlatStyle = FlatStyle.Flat;
            btnFuncionarios.ForeColor = Color.White;
            btnFuncionarios.Location = new Point(0, 138);
            btnFuncionarios.Margin = new Padding(2, 2, 2, 2);
            btnFuncionarios.Name = "btnFuncionarios";
            btnFuncionarios.Padding = new Padding(8, 0, 0, 0);
            btnFuncionarios.Size = new Size(154, 30);
            btnFuncionarios.TabIndex = 0;
            btnFuncionarios.Text = "Funcionários";
            btnFuncionarios.Click += btnFuncionarios_Click;
            // 
            // btnOS
            // 
            btnOS.Dock = DockStyle.Top;
            btnOS.FlatAppearance.BorderSize = 0;
            btnOS.FlatStyle = FlatStyle.Flat;
            btnOS.ForeColor = Color.White;
            btnOS.Location = new Point(0, 108);
            btnOS.Margin = new Padding(2, 2, 2, 2);
            btnOS.Name = "btnOS";
            btnOS.Padding = new Padding(8, 0, 0, 0);
            btnOS.Size = new Size(154, 30);
            btnOS.TabIndex = 1;
            btnOS.Text = "Ordem de Serviço";
            btnOS.Click += btnOS_Click;
            // 
            // btnVeiculos
            // 
            btnVeiculos.Dock = DockStyle.Top;
            btnVeiculos.FlatAppearance.BorderSize = 0;
            btnVeiculos.FlatStyle = FlatStyle.Flat;
            btnVeiculos.ForeColor = Color.White;
            btnVeiculos.Location = new Point(0, 78);
            btnVeiculos.Margin = new Padding(2, 2, 2, 2);
            btnVeiculos.Name = "btnVeiculos";
            btnVeiculos.Padding = new Padding(8, 0, 0, 0);
            btnVeiculos.Size = new Size(154, 30);
            btnVeiculos.TabIndex = 2;
            btnVeiculos.Text = "Veículos";
            btnVeiculos.Click += btnVeiculos_Click;
            // 
            // btnCliente
            // 
            btnCliente.Dock = DockStyle.Top;
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.ForeColor = Color.White;
            btnCliente.Location = new Point(0, 48);
            btnCliente.Margin = new Padding(2, 2, 2, 2);
            btnCliente.Name = "btnCliente";
            btnCliente.Padding = new Padding(8, 0, 0, 0);
            btnCliente.Size = new Size(154, 30);
            btnCliente.TabIndex = 3;
            btnCliente.Text = "Clientes";
            btnCliente.Click += btnCliente_Click;
            // 
            // painelLogo
            // 
            painelLogo.BackColor = Color.FromArgb(64, 64, 64);
            painelLogo.Controls.Add(TituloLogo);
            painelLogo.Dock = DockStyle.Top;
            painelLogo.Location = new Point(0, 0);
            painelLogo.Margin = new Padding(2, 2, 2, 2);
            painelLogo.Name = "painelLogo";
            painelLogo.Size = new Size(154, 48);
            painelLogo.TabIndex = 4;
            // 
            // TituloLogo
            // 
            TituloLogo.AutoSize = true;
            TituloLogo.Font = new Font("Modern No. 20", 16F, FontStyle.Bold);
            TituloLogo.ForeColor = Color.White;
            TituloLogo.Location = new Point(35, 15);
            TituloLogo.Margin = new Padding(2, 0, 2, 0);
            TituloLogo.Name = "TituloLogo";
            TituloLogo.Size = new Size(105, 24);
            TituloLogo.TabIndex = 0;
            TituloLogo.Text = "Car WoW";
            // 
            // painelTopo
            // 
            painelTopo.BackColor = Color.FromArgb(0, 122, 204);
            painelTopo.Controls.Add(btnClose);
            painelTopo.Controls.Add(btnMinimize);
            painelTopo.Controls.Add(btnMaximize);
            painelTopo.Controls.Add(labelTitulo);
            painelTopo.Dock = DockStyle.Top;
            painelTopo.Location = new Point(154, 0);
            painelTopo.Margin = new Padding(2, 2, 2, 2);
            painelTopo.Name = "painelTopo";
            painelTopo.Size = new Size(630, 48);
            painelTopo.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(595, 6);
            btnClose.Margin = new Padding(2, 2, 2, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 18);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.Click += CloseForm_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Location = new Point(518, 6);
            btnMinimize.Margin = new Padding(2, 2, 2, 2);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(35, 18);
            btnMinimize.TabIndex = 1;
            btnMinimize.Text = "_";
            btnMinimize.Click += BtnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Location = new Point(556, 6);
            btnMaximize.Margin = new Padding(2, 2, 2, 2);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(35, 18);
            btnMaximize.TabIndex = 2;
            btnMaximize.Text = "▢";
            btnMaximize.Click += BtnMaximize_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Modern No. 20", 18F, FontStyle.Bold);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(280, 15);
            labelTitulo.Margin = new Padding(2, 0, 2, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(89, 25);
            labelTitulo.TabIndex = 3;
            labelTitulo.Text = "HOME";
            // 
            // painelDesktop
            // 
            painelDesktop.Dock = DockStyle.Fill;
            painelDesktop.Location = new Point(154, 48);
            painelDesktop.Margin = new Padding(2, 2, 2, 2);
            painelDesktop.Name = "painelDesktop";
            painelDesktop.Size = new Size(630, 312);
            painelDesktop.TabIndex = 0;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 360);
            Controls.Add(painelDesktop);
            Controls.Add(painelTopo);
            Controls.Add(painelLateral);
            Margin = new Padding(2, 2, 2, 2);
            MinimumSize = new Size(635, 316);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load_1;
            painelLateral.ResumeLayout(false);
            painelLogo.ResumeLayout(false);
            painelLogo.PerformLayout();
            painelTopo.ResumeLayout(false);
            painelTopo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel painelLateral;
        private Panel painelLogo;
        private Label TituloLogo;
        private Button btnCliente;
        private Button btnVeiculos;
        private Button btnOS;
        private Button btnFuncionarios;
        private Panel painelTopo;
        private Label labelTitulo;
        private Panel painelDesktop;
        private Button btnClose;
        private Button btnMinimize;
        private Button btnMaximize;
    }
}
