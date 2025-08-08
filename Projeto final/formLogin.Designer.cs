namespace Projeto_final
{
    partial class formLogin
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            txtlogin = new Label();
            imputNome = new TextBox();
            imputSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtlogin
            // 
            txtlogin.Location = new Point(0, 0);
            txtlogin.Name = "txtlogin";
            txtlogin.Size = new Size(100, 23);
            txtlogin.TabIndex = 6;
            // 
            // imputNome
            // 
            imputNome.Location = new Point(152, 185);
            imputNome.Name = "imputNome";
            imputNome.Size = new Size(354, 31);
            imputNome.TabIndex = 1;
            imputNome.TextChanged += imputNome_TextChanged;
            // 
            // imputSenha
            // 
            imputSenha.Location = new Point(152, 286);
            imputSenha.Name = "imputSenha";
            imputSenha.Size = new Size(354, 31);
            imputSenha.TabIndex = 2;
            imputSenha.UseSystemPasswordChar = true;
            imputSenha.TextChanged += imputSenha_TextChanged;
            // 
            // label1
            // 
            //label1.AutoSize = true;
            //label1.Location = new Point(180, 157);
            //label1.Name = "label1";
            //label1.Size = new Size(58, 25);
            //label1.TabIndex = 3;
            //label1.Text = "nome";
            //label1.Click += this.label1_Click;
            // 
            // label2
            // 
            //label2.AutoSize = true;
            //label2.Location = new Point(180, 258);
            //label2.Name = "label2";
            //label2.Size = new Size(58, 25);
            //label2.TabIndex = 4;
            //label2.Text = "senha";
            //label2.Click += this.label2_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(324, 461);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // formLogin
            // 
            AccessibleDescription = "";
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(imputSenha);
            Controls.Add(imputNome);
            Controls.Add(txtlogin);
            Name = "formLogin";
            Size = new Size(817, 565);
            Load += formLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtlogin;
        private TextBox imputNome;
        private TextBox imputSenha;
        private Label label1;
        private Label label2;
        private Button btnLogin;
    }
}
