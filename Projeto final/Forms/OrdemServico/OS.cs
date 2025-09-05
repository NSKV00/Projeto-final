using MySql.Data.MySqlClient;
using SistemaDatabase.Conexoes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Projeto_final.Forms.OrdemServico
{
    public partial class OS : Form
    {
        public OS()
        {
            InitializeComponent();
        }

        private void OS_Load(object sender, EventArgs e)
        {
            CarregarOS();
        }

        private void CarregarOS()
        {
            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string sql = @"SELECT id, cpf_cliente, placa_veiculo, cpf_funcionario, problema, servico, data_os 
                                   FROM os";

                    using (MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvOS.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar OS: {ex.Message}");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCpfCliente.Text) ||
                string.IsNullOrWhiteSpace(txtPlacaVeiculo.Text) ||
                string.IsNullOrWhiteSpace(txtCpfFuncionario.Text) ||
                string.IsNullOrWhiteSpace(txtProblema.Text) ||
                string.IsNullOrWhiteSpace(txtServico.Text))
            {
                MessageBox.Show("Por favor preencha todos os campos");
                return;
            }

            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string sql = @"INSERT INTO os (cpf_cliente, placa_veiculo, cpf_funcionario, problema, data_os, servico)
                                   VALUES (@cpf_cliente, @placa_veiculo, @cpf_funcionario, @problema, @data_os, @servico)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@cpf_cliente", txtCpfCliente.Text);
                        cmd.Parameters.AddWithValue("@placa_veiculo", txtPlacaVeiculo.Text);
                        cmd.Parameters.AddWithValue("@cpf_funcionario", txtCpfFuncionario.Text);
                        cmd.Parameters.AddWithValue("@problema", txtProblema.Text);
                        cmd.Parameters.AddWithValue("@data_os", dtpData.Value);
                        cmd.Parameters.AddWithValue("@servico", txtServico.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Ordem de Serviço salva com sucesso!");
                    LimparCampos();
                    CarregarOS();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar a OS: {ex.Message}");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvOS.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma OS para editar.");
                return;
            }

            int id = Convert.ToInt32(dgvOS.SelectedRows[0].Cells["id"].Value);

            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string sql = @"UPDATE os 
                                   SET cpf_cliente=@cpf_cliente, placa_veiculo=@placa_veiculo, cpf_funcionario=@cpf_funcionario,
                                       problema=@problema, servico=@servico, data_os=@data_os
                                   WHERE id=@id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@cpf_cliente", txtCpfCliente.Text);
                        cmd.Parameters.AddWithValue("@placa_veiculo", txtPlacaVeiculo.Text);
                        cmd.Parameters.AddWithValue("@cpf_funcionario", txtCpfFuncionario.Text);
                        cmd.Parameters.AddWithValue("@problema", txtProblema.Text);
                        cmd.Parameters.AddWithValue("@servico", txtServico.Text);
                        cmd.Parameters.AddWithValue("@data_os", dtpData.Value);
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("OS atualizada com sucesso!");
                    LimparCampos();
                    CarregarOS();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao editar a OS: {ex.Message}");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvOS.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma OS para excluir.");
                return;
            }

            int id = Convert.ToInt32(dgvOS.SelectedRows[0].Cells["id"].Value);

            DialogResult resultado = MessageBox.Show("Quer mesmo apagar essa OS?", "Confirmação de Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    using (var conexao = Conexao.ObterConexao())
                    {
                        string sql = "DELETE FROM os WHERE id=@id";
                        using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("OS excluída com sucesso!");
                    CarregarOS();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir: {ex.Message}");
                }
            }
        }

        private void LimparCampos()
        {
            txtCpfCliente.Clear();
            txtPlacaVeiculo.Clear();
            txtCpfFuncionario.Clear();
            txtProblema.Clear();
            txtServico.Clear();
            dtpData.Value = DateTime.Now;
        }
    }
}
