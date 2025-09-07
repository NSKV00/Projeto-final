using MySql.Data.MySqlClient;
using SistemaDatabase.Conexoes;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Projeto_final.Forms.Clientes
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
            CarregarClientes();
        }

        private bool ValidarCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpf = cpf.Trim().Replace(".", "").Replace("-", "");
            if (cpf.Length != 11) return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;
            digito = resto.ToString();

            tempCpf += digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;
            digito += resto.ToString();

            return cpf.EndsWith(digito);
        }

        private bool CpfExistente(string cpf, int idAtual = 0)
        {
            using (var conexao = Conexao.ObterConexao())
            {
                string query = "SELECT id FROM cliente WHERE cpf = @cpf AND id != @id";
                using (var cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    cmd.Parameters.AddWithValue("@id", idAtual);
                    using (var reader = cmd.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCpf.Text) ||
                string.IsNullOrWhiteSpace(txtTelefone.Text) ||
                string.IsNullOrWhiteSpace(txtCep.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            if (!ValidarCpf(txtCpf.Text))
            {
                MessageBox.Show("CPF inválido.");
                return;
            }

            if (CpfExistente(txtCpf.Text))
            {
                MessageBox.Show("CPF já cadastrado.");
                return;
            }

            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string query = @"INSERT INTO cliente (nome, cpf, telefone, cep, ativo) 
                                     VALUES (@nome, @cpf, @telefone, @cep, 'a')";

                    using (var cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
                        cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                        cmd.Parameters.AddWithValue("@cep", txtCep.Text);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Cliente cadastrado com sucesso!");
                LimparCampos();
                CarregarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar cliente: {ex.Message}");
            }
        }

        private void CarregarClientes()
        {
            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string query = "SELECT id, nome, cpf, telefone, cep FROM cliente WHERE ativo = 'a'";
                    using (var adapter = new MySqlDataAdapter(query, conexao))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvClientes.DataSource = dt;
                        dgvClientes.ClearSelection();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar clientes: {ex.Message}");
            }
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtTelefone.Clear();
            txtCep.Clear();
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                txtNome.Text = dgvClientes.SelectedRows[0].Cells["nome"].Value.ToString();
                txtCpf.Text = dgvClientes.SelectedRows[0].Cells["cpf"].Value.ToString();
                txtTelefone.Text = dgvClientes.SelectedRows[0].Cells["telefone"].Value.ToString();
                txtCep.Text = dgvClientes.SelectedRows[0].Cells["cep"].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um cliente para editar.");
                return;
            }

            int id = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["id"].Value);

            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCpf.Text) ||
                string.IsNullOrWhiteSpace(txtTelefone.Text) ||
                string.IsNullOrWhiteSpace(txtCep.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            if (!ValidarCpf(txtCpf.Text))
            {
                MessageBox.Show("CPF inválido.");
                return;
            }

            if (CpfExistente(txtCpf.Text, id))
            {
                MessageBox.Show("CPF já cadastrado em outro cliente.");
                return;
            }

            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string query = @"UPDATE cliente SET nome=@nome, cpf=@cpf, telefone=@telefone, cep=@cep WHERE id=@id";
                    using (var cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
                        cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                        cmd.Parameters.AddWithValue("@cep", txtCep.Text);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Cliente atualizado com sucesso!");
                LimparCampos();
                CarregarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar cliente: {ex.Message}");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um cliente para excluir.");
                return;
            }

            int id = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["id"].Value);

            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string checkOs = "SELECT id FROM os WHERE id_cliente = @id LIMIT 1";
                    using (var cmdCheck = new MySqlCommand(checkOs, conexao))
                    {
                        cmdCheck.Parameters.AddWithValue("@id", id);
                        using (var reader = cmdCheck.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Não é possível excluir cliente vinculado a uma OS.");
                                return;
                            }
                        }
                    }

                    string deleteQuery = "DELETE FROM cliente WHERE id=@id";
                    using (var cmd = new MySqlCommand(deleteQuery, conexao))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Cliente excluído com sucesso!");
                LimparCampos();
                CarregarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir cliente: {ex.Message}");
            }
        }
    }
}
