//using MySql.Data.MySqlClient;
//using SistemaFarmacia.Database;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Projeto_final.Forms.Clientes
//{
//    public partial class Cliente : Form
//    {
//        public Cliente()
//        {
//            InitializeComponent();
//        }
//    }
//}


﻿using MySql.Data.MySqlClient;
using SistemaDatabase.Conexoes;
//using SistemaFarmacia.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_final.Forms.Clientes
{
    public partial class Cliente : Form
    {
        private bool validacaoCpf(string cpf)
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

        public Cliente()
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
            if (!validacaoCpf(txtCpf.Text))
            {
                MessageBox.Show("esse CPF é invalido.");
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

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}