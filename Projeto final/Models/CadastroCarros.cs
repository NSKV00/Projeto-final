using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_final.Models
{

   
        public class Admin
        {
            public int Id { get; set; }
            public string Usuario { get; set; }
            public string Senha { get; set; }

          
        }
           internal class CadastroCarros
    {

        public string NomeCliente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public int AnoDeFabricacao { get; set; }
        public int Cliente_Id { get; set; }

        public List<CadastroCarros> Veiculos { get; set; } = new List<CadastroCarros>();

    }
}
