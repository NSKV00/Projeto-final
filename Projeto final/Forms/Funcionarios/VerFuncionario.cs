using MySql.Data.MySqlClient;
using SistemaDatabase.Conexoes;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_final.Forms.Funcionarios
{
    public partial class VerFuncionario : Form
    {
        public VerFuncionario()
        {
            InitializeComponent();
            CarregarFuncionarios();
        }

        private void VerFuncionario_Load(object sender, EventArgs e)
        {
            CarregarFuncionarios();
        }

        private void btnCarregarFuncionarios_Click(object sender, EventArgs e)
        {
            CarregarFuncionarios();
        }

        private void CarregarFuncionarios()
        {
            try
            {
                using (MySqlConnection conexao = Conexao.ObterConexao())
                {
                    string query = "SELECT id, nome, contato, cpf FROM funcionario";
                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);

                    dataGridViewFuncionarios.DataSource = tabela;
                    dataGridViewFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridViewFuncionarios.ReadOnly = true;
                    dataGridViewFuncionarios.AllowUserToAddRows = false;
                    dataGridViewFuncionarios.AllowUserToDeleteRows = false;
                    dataGridViewFuncionarios.MultiSelect = false;
                    dataGridViewFuncionarios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    dataGridViewFuncionarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 37, 41);
                    dataGridViewFuncionarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dataGridViewFuncionarios.EnableHeadersVisualStyles = false;
                    dataGridViewFuncionarios.RowTemplate.Height = 30;
                    dataGridViewFuncionarios.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

                    if (dataGridViewFuncionarios.Columns.Contains("id"))
                        dataGridViewFuncionarios.Sort(dataGridViewFuncionarios.Columns["id"], ListSortDirection.Ascending);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar funcionários: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
