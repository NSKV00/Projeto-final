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
            btnaleatorio = new Button();
            btnFuncionarios = new Button();
            btnOS = new Button();
            btnVeiculos = new Button();
            btnCliente = new Button();
            painelLogo = new Panel();
            TituloLogo = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            painelTopo = new Panel();
            labelTitulo = new Label();
            painelDesktop = new Panel();
            CloseForm = new Button();
            painelLateral.SuspendLayout();
            painelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            painelTopo.SuspendLayout();
            SuspendLayout();
            // 
            // painelLateral
            // 
            painelLateral.BackColor = Color.FromArgb(51, 51, 76);
            painelLateral.Controls.Add(btnaleatorio);
            painelLateral.Controls.Add(btnFuncionarios);
            painelLateral.Controls.Add(btnOS);
            painelLateral.Controls.Add(btnVeiculos);
            painelLateral.Controls.Add(btnCliente);
            painelLateral.Controls.Add(painelLogo);
            painelLateral.Dock = DockStyle.Left;
            painelLateral.Location = new Point(0, 0);
            painelLateral.Margin = new Padding(2);
            painelLateral.Name = "painelLateral";
            painelLateral.Size = new Size(154, 338);
            painelLateral.TabIndex = 0;
            // 
            // btnaleatorio
            // 
            btnaleatorio.Dock = DockStyle.Top;
            btnaleatorio.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnaleatorio.FlatStyle = FlatStyle.Flat;
            btnaleatorio.Location = new Point(0, 168);
            btnaleatorio.Margin = new Padding(2);
            btnaleatorio.Name = "btnaleatorio";
            btnaleatorio.Padding = new Padding(8, 0, 0, 0);
            btnaleatorio.Size = new Size(154, 30);
            btnaleatorio.TabIndex = 5;
            btnaleatorio.Text = "button1";
            btnaleatorio.UseVisualStyleBackColor = true;
            // 
            // btnFuncionarios
            // 
            btnFuncionarios.Dock = DockStyle.Top;
            btnFuncionarios.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnFuncionarios.FlatStyle = FlatStyle.Flat;
            btnFuncionarios.Location = new Point(0, 138);
            btnFuncionarios.Margin = new Padding(2);
            btnFuncionarios.Name = "btnFuncionarios";
            btnFuncionarios.Padding = new Padding(8, 0, 0, 0);
            btnFuncionarios.Size = new Size(154, 30);
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
            btnOS.Location = new Point(0, 108);
            btnOS.Margin = new Padding(2);
            btnOS.Name = "btnOS";
            btnOS.Padding = new Padding(8, 0, 0, 0);
            btnOS.Size = new Size(154, 30);
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
            btnVeiculos.Location = new Point(0, 78);
            btnVeiculos.Margin = new Padding(2);
            btnVeiculos.Name = "btnVeiculos";
            btnVeiculos.Padding = new Padding(8, 0, 0, 0);
            btnVeiculos.Size = new Size(154, 30);
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
            btnCliente.Location = new Point(0, 48);
            btnCliente.Margin = new Padding(2);
            btnCliente.Name = "btnCliente";
            btnCliente.Padding = new Padding(8, 0, 0, 0);
            btnCliente.Size = new Size(154, 30);
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
            painelLogo.Margin = new Padding(2);
            painelLogo.Name = "painelLogo";
            painelLogo.Size = new Size(154, 48);
            painelLogo.TabIndex = 1;
            // 
            // TituloLogo
            // 
            TituloLogo.AutoSize = true;
            TituloLogo.Font = new Font("Modern No. 20", 12F);
            TituloLogo.ForeColor = SystemColors.ButtonHighlight;
            TituloLogo.Location = new Point(39, 17);
            TituloLogo.Margin = new Padding(2, 0, 2, 0);
            TituloLogo.Name = "TituloLogo";
            TituloLogo.Size = new Size(72, 18);
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
            painelTopo.Location = new Point(154, 0);
            painelTopo.Margin = new Padding(2);
            painelTopo.Name = "painelTopo";
            painelTopo.Size = new Size(594, 48);
            painelTopo.TabIndex = 1;
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.None;
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Modern No. 20", 15F);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(269, 13);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(70, 22);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "HOME";
            // 
            // painelDesktop
            // 
            painelDesktop.Dock = DockStyle.Fill;
            painelDesktop.Location = new Point(154, 48);
            painelDesktop.Margin = new Padding(2);
            painelDesktop.Name = "painelDesktop";
            painelDesktop.Size = new Size(594, 290);
            painelDesktop.TabIndex = 2;
            // 
            // CloseForm
            // 
            CloseForm.BackColor = Color.Transparent;
            CloseForm.Font = new Font("Segoe UI", 12F);
            CloseForm.ForeColor = Color.Black;
            CloseForm.Location = new Point(5, 9);
            CloseForm.Name = "CloseForm";
            CloseForm.Size = new Size(31, 30);
            CloseForm.TabIndex = 1;
            CloseForm.Text = "X";
            CloseForm.UseVisualStyleBackColor = false;
            CloseForm.Click += CloseForm_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 338);
            Controls.Add(painelDesktop);
            Controls.Add(painelTopo);
            Controls.Add(painelLateral);
            Margin = new Padding(2);
            Name = "Home";
            Text = "Form1";
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
        private Button btnaleatorio;
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
