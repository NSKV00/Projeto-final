using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_final.Conexao
{
    public class Conexao
    {
        private const string ConnectionString = "server=mysql-kauan.alwaysdata.net;port=3306;database=kauan_house;user=kauan;password=26v23c17k20l;";

    

    public static MySqlConnection ObterConexao()
        {
            var Conexao = new MySqlConnection(ConnectionString);
            Conexao.Open();
            return Conexao;
        }
    }
}
