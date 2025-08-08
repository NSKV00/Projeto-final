using MySql.Data.MySqlClient;
using SistemaFarmacia.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_final
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void imputNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void imputSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = imputNome.Text.Trim();
            string senha = imputSenha.Text.Trim();

            using (var conexao = Conexao.ObterConexao())
            {
                string query = "SELECT COUNT(*) FROM admin WHERE usuario = @usuario AND senha = @senha";

                using (var cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Login bem-sucedido!");

                        new Form1().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos.");
                    }
                }
            }
        
    }
    }
}
