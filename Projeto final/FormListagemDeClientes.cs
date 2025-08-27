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
    public partial class FormListagemDeClientes : Form
    {
        public FormListagemDeClientes()
        {
            InitializeComponent();
        }

        private void btnCarregarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexao = Conexao.ObterConexao())
                {
                    string query = "SELECT id, nome, cpf, telefone, cep FROM cliente";
                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);

                    dataGridViewClientes.DataSource = tabela;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
        }
    }
}
