using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;


namespace ControleOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            {
                dgvOS.Columns.Add("Id", "Id");
                dgvOS.Columns.Add("Cliente", "Cliente");
                dgvOS.Columns.Add("Dataa", "Dataa");
                dgvOS.Columns.Add("Descricao", "Descrição");
                dgvOS.Columns.Add("Valor", "Valor");
                dgvOS.Columns.Add("Status", "Status");
            }

            {
                CarregarOrdens();
            }
        }




        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text) ||
                string.IsNullOrWhiteSpace(txtDescricao.Text) ||
                string.IsNullOrWhiteSpace(cmbStatus.Text))
            {
                MessageBox.Show("Por favor preencha todos os campos");
                return;
            }

            try
            {
                using (var conexao = Conexao.ObterConexao())
                using (var cmd = conexao.CreateCommand())
                {
                    string sql = @"INSERT INTO cliente (nome, `dataa`, descricao, valor, status) 
                           VALUES (@nome, @dataa, @descricao, @valor, @status);
                           SELECT LAST_INSERT_ID();";

                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@nome", txtCliente.Text);
                    cmd.Parameters.AddWithValue("@dataa", dtpData.Value);
                    cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                    cmd.Parameters.AddWithValue("@valor", numValor.Value);
                    cmd.Parameters.AddWithValue("@status", cmbStatus.Text);


                    int novoId = Convert.ToInt32(cmd.ExecuteScalar());

                    MessageBox.Show($"Dados salvos com sucesso! ID: {novoId}");
                }


                CarregarOrdens();


                txtCliente.Clear();
                dtpData.Value = DateTime.Now;
                txtDescricao.Clear();
                numValor.Value = 0;
                cmbStatus.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar os dados: {ex.Message}");
            }
        }

        private void CarregarOrdens()
        {
            using (var conexao = Conexao.ObterConexao())
            using (var cmd = conexao.CreateCommand())
            {
                cmd.CommandText = "SELECT id, nome, status FROM cliente";

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvOS.DataSource = dt;
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(btnEditar.Text))
                {
                    MessageBox.Show("Selecione uma ordem de serviço para editar.");
                    return;
                }

                try
                {
                    using (var conexao = Conexao.ObterConexao())
                    using (var cmd = conexao.CreateCommand())
                    {
                        cmd.CommandText = @"UPDATE cliente 
                                SET nome = @nome, dataa = @dataa, descricao = @descricao, valor = @valor, status = @status 
                                WHERE id = @id";

                        cmd.Parameters.AddWithValue("@nome", txtCliente.Text);
                        cmd.Parameters.AddWithValue("@dataa", dtpData.Value);
                        cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                        cmd.Parameters.AddWithValue("@valor", numValor.Value);
                        cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(btnEditar.Text));

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Ordem de serviço atualizada com sucesso!");
                    }

                    
                    CarregarOrdens();

                   
                    txtCliente.Clear();
                    dtpData.Value = DateTime.Now;
                    txtDescricao.Clear();
                    numValor.Value = 0;
                    cmbStatus.SelectedIndex = -1;
                    Editar.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao editar: {ex.Message}");
                }
            }
        }
    }
}

                 

