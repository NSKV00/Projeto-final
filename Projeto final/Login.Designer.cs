//ola
namespace Projeto_final
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnLogin = new Button();
            label2 = new Label();
            label1 = new Label();
            imputSenha = new TextBox();
            imputNome = new TextBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.Location = new Point(287, 249);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(96, 55);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(205, 139);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 9;
            label2.Text = "senha";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(205, 52);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 8;
            label1.Text = "nome";
            // 
            // imputSenha
            // 
            imputSenha.Anchor = AnchorStyles.None;
            imputSenha.Location = new Point(172, 177);
            imputSenha.Name = "imputSenha";
            imputSenha.Size = new Size(338, 31);
            imputSenha.TabIndex = 7;
            imputSenha.UseSystemPasswordChar = true;
            imputSenha.TextChanged += imputSenha_TextChanged;
            // 
            // imputNome
            // 
            imputNome.Anchor = AnchorStyles.None;
            imputNome.Location = new Point(172, 92);
            imputNome.Name = "imputNome";
            imputNome.Size = new Size(338, 31);
            imputNome.TabIndex = 6;
            imputNome.Text = "\r\n";
            imputNome.TextChanged += imputNome_TextChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(74, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(835, 444);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(835, 444);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(imputNome);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(btnLogin);
            panel3.Controls.Add(imputSenha);
            panel3.Location = new Point(79, 46);
            panel3.Name = "panel3";
            panel3.Size = new Size(675, 380);
            panel3.TabIndex = 11;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(985, 545);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private Label label2;
        private Label label1;
        private TextBox imputSenha;
        private TextBox imputNome;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}