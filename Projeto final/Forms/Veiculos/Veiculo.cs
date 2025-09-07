using MySql.Data.MySqlClient;
using SistemaDatabase.Conexoes;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Projeto_final.Forms.Veiculos
{
    public partial class Veiculo : Form
    {
        public Veiculo()
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

            if (!int.TryParse(Textanodefab.Text, out int anoFab))
            {
                MessageBox.Show("Ano de fabricação inválido. Informe um número inteiro.");
                return;
            }

            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
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

                    string sql = @"INSERT INTO veiculos (cpf_cliente, marca, modelo, placa, ano_fabricacao) 
                                   VALUES (@cpf_cliente, @marca, @modelo, @placa, @ano_fabricacao)";
                    using (var cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@cpf_cliente", Textnamecliente.Text);
                        cmd.Parameters.AddWithValue("@marca", Textmarca.Text);
                        cmd.Parameters.AddWithValue("@modelo", Textmodelo.Text);
                        cmd.Parameters.AddWithValue("@placa", Textplaca.Text.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@ano_fabricacao", anoFab);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Dados salvos com sucesso!");

                    Textnamecliente.Clear();
                    Textmarca.Clear();
                    Textmodelo.Clear();
                    Textplaca.Clear();
                    Textanodefab.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar os dados: {ex.Message}");
            }
        }

        private void Veiculo_Load(object sender, EventArgs e)
        {
     
        }
    }
}
