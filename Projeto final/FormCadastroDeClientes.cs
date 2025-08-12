using MySql.Data.MySqlClient;
using SistemaFarmacia.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_final
{
    public partial class FormCadastroDeClientes : Form
    {
        public FormCadastroDeClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCpf.Text) ||
               string.IsNullOrWhiteSpace(txtNome.Text) ||
               string.IsNullOrWhiteSpace(txtCep.Text) ||
               string.IsNullOrWhiteSpace(txtTelefone.Text))
            {
                MessageBox.Show("por favor preencha todos os campos");
                return;
            }
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;
            string cep = txtCep.Text;
            string telefone = txtTelefone.Text;

            using (var conexao = Conexao.ObterConexao())
            {
                string query = "INSERT INTO cliente(nome, cpf, telefone, cep) " +
                    "values(@nome, @cpf, @telefone, @cep)";

                using (var cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@cep", txtCep.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("cliente cadastrado");

                    txtCpf.Clear();
                    txtNome.Clear();
                    txtTelefone.Clear();
                    txtCep.Clear();
                }
            }

        }
    }
}
