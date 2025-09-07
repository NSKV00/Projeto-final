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
            CarregarClientes();
            CarregarVeiculos();
            CarregarFuncionarios();
            CarregarFiltros();
            CarregarOS();
        }

        // Carregar ComboBoxes principais
        private void CarregarClientes()
        {
            try
            {
                using (var con = Conexao.ObterConexao())
                {
                    DataTable dt = new DataTable();
                    new MySqlDataAdapter("SELECT cpf, nome FROM cliente WHERE ativo='a'", con).Fill(dt);
                    cmbCliente.DataSource = dt;
                    cmbCliente.DisplayMember = "nome";
                    cmbCliente.ValueMember = "cpf";
                    cmbCliente.SelectedIndex = -1;
                }
            }
            catch (Exception ex) { MessageBox.Show($"Erro ao carregar clientes: {ex.Message}"); }
        }

        private void CarregarVeiculos()
        {
            try
            {
                using (var con = Conexao.ObterConexao())
                {
                    DataTable dt = new DataTable();
                    new MySqlDataAdapter("SELECT placa, modelo FROM veiculos", con).Fill(dt);
                    cmbVeiculo.DataSource = dt;
                    cmbVeiculo.DisplayMember = "modelo";
                    cmbVeiculo.ValueMember = "placa";
                    cmbVeiculo.SelectedIndex = -1;
                }
            }
            catch (Exception ex) { MessageBox.Show($"Erro ao carregar veículos: {ex.Message}"); }
        }

        private void CarregarFuncionarios()
        {
            try
            {
                using (var con = Conexao.ObterConexao())
                {
                    DataTable dt = new DataTable();
                    new MySqlDataAdapter("SELECT cpf, nome FROM funcionario WHERE ativo='a'", con).Fill(dt);
                    cmbFuncionario.DataSource = dt;
                    cmbFuncionario.DisplayMember = "nome";
                    cmbFuncionario.ValueMember = "cpf";
                    cmbFuncionario.SelectedIndex = -1;
                }
            }
            catch (Exception ex) { MessageBox.Show($"Erro ao carregar funcionários: {ex.Message}"); }
        }

        // Carregar ComboBoxes de Filtro
        private void CarregarFiltros()
        {
            try
            {
                using (var con = Conexao.ObterConexao())
                {
                    // Cliente filtro
                    DataTable dtCliente = new DataTable();
                    new MySqlDataAdapter("SELECT cpf, nome FROM cliente WHERE ativo='a'", con).Fill(dtCliente);
                    cmbFiltroCliente.DataSource = dtCliente;
                    cmbFiltroCliente.DisplayMember = "nome";
                    cmbFiltroCliente.ValueMember = "cpf";
                    cmbFiltroCliente.SelectedIndex = -1;

                    // Veículo filtro
                    DataTable dtVeiculo = new DataTable();
                    new MySqlDataAdapter("SELECT placa, modelo FROM veiculos", con).Fill(dtVeiculo);
                    cmbFiltroVeiculo.DataSource = dtVeiculo;
                    cmbFiltroVeiculo.DisplayMember = "modelo";
                    cmbFiltroVeiculo.ValueMember = "placa";
                    cmbFiltroVeiculo.SelectedIndex = -1;

                    // Status filtro já configurado no Designer
                    cmbFiltroStatus.SelectedIndex = 0;

                    // Período default
                    dtpFiltroInicio.Value = DateTime.Now.AddMonths(-1);
                    dtpFiltroFim.Value = DateTime.Now;
                }
            }
            catch (Exception ex) { MessageBox.Show($"Erro ao carregar filtros: {ex.Message}"); }
        }

        private void CarregarOS()
        {
            try
            {
                using (var con = Conexao.ObterConexao())
                {
                    string query = @"SELECT o.id, c.nome AS Cliente, v.modelo AS Veiculo, f.nome AS Funcionario,
                                     o.problema, o.servico, o.data_os,
                                     CASE WHEN o.ativo='a' THEN 'Aberta' ELSE 'Fechada' END AS Status
                                     FROM os o
                                     INNER JOIN cliente c ON o.cpf_cliente = c.cpf
                                     INNER JOIN veiculos v ON o.placa_veiculo = v.placa
                                     INNER JOIN funcionario f ON o.cpf_funcionario = f.cpf";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvOS.DataSource = dt;
                }
            }
            catch (Exception ex) { MessageBox.Show($"Erro ao carregar OS: {ex.Message}"); }
        }

        private void LimparCampos()
        {
            cmbCliente.SelectedIndex = -1;
            cmbVeiculo.SelectedIndex = -1;
            cmbFuncionario.SelectedIndex = -1;
            txtProblema.Clear();
            txtServico.Clear();
            dtpData.Value = DateTime.Now;
        }

        // Botões principais
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex == -1 || cmbVeiculo.SelectedIndex == -1 || cmbFuncionario.SelectedIndex == -1
                || string.IsNullOrWhiteSpace(txtProblema.Text) || string.IsNullOrWhiteSpace(txtServico.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            if (dtpData.Value > DateTime.Now)
            {
                MessageBox.Show("A data não pode ser futura.");
                return;
            }

            try
            {
                using (var con = Conexao.ObterConexao())
                {
                    string sql = @"INSERT INTO os (cpf_cliente, placa_veiculo, cpf_funcionario, problema, data_os, servico, ativo)
                                   VALUES (@cpf_cliente, @placa, @cpf_funcionario, @problema, @data, @servico, 'a')";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@cpf_cliente", cmbCliente.SelectedValue);
                        cmd.Parameters.AddWithValue("@placa", cmbVeiculo.SelectedValue);
                        cmd.Parameters.AddWithValue("@cpf_funcionario", cmbFuncionario.SelectedValue);
                        cmd.Parameters.AddWithValue("@problema", txtProblema.Text);
                        cmd.Parameters.AddWithValue("@servico", txtServico.Text);
                        cmd.Parameters.AddWithValue("@data", dtpData.Value);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("OS salva com sucesso!");
                LimparCampos();
                CarregarOS();
            }
            catch (Exception ex) { MessageBox.Show($"Erro ao salvar OS: {ex.Message}"); }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvOS.SelectedRows.Count == 0) { MessageBox.Show("Selecione uma OS."); return; }

            int id = Convert.ToInt32(dgvOS.SelectedRows[0].Cells["id"].Value);

            try
            {
                using (var con = Conexao.ObterConexao())
                {
                    string sql = @"UPDATE os SET cpf_cliente=@cpf_cliente, placa_veiculo=@placa, cpf_funcionario=@cpf_funcionario,
                                   problema=@problema, servico=@servico, data_os=@data
                                   WHERE id=@id AND ativo='a'";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@cpf_cliente", cmbCliente.SelectedValue);
                        cmd.Parameters.AddWithValue("@placa", cmbVeiculo.SelectedValue);
                        cmd.Parameters.AddWithValue("@cpf_funcionario", cmbFuncionario.SelectedValue);
                        cmd.Parameters.AddWithValue("@problema", txtProblema.Text);
                        cmd.Parameters.AddWithValue("@servico", txtServico.Text);
                        cmd.Parameters.AddWithValue("@data", dtpData.Value);
                        cmd.Parameters.AddWithValue("@id", id);

                        int linhas = cmd.ExecuteNonQuery();
                        if (linhas > 0) MessageBox.Show("OS editada com sucesso!");
                        else MessageBox.Show("Não é possível editar OS fechada.");
                    }
                }
                LimparCampos();
                CarregarOS();
            }
            catch (Exception ex) { MessageBox.Show($"Erro ao editar OS: {ex.Message}"); }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvOS.SelectedRows.Count == 0) { MessageBox.Show("Selecione uma OS."); return; }

            int id = Convert.ToInt32(dgvOS.SelectedRows[0].Cells["id"].Value);
            DialogResult r = MessageBox.Show("Deseja excluir esta OS?", "Confirmação", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                try
                {
                    using (var con = Conexao.ObterConexao())
                    {
                        string sql = "DELETE FROM os WHERE id=@id AND ativo='a'";
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            int linhas = cmd.ExecuteNonQuery();
                            if (linhas > 0) MessageBox.Show("OS excluída.");
                            else MessageBox.Show("Não é possível excluir OS fechada.");
                        }
                    }
                    CarregarOS();
                }
                catch (Exception ex) { MessageBox.Show($"Erro ao excluir OS: {ex.Message}"); }
            }
        }

        private void btnFecharOS_Click(object sender, EventArgs e)
        {
            if (dgvOS.SelectedRows.Count == 0) { MessageBox.Show("Selecione uma OS."); return; }

            int id = Convert.ToInt32(dgvOS.SelectedRows[0].Cells["id"].Value);
            DialogResult r = MessageBox.Show("Deseja fechar esta OS?", "Fechar OS", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                try
                {
                    using (var con = Conexao.ObterConexao())
                    {
                        string sql = "UPDATE os SET ativo='f' WHERE id=@id";
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("OS fechada com sucesso!");
                    CarregarOS();
                }
                catch (Exception ex) { MessageBox.Show($"Erro ao fechar OS: {ex.Message}"); }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = Conexao.ObterConexao())
                {
                    string query = @"SELECT o.id, c.nome AS Cliente, v.modelo AS Veiculo, f.nome AS Funcionario,
                                     o.problema, o.servico, o.data_os,
                                     CASE WHEN o.ativo='a' THEN 'Aberta' ELSE 'Fechada' END AS Status
                                     FROM os o
                                     INNER JOIN cliente c ON o.cpf_cliente = c.cpf
                                     INNER JOIN veiculos v ON o.placa_veiculo = v.placa
                                     INNER JOIN funcionario f ON o.cpf_funcionario = f.cpf
                                     WHERE 1=1";

                    if (cmbFiltroCliente.SelectedValue != null && cmbFiltroCliente.SelectedIndex != -1)
                        query += " AND o.cpf_cliente=@cpfCliente";
                    if (cmbFiltroVeiculo.SelectedValue != null && cmbFiltroVeiculo.SelectedIndex != -1)
                        query += " AND o.placa_veiculo=@placaVeiculo";
                    if (cmbFiltroStatus.SelectedItem.ToString() != "Todas")
                    {
                        string s = cmbFiltroStatus.SelectedItem.ToString() == "Aberta" ? "a" : "f";
                        query += " AND o.ativo=@status";
                    }

                    query += " AND o.data_os BETWEEN @dataInicio AND @dataFim";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        if (cmbFiltroCliente.SelectedValue != null && cmbFiltroCliente.SelectedIndex != -1)
                            cmd.Parameters.AddWithValue("@cpfCliente", cmbFiltroCliente.SelectedValue);
                        if (cmbFiltroVeiculo.SelectedValue != null && cmbFiltroVeiculo.SelectedIndex != -1)
                            cmd.Parameters.AddWithValue("@placaVeiculo", cmbFiltroVeiculo.SelectedValue);
                        if (cmbFiltroStatus.SelectedItem.ToString() != "Todas")
                        {
                            string s = cmbFiltroStatus.SelectedItem.ToString() == "Aberta" ? "a" : "f";
                            cmd.Parameters.AddWithValue("@status", s);
                        }
                        cmd.Parameters.AddWithValue("@dataInicio", dtpFiltroInicio.Value.Date);
                        cmd.Parameters.AddWithValue("@dataFim", dtpFiltroFim.Value.Date.AddDays(1).AddTicks(-1));

                        DataTable dt = new DataTable();
                        new MySqlDataAdapter(cmd).Fill(dt);
                        dgvOS.DataSource = dt;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"Erro ao filtrar OS: {ex.Message}"); }
        }
    }
}
