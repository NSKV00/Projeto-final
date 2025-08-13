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
            panel1 = new Panel();
            btnaleatorio = new Button();
            btnFuncionarios = new Button();
            btnOS = new Button();
            btnVeiculos = new Button();
            btnCliente = new Button();
            painelLogo = new Panel();
            label2 = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            panel2 = new Panel();
            label1 = new Label();
            panelDesktop = new Panel();
            panel1.SuspendLayout();
            painelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(btnaleatorio);
            panel1.Controls.Add(btnFuncionarios);
            panel1.Controls.Add(btnOS);
            panel1.Controls.Add(btnVeiculos);
            panel1.Controls.Add(btnCliente);
            panel1.Controls.Add(painelLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 564);
            panel1.TabIndex = 0;
            // 
            // btnaleatorio
            // 
            btnaleatorio.Dock = DockStyle.Top;
            btnaleatorio.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnaleatorio.FlatStyle = FlatStyle.Flat;
            btnaleatorio.Location = new Point(0, 280);
            btnaleatorio.Name = "btnaleatorio";
            btnaleatorio.Padding = new Padding(12, 0, 0, 0);
            btnaleatorio.Size = new Size(220, 50);
            btnaleatorio.TabIndex = 5;
            btnaleatorio.Text = "button1";
            btnaleatorio.UseVisualStyleBackColor = true;
            btnaleatorio.Click += button4_Click;
            // 
            // btnFuncionarios
            // 
            btnFuncionarios.Dock = DockStyle.Top;
            btnFuncionarios.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnFuncionarios.FlatStyle = FlatStyle.Flat;
            btnFuncionarios.Location = new Point(0, 230);
            btnFuncionarios.Name = "btnFuncionarios";
            btnFuncionarios.Padding = new Padding(12, 0, 0, 0);
            btnFuncionarios.Size = new Size(220, 50);
            btnFuncionarios.TabIndex = 4;
            btnFuncionarios.Text = "Funcionários";
            btnFuncionarios.UseVisualStyleBackColor = true;
            // 
            // btnOS
            // 
            btnOS.Dock = DockStyle.Top;
            btnOS.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnOS.FlatStyle = FlatStyle.Flat;
            btnOS.Location = new Point(0, 180);
            btnOS.Name = "btnOS";
            btnOS.Padding = new Padding(12, 0, 0, 0);
            btnOS.Size = new Size(220, 50);
            btnOS.TabIndex = 3;
            btnOS.Text = "Ordem de Serviço";
            btnOS.UseVisualStyleBackColor = true;
            // 
            // btnVeiculos
            // 
            btnVeiculos.Dock = DockStyle.Top;
            btnVeiculos.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnVeiculos.FlatStyle = FlatStyle.Flat;
            btnVeiculos.Location = new Point(0, 130);
            btnVeiculos.Name = "btnVeiculos";
            btnVeiculos.Padding = new Padding(12, 0, 0, 0);
            btnVeiculos.Size = new Size(220, 50);
            btnVeiculos.TabIndex = 2;
            btnVeiculos.Text = "Cadastro Veículo";
            btnVeiculos.UseVisualStyleBackColor = true;
            btnVeiculos.Click += Veiculos_Click;
            // 
            // btnCliente
            // 
            btnCliente.Dock = DockStyle.Top;
            btnCliente.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Location = new Point(0, 80);
            btnCliente.Name = "btnCliente";
            btnCliente.Padding = new Padding(12, 0, 0, 0);
            btnCliente.Size = new Size(220, 50);
            btnCliente.TabIndex = 1;
            btnCliente.Text = "Cadatro Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            // 
            // painelLogo
            // 
            painelLogo.BackColor = Color.FromArgb(64, 64, 64);
            painelLogo.Controls.Add(label2);
            painelLogo.Dock = DockStyle.Top;
            painelLogo.Location = new Point(0, 0);
            painelLogo.Name = "painelLogo";
            painelLogo.Size = new Size(220, 80);
            painelLogo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(61, 32);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 0;
            label2.Text = "Car WoW";
            label2.Click += label2_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(220, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(849, 80);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(392, 32);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 0;
            label1.Text = "Home";
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(220, 80);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(849, 484);
            panelDesktop.TabIndex = 2;
            // 
            // MenuLateral
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 564);
            Controls.Add(panelDesktop);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MenuLateral";
            Text = "Form1";
            Load += MenuLateral_Load;
            panel1.ResumeLayout(false);
            painelLogo.ResumeLayout(false);
            painelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FileSystemWatcher fileSystemWatcher1;
        private Button btnCliente;
        private Panel painelLogo;
        private Button btnaleatorio;
        private Button btnFuncionarios;
        private Button btnOS;
        private Button btnVeiculos;
        private Panel panel2;
        private Label label1;
        private Panel panelDesktop;
        private Label label2;
    }
}
