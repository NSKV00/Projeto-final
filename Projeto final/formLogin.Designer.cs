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
            components = new System.ComponentModel.Container();
            txtlogin = new Label();
            imputNome = new TextBox();
            imputSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtlogin
            // 
            txtlogin.AutoSize = true;
            txtlogin.Location = new Point(352, 34);
            txtlogin.Name = "txtlogin";
            txtlogin.Size = new Size(52, 25);
            txtlogin.TabIndex = 0;
            txtlogin.Text = "login";
            txtlogin.Click += label1_Click;
            // 
            // imputNome
            // 
            imputNome.Location = new Point(152, 185);
            imputNome.Name = "imputNome";
            imputNome.Size = new Size(354, 31);
            imputNome.TabIndex = 1;
            // 
            // imputSenha
            // 
            imputSenha.Location = new Point(152, 286);
            imputSenha.Name = "imputSenha";
            imputSenha.Size = new Size(354, 31);
            imputSenha.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 157);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 3;
            label1.Text = "nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 258);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 4;
            label2.Text = "senha";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(324, 461);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
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
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private ErrorProvider errorProvider1;
    }
}
