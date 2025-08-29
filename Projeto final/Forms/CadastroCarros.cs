using MySqlConnector;
using MySqlX.XDevAPI;
using Projeto_final.Conexao;
using System.Data;
using System.Text.RegularExpressions;

namespace Projeto_final
{
    public partial class CadastroCarros : Form
    {
        public CadastroCarros()
        {
            InitializeComponent();


        }

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
                MessageBox.Show("Placa inválida. O formato correto é ABC1D23 (3 letras, 1 número, 1 letra, 2 números).");
                Textplaca.Focus();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Textnamecliente.Text) ||
               string.IsNullOrWhiteSpace(Textmarca.Text) ||
               string.IsNullOrWhiteSpace(Textmodelo.Text) ||
               string.IsNullOrWhiteSpace(Textplaca.Text) ||
               string.IsNullOrWhiteSpace(Textanodefab.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            if (!ValidarPlaca(Textplaca.Text))
            {
                MessageBox.Show("Placa inválida. O formato correto é ABC1D23 (3 letras, 1 número, 1 letra, 2 números).");
                return;
            }


            try
            {
                using (var conexao = Conexao.Conexao.ObterConexao())
                {
                    string sql = @"INSERT INTO veiculos (cpf_cliente, marca, modelo, placa, ano_fabricacao) 
                        VALUES (@cpf_cliente, @marca, @modelo, @placa, @ano_fabricacao)";

                    string queryCliente = "SELECT id, nome FROM cliente WHERE cpf = @cpf_cliente";

                    using (var checkCmd = new MySqlCommand(queryCliente, conexao))
                    {
                        checkCmd.Parameters.AddWithValue("@cpf_cliente", Textnamecliente.Text);

                        using (var reader = checkCmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("CPF não encontrado no cadastro de clientes!");
                                return; 
                            }
                        }
                    }

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    {

                        cmd.Parameters.AddWithValue("@cpf_cliente", Textnamecliente.Text);
                        cmd.Parameters.AddWithValue("@marca", Textmarca.Text);
                        cmd.Parameters.AddWithValue("@modelo", Textmodelo.Text);
                        cmd.Parameters.AddWithValue("@placa", Textplaca.Text);
                        cmd.Parameters.AddWithValue("@ano_fabricacao", int.Parse(Textanodefab.Text));


                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Dados salvos com sucesso!");

                        Textnamecliente.Clear();
                        Textmarca.Clear();
                        Textmodelo.Clear();
                        Textplaca.Clear();
                        Textanodefab.Clear();

                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar os dados: {ex.Message}");
                return;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
