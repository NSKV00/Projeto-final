//ola
namespace Projeto_final
{
    partial class Form2
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
            btnLogin = new Button();
            label2 = new Label();
            label1 = new Label();
            imputSenha = new TextBox();
            imputNome = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(395, 360);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 157);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 9;
            label2.Text = "senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 56);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 8;
            label1.Text = "nome";
            // 
            // imputSenha
            // 
            imputSenha.Location = new Point(223, 185);
            imputSenha.Name = "imputSenha";
            imputSenha.Size = new Size(354, 31);
            imputSenha.TabIndex = 7;
            imputSenha.UseSystemPasswordChar = true;
            imputSenha.TextChanged += imputSenha_TextChanged;
            // 
            // imputNome
            // 
            imputNome.Location = new Point(223, 84);
            imputNome.Name = "imputNome";
            imputNome.Size = new Size(354, 31);
            imputNome.TabIndex = 6;
            imputNome.TextChanged += imputNome_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(imputSenha);
            Controls.Add(imputNome);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label label2;
        private Label label1;
        private TextBox imputSenha;
        private TextBox imputNome;
    }
}