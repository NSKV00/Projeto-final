using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Conexao
{
    private const string connectionString = "server=mysql-csharp.alwaysdata.net;port=3306;database=csharp_db;user=csharp;password=rubinick37nene;";

    public static MySqlConnection ObterConexao()
    {
        var conexao = new MySqlConnection(connectionString);
        conexao.Open();
        return conexao;
    }
}

