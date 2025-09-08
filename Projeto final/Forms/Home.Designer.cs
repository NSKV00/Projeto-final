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
            painelLateral.Size = new Size(220, 600);

            // 
            // painelLogo
            // 
            painelLogo.BackColor = Color.FromArgb(64, 64, 64);
            painelLogo.Controls.Add(TituloLogo);
            painelLogo.Dock = DockStyle.Top;
            painelLogo.Size = new Size(220, 80);

            // 
            // TituloLogo
            // 
            TituloLogo.AutoSize = true;
            TituloLogo.Font = new Font("Modern No. 20", 16F, FontStyle.Bold);
            TituloLogo.ForeColor = Color.White;
            TituloLogo.Location = new Point(50, 25);
            TituloLogo.Text = "Car WoW";

            // 
            // btnCliente
            // 
            btnCliente.Dock = DockStyle.Top;
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.ForeColor = Color.White;
            btnCliente.Padding = new Padding(11, 0, 0, 0);
            btnCliente.Size = new Size(220, 50);
            btnCliente.Text = "Clientes";
            btnCliente.Click += btnCliente_Click;

            // 
            // btnVeiculos
            // 
            btnVeiculos.Dock = DockStyle.Top;
            btnVeiculos.FlatStyle = FlatStyle.Flat;
            btnVeiculos.FlatAppearance.BorderSize = 0;
            btnVeiculos.ForeColor = Color.White;
            btnVeiculos.Padding = new Padding(11, 0, 0, 0);
            btnVeiculos.Size = new Size(220, 50);
            btnVeiculos.Text = "Veículos";
            btnVeiculos.Click += btnVeiculos_Click;

            // 
            // btnOS
            // 
            btnOS.Dock = DockStyle.Top;
            btnOS.FlatStyle = FlatStyle.Flat;
            btnOS.FlatAppearance.BorderSize = 0;
            btnOS.ForeColor = Color.White;
            btnOS.Padding = new Padding(11, 0, 0, 0);
            btnOS.Size = new Size(220, 50);
            btnOS.Text = "Ordem de Serviço";
            btnOS.Click += btnOS_Click;

            // 
            // btnFuncionarios
            // 
            btnFuncionarios.Dock = DockStyle.Top;
            btnFuncionarios.FlatStyle = FlatStyle.Flat;
            btnFuncionarios.FlatAppearance.BorderSize = 0;
            btnFuncionarios.ForeColor = Color.White;
            btnFuncionarios.Padding = new Padding(11, 0, 0, 0);
            btnFuncionarios.Size = new Size(220, 50);
            btnFuncionarios.Text = "Funcionários";
            btnFuncionarios.Click += btnFuncionarios_Click;

            // 
            // painelTopo
            // 
            painelTopo.BackColor = Color.FromArgb(0, 122, 204);
            painelTopo.Dock = DockStyle.Top;
            painelTopo.Size = new Size(900, 80);
            painelTopo.Controls.Add(btnClose);
            painelTopo.Controls.Add(btnMinimize);
            painelTopo.Controls.Add(btnMaximize);
            painelTopo.Controls.Add(labelTitulo);

            // 
            // btnClose
            // 
            btnClose.Text = "X";
            btnClose.Size = new Size(50, 30);
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += CloseForm_Click;
            btnClose.Location = new Point(850, 10);

            // 
            // btnMinimize
            // 
            btnMinimize.Text = "_";
            btnMinimize.Size = new Size(50, 30);
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.Click += BtnMinimize_Click;
            btnMinimize.Location = new Point(740, 10);

            // 
            // btnMaximize
            // 
            btnMaximize.Text = "▢";
            btnMaximize.Size = new Size(50, 30);
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.Click += BtnMaximize_Click;
            btnMaximize.Location = new Point(795, 10);

            // 
            // labelTitulo
            // 
            labelTitulo.Font = new Font("Modern No. 20", 18F, FontStyle.Bold);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(400, 25);
            labelTitulo.Text = "HOME";

            // 
            // painelDesktop
            // 
            painelDesktop.Dock = DockStyle.Fill;

            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 600);
            Controls.Add(painelDesktop);
            Controls.Add(painelTopo);
            Controls.Add(painelLateral);
            FormBorderStyle = FormBorderStyle.Sizable;
            MinimumSize = new Size(900, 500);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
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
