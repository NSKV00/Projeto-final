using MySql.Data.MySqlClient;
using SistemaDatabase.Conexoes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Projeto_final.Forms.Clientes
{
    public partial class VerCliente : Form
    {
        public VerCliente()
        {
            InitializeComponent();
            CarregarClientes();
        }

        private void VerCliente_Load(object sender, EventArgs e)
        {
            // Pode ser redundante, mas garante que carregue ao abrir
            CarregarClientes();
        }

        private void btnCarregarClientes_Click(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        private void CarregarClientes()
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

                    // Melhorias visuais e funcionais no DataGridView
                    dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridViewClientes.ReadOnly = true;
                    dataGridViewClientes.AllowUserToAddRows = false;
                    dataGridViewClientes.AllowUserToDeleteRows = false;
                    dataGridViewClientes.MultiSelect = false;
                    dataGridViewClientes.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
                    dataGridViewClientes.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(33, 37, 41);
                    dataGridViewClientes.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
                    dataGridViewClientes.EnableHeadersVisualStyles = false;
                    dataGridViewClientes.RowTemplate.Height = 30;
                    dataGridViewClientes.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
                    dataGridViewClientes.Sort(dataGridViewClientes.Columns["id"], System.ComponentModel.ListSortDirection.Ascending);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pode ser usado para futuras funcionalidades de seleção ou edição
        }
    }
}
