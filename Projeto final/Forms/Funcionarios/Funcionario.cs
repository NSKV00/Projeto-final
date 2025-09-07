using MySql.Data.MySqlClient;
using SistemaDatabase.Conexoes;
using System;
using System.Windows.Forms;

namespace Projeto_final.Forms.Funcionarios
{
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private bool ValidarCpf(string cpf)
        {
            int[] multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf, digito;
            int soma, resto;

            cpf = cpf.Trim().Replace(".", "").Replace("-", "");
            if (cpf.Length != 11) return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++) soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;
            digito = resto.ToString();
            tempCpf += digito;

            soma = 0;
            for (int i = 0; i < 10; i++) soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;
            digito += resto.ToString();

            return cpf.EndsWith(digito);
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {
            CarregarFuncionarios();
        }

        private void CarregarFuncionarios()
        {
            dgvFuncionarios.Rows.Clear();
            using (var conexao = Conexao.ObterConexao())
            {
                string query = "SELECT id, nome, contato, cpf FROM funcionario";
                using (var cmd = new MySqlCommand(query, conexao))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgvFuncionarios.Rows.Add(reader.GetInt32("id"), reader.GetString("nome"), reader.GetString("contato"), reader.GetString("cpf"));
                    }
                }
            }

            // Ajuste colunas
            if (dgvFuncionarios.Columns.Count == 0)
            {
                dgvFuncionarios.Columns.Add("id", "ID");
                dgvFuncionarios.Columns.Add("nome", "Nome");
                dgvFuncionarios.Columns.Add("contato", "Contato");
                dgvFuncionarios.Columns.Add("cpf", "CPF");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
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

            using (var conexao = Conexao.ObterConexao())
            {
                string checkCpf = "SELECT COUNT(*) FROM funcionario WHERE cpf=@cpf";
                using (var cmdCheck = new MySqlCommand(checkCpf, conexao))
                {
                    cmdCheck.Parameters.AddWithValue("@cpf", txtCpf.Text);
                    int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("CPF já cadastrado.");
                        return;
                    }
                }

                string insert = "INSERT INTO funcionario (nome, contato, cpf) VALUES (@nome,@contato,@cpf)";
                using (var cmd = new MySqlCommand(insert, conexao))
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvFuncionarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um funcionário para editar.");
                return;
            }

            int id = Convert.ToInt32(dgvFuncionarios.SelectedRows[0].Cells["id"].Value);

            using (var conexao = Conexao.ObterConexao())
            {
                string update = "UPDATE funcionario SET nome=@nome, contato=@contato, cpf=@cpf WHERE id=@id";
                using (var cmd = new MySqlCommand(update, conexao))
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvFuncionarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um funcionário para excluir.");
                return;
            }

            int id = Convert.ToInt32(dgvFuncionarios.SelectedRows[0].Cells["id"].Value);

            using (var conexao = Conexao.ObterConexao())
            {
                // Verifica vínculo com OS
                string checkOS = "SELECT COUNT(*) FROM os WHERE id_funcionario=@id";
                using (var cmdCheck = new MySqlCommand(checkOS, conexao))
                {
                    cmdCheck.Parameters.AddWithValue("@id", id);
                    int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Não é possível excluir. Funcionário vinculado a uma OS.");
                        return;
                    }
                }

                string delete = "DELETE FROM funcionario WHERE id=@id";
                using (var cmd = new MySqlCommand(delete, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Funcionário excluído com sucesso!");
            CarregarFuncionarios();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtContato.Clear();
            txtCpf.Clear();
        }
    }
}
