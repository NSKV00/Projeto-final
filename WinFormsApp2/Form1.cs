using MySqlConnector;
using System;
using System.Windows.Forms;

namespace ControleOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dgvOS.Columns.Add("Id", "Id");
            dgvOS.Columns.Add("Cliente", "Cliente");
            dgvOS.Columns.Add("Dataa", "Dataa");
            dgvOS.Columns.Add("Descricao", "Descrição");
            dgvOS.Columns.Add("Valor", "Valor");
            dgvOS.Columns.Add("Status", "Status");
        }




        private void btnSalvar_Click(object sender, EventArgs e)
        {

            {
                if (string.IsNullOrWhiteSpace(txtCliente.Text) ||
                   string.IsNullOrWhiteSpace(dtpData.Text) ||
                   string.IsNullOrWhiteSpace(txtDescricao.Text) ||
                   string.IsNullOrWhiteSpace(numValor.Text) ||
                   string.IsNullOrWhiteSpace(cmbStatus.Text))
                {
                    MessageBox.Show("Por favor preencha todos os campos");
                    return;
                }

                try
                {
                    using (var conexao = Conexao.ObterConexao())
                    {
                        string sql = @"INSERT INTO cliente ( nome, `dataa` , descricao, valor, status) 
                        VALUES ( @nome, @dataa , @descricao, @valor, @status)";


                        MySqlCommand cmd = new MySqlCommand(sql, conexao);
                        {
                            cmd.Parameters.AddWithValue("@nome", txtCliente.Text);
                            cmd.Parameters.AddWithValue("@dataa", dtpData.Value);
                            cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                            cmd.Parameters.AddWithValue("@valor", numValor.Text);
                            cmd.Parameters.AddWithValue("@status", (cmbStatus.Text));


                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Dados salvos com sucesso!");

                            txtCliente.Clear();
                            dtpData.Value = DateTime.Now;
                            txtDescricao.Clear();
                            numValor.Value = 0;
                            cmbStatus.SelectedIndex = -1;


                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar os dados: {ex.Message}");
                    return;
                }


            }
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Quer mesmo apagar esse registro?", "Confirmação de Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("- Registro apagado com sucesso -");
            }
            else
            {
                MessageBox.Show("- Ação cancelado -");
            }
        }
    }
}

          

       
        

        

        
