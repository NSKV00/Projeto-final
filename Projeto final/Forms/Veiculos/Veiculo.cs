using MySql.Data.MySqlClient;
using SistemaDatabase.Conexoes;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Projeto_final.Forms.Veiculos
{
    public partial class Veiculo : Form
    {
        private int selectedVeiculoId = -1; // Armazena o veículo selecionado na grid

        public Veiculo()
        {
            InitializeComponent();
            CarregarVeiculos();
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

            // Eventos
            dgvVeiculos.CellClick += DgvVeiculos_CellClick;
            btnSalvar.Click += BtnSalvar_Click;
            btnEditar.Click += BtnEditar_Click;
            btnExcluir.Click += BtnExcluir_Click;
            Textplaca.Leave += Textplaca_Leave;
        }

        #region Validação

        private bool ValidarPlaca(string placa)
        {
            placa = placa.Trim().ToUpper();
            Regex regexMercosul = new Regex(@"^[A-Z]{3}[0-9][A-Z][0-9]{2}$");
            return regexMercosul.IsMatch(placa);
        }

        private void Textplaca_Leave(object sender, EventArgs e)
        {
            if (!ValidarPlaca(Textplaca.Text))
            {
                MessageBox.Show("Placa inválida. Formato correto: ABC1D23.");
                Textplaca.Focus();
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(Textnamecliente.Text) ||
                string.IsNullOrWhiteSpace(Textmarca.Text) ||
                string.IsNullOrWhiteSpace(Textmodelo.Text) ||
                string.IsNullOrWhiteSpace(Textplaca.Text) ||
                string.IsNullOrWhiteSpace(Textanodefab.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
                return false;
            }

            if (!ValidarPlaca(Textplaca.Text))
            {
                MessageBox.Show("Placa inválida.");
                return false;
            }

            if (!int.TryParse(Textanodefab.Text, out _))
            {
                MessageBox.Show("Ano de fabricação inválido.");
                return false;
            }

            return true;
        }

        #endregion

        #region CRUD

        private void CarregarVeiculos()
        {
            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string query = @"SELECT v.id, v.cpf_cliente, c.nome AS cliente, v.marca, v.modelo, v.placa, v.ano_fabricacao
                                     FROM veiculos v
                                     INNER JOIN cliente c ON c.cpf = v.cpf_cliente
                                     ORDER BY v.id";

                    using (var cmd = new MySqlCommand(query, conexao))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvVeiculos.DataSource = dt;
                    }
                }
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar veículos: {ex.Message}");
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    // Verifica se o cliente existe
                    string queryCliente = "SELECT id FROM cliente WHERE cpf = @cpf_cliente";
                    using (var checkCmd = new MySqlCommand(queryCliente, conexao))
                    {
                        checkCmd.Parameters.AddWithValue("@cpf_cliente", Textnamecliente.Text.Trim());
                        using (var reader = checkCmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("CPF não encontrado no cadastro de clientes!");
                                return;
                            }
                        }
                    }

                    // Insere veículo
                    string sql = @"INSERT INTO veiculos (cpf_cliente, marca, modelo, placa, ano_fabricacao) 
                                   VALUES (@cpf_cliente, @marca, @modelo, @placa, @ano_fabricacao)";

                    using (var cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@cpf_cliente", Textnamecliente.Text.Trim());
                        cmd.Parameters.AddWithValue("@marca", Textmarca.Text.Trim());
                        cmd.Parameters.AddWithValue("@modelo", Textmodelo.Text.Trim());
                        cmd.Parameters.AddWithValue("@placa", Textplaca.Text.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@ano_fabricacao", int.Parse(Textanodefab.Text.Trim()));

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Veículo cadastrado com sucesso!");
                CarregarVeiculos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar veículo: {ex.Message}");
            }
        }

        private void DgvVeiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvVeiculos.Rows[e.RowIndex];
                selectedVeiculoId = Convert.ToInt32(row.Cells["id"].Value);
                Textnamecliente.Text = row.Cells["cpf_cliente"].Value.ToString();
                Textmarca.Text = row.Cells["marca"].Value.ToString();
                Textmodelo.Text = row.Cells["modelo"].Value.ToString();
                Textplaca.Text = row.Cells["placa"].Value.ToString();
                Textanodefab.Text = row.Cells["ano_fabricacao"].Value.ToString();

                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnSalvar.Enabled = false;
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (selectedVeiculoId == -1) return;
            if (!ValidarCampos()) return;

            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string sql = @"UPDATE veiculos 
                                   SET cpf_cliente=@cpf_cliente, marca=@marca, modelo=@modelo, placa=@placa, ano_fabricacao=@ano
                                   WHERE id=@id";

                    using (var cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@cpf_cliente", Textnamecliente.Text.Trim());
                        cmd.Parameters.AddWithValue("@marca", Textmarca.Text.Trim());
                        cmd.Parameters.AddWithValue("@modelo", Textmodelo.Text.Trim());
                        cmd.Parameters.AddWithValue("@placa", Textplaca.Text.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@ano", int.Parse(Textanodefab.Text.Trim()));
                        cmd.Parameters.AddWithValue("@id", selectedVeiculoId);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Veículo atualizado com sucesso!");
                CarregarVeiculos();
                btnSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar veículo: {ex.Message}");
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (selectedVeiculoId == -1) return;

            var confirm = MessageBox.Show("Deseja realmente excluir este veículo?", "Confirmação", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string sql = "DELETE FROM veiculos WHERE id=@id";
                    using (var cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedVeiculoId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Veículo excluído com sucesso!");
                CarregarVeiculos();
                btnSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir veículo: {ex.Message}");
            }
        }

        private void LimparCampos()
        {
            Textnamecliente.Clear();
            Textmarca.Clear();
            Textmodelo.Clear();
            Textplaca.Clear();
            Textanodefab.Clear();

            selectedVeiculoId = -1;
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        #endregion
    }
}
