using MySql.Data.MySqlClient;
using SistemaDatabase.Conexoes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Projeto_final.Forms.Funcionarios
{
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
            CarregarFuncionarios();
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
                string query = "SELECT id FROM funcionario WHERE cpf = @cpf AND id != @id";
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
                string.IsNullOrWhiteSpace(txtContato.Text) ||
                string.IsNullOrWhiteSpace(txtCpf.Text))
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
                    string query = @"INSERT INTO funcionario (nome, contato, cpf, ativo) 
                                     VALUES (@nome, @contato, @cpf, 'a')";

                    using (var cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@contato", txtContato.Text);
                        cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Funcionário cadastrado com sucesso!");
                LimparCampos();
                CarregarFuncionarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar funcionário: {ex.Message}");
            }
        }

        private void CarregarFuncionarios()
        {
            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string query = "SELECT id, nome, contato, cpf FROM funcionario WHERE ativo = 'a'";
                    using (var adapter = new MySqlDataAdapter(query, conexao))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvFuncionarios.DataSource = dt;
                        dgvFuncionarios.ClearSelection();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar funcionários: {ex.Message}");
            }
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtContato.Clear();
            txtCpf.Clear();
        }

        private void dgvFuncionarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFuncionarios.SelectedRows.Count > 0)
            {
                txtNome.Text = dgvFuncionarios.SelectedRows[0].Cells["nome"].Value.ToString();
                txtContato.Text = dgvFuncionarios.SelectedRows[0].Cells["contato"].Value.ToString();
                txtCpf.Text = dgvFuncionarios.SelectedRows[0].Cells["cpf"].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvFuncionarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um funcionário para editar.");
                return;
            }

            int id = Convert.ToInt32(dgvFuncionarios.SelectedRows[0].Cells["id"].Value);

            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtContato.Text) ||
                string.IsNullOrWhiteSpace(txtCpf.Text))
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
                MessageBox.Show("CPF já cadastrado em outro funcionário.");
                return;
            }

            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string query = @"UPDATE funcionario SET nome=@nome, contato=@contato, cpf=@cpf WHERE id=@id";
                    using (var cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@contato", txtContato.Text);
                        cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Funcionário atualizado com sucesso!");
                LimparCampos();
                CarregarFuncionarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar funcionário: {ex.Message}");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvFuncionarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um funcionário para excluir.");
                return;
            }

            int id = Convert.ToInt32(dgvFuncionarios.SelectedRows[0].Cells["id"].Value);

            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string checkOs = "SELECT id FROM os WHERE funcionario = @id LIMIT 1";
                    using (var cmdCheck = new MySqlCommand(checkOs, conexao))
                    {
                        cmdCheck.Parameters.AddWithValue("@id", id);
                        using (var reader = cmdCheck.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Não é possível excluir funcionário vinculado a uma OS.");
                                return;
                            }
                        }
                    }

                    string deleteQuery = "DELETE FROM funcionario WHERE id=@id";
                    using (var cmd = new MySqlCommand(deleteQuery, conexao))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Funcionário excluído com sucesso!");
                LimparCampos();
                CarregarFuncionarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir funcionário: {ex.Message}");
            }
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {

        }
    }
}
