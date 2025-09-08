using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.Location = new Point(251, 181);
            btnLogin.Margin = new Padding(2, 2, 2, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(78, 20);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(180, 112);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 9;
            label2.Text = "senha";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(190, 62);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 8;
            label1.Text = "nome";
            // 
            // imputSenha
            // 
            imputSenha.Anchor = AnchorStyles.None;
            imputSenha.Location = new Point(163, 142);
            imputSenha.Margin = new Padding(2, 2, 2, 2);
            imputSenha.Name = "imputSenha";
            imputSenha.Size = new Size(249, 23);
            imputSenha.TabIndex = 7;
            imputSenha.UseSystemPasswordChar = true;
            imputSenha.TextChanged += imputSenha_TextChanged;
            // 
            // imputNome
            // 
            imputNome.Anchor = AnchorStyles.None;
            imputNome.Location = new Point(163, 79);
            imputNome.Margin = new Padding(2, 2, 2, 2);
            imputNome.Name = "imputNome";
            imputNome.Size = new Size(249, 23);
            imputNome.TabIndex = 6;
            imputNome.TextChanged += imputNome_TextChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Controls.Add(imputNome);
            panel1.Controls.Add(imputSenha);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnLogin);
            panel1.Location = new Point(28, 23);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(636, 286);
            panel1.TabIndex = 11;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(690, 327);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Login";
            Text = "Form2";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}