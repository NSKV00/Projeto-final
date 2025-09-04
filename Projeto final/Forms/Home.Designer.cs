namespace Projeto_final
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            painelLateral = new Panel();
            btnVerCliente = new Button();
            btnFuncionarios = new Button();
            btnOS = new Button();
            btnVeiculos = new Button();
            btnCliente = new Button();
            painelLogo = new Panel();
            TituloLogo = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            painelTopo = new Panel();
            CloseForm = new Button();
            labelTitulo = new Label();
            painelDesktop = new Panel();
            painelLateral.SuspendLayout();
            painelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            painelTopo.SuspendLayout();
            SuspendLayout();
            // 
            // painelLateral
            // 
            painelLateral.BackColor = Color.FromArgb(51, 51, 76);
            painelLateral.Controls.Add(btnVerCliente);
            painelLateral.Controls.Add(btnFuncionarios);
            painelLateral.Controls.Add(btnOS);
            painelLateral.Controls.Add(btnVeiculos);
            painelLateral.Controls.Add(btnCliente);
            painelLateral.Controls.Add(painelLogo);
            painelLateral.Dock = DockStyle.Left;
            painelLateral.Location = new Point(0, 0);
            painelLateral.Name = "painelLateral";
            painelLateral.Size = new Size(220, 563);
            painelLateral.TabIndex = 0;
            // 
            // btnVerCliente
            // 
            btnVerCliente.Dock = DockStyle.Top;
            btnVerCliente.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnVerCliente.FlatStyle = FlatStyle.Flat;
            btnVerCliente.Location = new Point(0, 280);
            btnVerCliente.Name = "btnVerCliente";
            btnVerCliente.Padding = new Padding(11, 0, 0, 0);
            btnVerCliente.Size = new Size(220, 50);
            btnVerCliente.TabIndex = 5;
            btnVerCliente.Text = "Ver Clientes";
            btnVerCliente.UseVisualStyleBackColor = true;
            btnVerCliente.Click += btnaleatorio_Click;
            // 
            // btnFuncionarios
            // 
            btnFuncionarios.Dock = DockStyle.Top;
            btnFuncionarios.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnFuncionarios.FlatStyle = FlatStyle.Flat;
            btnFuncionarios.Location = new Point(0, 230);
            btnFuncionarios.Name = "btnFuncionarios";
            btnFuncionarios.Padding = new Padding(11, 0, 0, 0);
            btnFuncionarios.Size = new Size(220, 50);
            btnFuncionarios.TabIndex = 4;
            btnFuncionarios.Text = "Funcionários";
            btnFuncionarios.UseVisualStyleBackColor = true;
            btnFuncionarios.Click += btnFuncionarios_Click;
            // 
            // btnOS
            // 
            btnOS.Dock = DockStyle.Top;
            btnOS.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnOS.FlatStyle = FlatStyle.Flat;
            btnOS.Location = new Point(0, 180);
            btnOS.Name = "btnOS";
            btnOS.Padding = new Padding(11, 0, 0, 0);
            btnOS.Size = new Size(220, 50);
            btnOS.TabIndex = 3;
            btnOS.Text = "Ordem de Serviço";
            btnOS.UseVisualStyleBackColor = true;
            btnOS.Click += btnOS_Click;
            // 
            // btnVeiculos
            // 
            btnVeiculos.Dock = DockStyle.Top;
            btnVeiculos.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnVeiculos.FlatStyle = FlatStyle.Flat;
            btnVeiculos.Location = new Point(0, 130);
            btnVeiculos.Name = "btnVeiculos";
            btnVeiculos.Padding = new Padding(11, 0, 0, 0);
            btnVeiculos.Size = new Size(220, 50);
            btnVeiculos.TabIndex = 2;
            btnVeiculos.Text = "Veículos";
            btnVeiculos.UseVisualStyleBackColor = true;
            btnVeiculos.Click += btnVeiculos_Click;
            // 
            // btnCliente
            // 
            btnCliente.Dock = DockStyle.Top;
            btnCliente.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Location = new Point(0, 80);
            btnCliente.Name = "btnCliente";
            btnCliente.Padding = new Padding(11, 0, 0, 0);
            btnCliente.Size = new Size(220, 50);
            btnCliente.TabIndex = 1;
            btnCliente.Text = "Clientes";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // painelLogo
            // 
            painelLogo.BackColor = Color.FromArgb(64, 64, 64);
            painelLogo.Controls.Add(TituloLogo);
            painelLogo.Dock = DockStyle.Top;
            painelLogo.Location = new Point(0, 0);
            painelLogo.Name = "painelLogo";
            painelLogo.Size = new Size(220, 80);
            painelLogo.TabIndex = 1;
            // 
            // TituloLogo
            // 
            TituloLogo.AutoSize = true;
            TituloLogo.Font = new Font("Modern No. 20", 12F);
            TituloLogo.ForeColor = SystemColors.ButtonHighlight;
            TituloLogo.Location = new Point(56, 28);
            TituloLogo.Name = "TituloLogo";
            TituloLogo.Size = new Size(109, 25);
            TituloLogo.TabIndex = 0;
            TituloLogo.Text = "Car WoW";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // painelTopo
            // 
            painelTopo.BackColor = SystemColors.ActiveCaption;
            painelTopo.Controls.Add(CloseForm);
            painelTopo.Controls.Add(labelTitulo);
            painelTopo.Dock = DockStyle.Top;
            painelTopo.Location = new Point(220, 0);
            painelTopo.Name = "painelTopo";
            painelTopo.Size = new Size(849, 80);
            painelTopo.TabIndex = 1;
            // 
            // CloseForm
            // 
            CloseForm.BackColor = Color.Transparent;
            CloseForm.Font = new Font("Segoe UI", 12F);
            CloseForm.ForeColor = Color.Black;
            CloseForm.Location = new Point(7, 15);
            CloseForm.Margin = new Padding(4, 5, 4, 5);
            CloseForm.Name = "CloseForm";
            CloseForm.Size = new Size(44, 50);
            CloseForm.TabIndex = 1;
            CloseForm.Text = "X";
            CloseForm.UseVisualStyleBackColor = false;
            CloseForm.Click += CloseForm_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.None;
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Modern No. 20", 15F);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(384, 22);
            labelTitulo.Margin = new Padding(4, 0, 4, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(104, 31);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "HOME";
            // 
            // painelDesktop
            // 
            painelDesktop.Dock = DockStyle.Fill;
            painelDesktop.Location = new Point(220, 80);
            painelDesktop.Name = "painelDesktop";
            painelDesktop.Size = new Size(849, 483);
            painelDesktop.TabIndex = 2;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 563);
            Controls.Add(painelDesktop);
            Controls.Add(painelTopo);
            Controls.Add(painelLateral);
            Name = "Home";
            Text = "Form1";
            Load += Home_Load;
            painelLateral.ResumeLayout(false);
            painelLogo.ResumeLayout(false);
            painelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            painelTopo.ResumeLayout(false);
            painelTopo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel painelLateral;
        private FileSystemWatcher fileSystemWatcher1;
        private Button btnCliente;
        private Panel painelLogo;
        private Button btnVerCliente;
        private Button btnFuncionarios;
        private Button btnOS;
        private Button btnVeiculos;
        private Panel painelTopo;
        private Panel painelDesktop;
        private Label TituloLogo;
        private Label labelTitulo;
        private Button CloseForm;
    }
}
