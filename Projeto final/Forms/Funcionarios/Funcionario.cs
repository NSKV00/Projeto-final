using MySql.Data.MySqlClient;
using SistemaDatabase.Conexoes;
using System;
using System.Windows.Forms;

namespace Projeto_final.Forms.Funcionarios
{
    public partial class Funcionario : Form
    {
        private bool ValidarCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        public Funcionario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
               string.IsNullOrWhiteSpace(txtContato.Text) ||
               string.IsNullOrWhiteSpace(txtCpf.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            if (!ValidarCpf(txtCpf.Text))
            {
                MessageBox.Show("Esse CPF é inválido.");
                return;
            }

            using (var conexao = Conexao.ObterConexao())
            {
                string query = "INSERT INTO funcionario (nome, contato, cpf) " +
                               "VALUES (@nome, @contato, @cpf)";

                using (var cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@contato", txtContato.Text);
                    cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Funcionário cadastrado com sucesso!");

                    txtNome.Clear();
                    txtContato.Clear();
                    txtCpf.Clear();
                }
            }
        }
    }
}

