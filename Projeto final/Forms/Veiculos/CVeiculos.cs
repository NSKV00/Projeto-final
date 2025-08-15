using MySql.Data.MySqlClient;
using SistemaFarmacia.Database;
using System.Text.RegularExpressions;

namespace Projeto_final
{
    public partial class Cveiculos : Form
    {
        public Cveiculos()
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
                using (var conexao = Conexao.ObterConexao())
                {
                    string sql = @"INSERT INTO veiculos (nome_cliente, marca, modelo, placa, ano_fabricacao) 
                        VALUES (@nome_cliente, @marca, @modelo, @placa, @ano_fabricacao)";


                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    {
                        cmd.Parameters.AddWithValue("@nome_cliente", Textnamecliente.Text);
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

        private void Cveiculos_Load(object sender, EventArgs e)
        {

        }

        private void Textmodelo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}