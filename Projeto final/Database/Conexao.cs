using MySql.Data.MySqlClient;

namespace SistemaDatabase.Conexoes
{
    public class Conexao
    {
        private const string connectionString = "server=mysql-nskv00.alwaysdata.net;port=3306;database=nskv00_projetofinal;user=nskv00_;password=Nicolas@05;";

        public static MySqlConnection ObterConexao()
        {
            var conexao = new MySqlConnection(connectionString);
            conexao.Open();
            return conexao;
        }
    }
}