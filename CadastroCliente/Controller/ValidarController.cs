using CadastroCliente.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente.Controller
{
    public class ValidarController
    {
        public List<string> Validar(Cliente cliente)
        {
            List<string> erro = new List<string>();
            if(cliente.Cidade == null || cliente.Cidade == "")
            {
                erro.Add("O campo cidade é obrigatório \r\n");
            }
            else if(cliente.Documento == null || cliente.Documento == "" ||
                cliente.Documento.Length < 11)
            {
                erro.Add("O campo documento é obrigatório e deve ser valido \r\n");

            }
            else if (cliente.Endereco == null || cliente.Endereco == "")
            {
                erro.Add("O campo endereço é obrigatório \r\n");

            }
            else if (cliente.Nome == null || cliente.Nome == "")
            {
                erro.Add("O campo Nome é obrigatório \r\n");

            }
            else if (cliente.Telefone == 0)
            {
                erro.Add("O campo Telefone é obrigatório \r\n");

            }
            else if (cliente.Uf == null || cliente.Uf == "")
            {
                erro.Add("O campo UF é obrigatório \r\n");
            }

            return erro;
        }
    }
}
