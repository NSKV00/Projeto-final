using MySql.Data.MySqlClient;

namespace SistemaFarmacia.Database
{
    public class Conexao
    {
        private const string connectionString = "server=mysql-meusite.alwaysdata.net;port=3306;database=meusite_db_senac;user=meusite_dbuser;password=Lagartixa17.;";

        public static MySqlConnection ObterConexao()
        {
            var conexao = new MySqlConnection(connectionString);
            conexao.Open();
            return conexao;
        }
    }
}
