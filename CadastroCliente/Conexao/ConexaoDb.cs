using CadastroCliente.Entidade;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente.Conexao
{
   public class ConexaoDb
    {
        public FbConnection getConexao()
        {
            try
            {
                string conn = "Server=localhost;User=SYSDBA;Password=masterkey;Database=D:\\Banco_dados_fireBird\\AVALIACAO.FDB";
                //ConfigurationManager.ConnectionStrings["FireBirdConnection"].ToString();
                return new FbConnection(conn);
            }catch(Exception e)
            {
                return null;
            }
           
        }

        
    }
}
