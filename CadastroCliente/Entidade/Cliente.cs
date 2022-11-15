using CadastroCliente.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente.Entidade
{
   public class Cliente
    {
        public int? IdCliente { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public int? Telefone { get; set; }
        public string Documento { get; set;}
        public string Endereco { get; set; }
        public string Uf { get; set; }
        //Campo transiente usado pesquisar Cliente
        public string TipoDocumentoString { get; set; } 
      
    }
}
