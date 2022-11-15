using CadastroCliente.Conexao;
using CadastroCliente.Entidade;
using CadastroCliente.Funcoes;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente.Controller
{
    public class DaoClienteController
    {
        private ConexaoDb conexao;


        public void SalvarCliente(Cliente cliente)
        {
            conexao = new ConexaoDb();
            using (FbConnection conexaoFireBird = conexao.getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string SQL = "INSERT into CLIENTE (CLI_NOME, CLI_CIDADE, CLI_UF, CLI_TELEFONE, CLI_CPF, CLI_ENDERECO)" +
                                 " Values('" + cliente.Nome + "','" + cliente.Cidade + "','" + cliente.Uf + "'," + cliente.Telefone + ",'"
                                 + cliente.Documento + "','" + cliente.Endereco + "'  )";
                    FbCommand cmd = new FbCommand(SQL, conexaoFireBird);
                    cmd.ExecuteNonQuery();
                }
                catch (FbException e)
                {
                    throw e;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public List<Cliente> RetonaIdCliente( string where)
        {
            conexao = new ConexaoDb();
            ConverteDataTableList converte = new ConverteDataTableList();
            using (FbConnection conexaoFireBird = conexao.getConexao())
            {
                try
                {
                    conexaoFireBird.Open();

                    string SQL = " Select CLI_CD as IdCliente from CLIENTE "+where+ " ORDER BY CLI_CD";
                    FbCommand select = new FbCommand(SQL, conexaoFireBird);
                    FbDataAdapter Adapter = new FbDataAdapter(select);
                    DataTable dataTable = new DataTable();
                    Adapter.Fill(dataTable);

                    return converte.ConverterParaLista<Cliente>(dataTable);

                }
                catch (FbException e)
                {
                    throw e;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }
        public Cliente PesquisaCliente(Cliente cliente)
        {
            conexao = new ConexaoDb();
            ConverteDataTableList converte = new ConverteDataTableList();
            using (FbConnection conexaoFireBird = conexao.getConexao())
            {
                try
                {
                    conexaoFireBird.Open();

                    string SQL =  "  SELECT "
                                + "  CLI_CD AS IdCliente, "
                                + "  CLI_NOME AS Nome, "
                                + "  CLI_CIDADE AS Cidade, "
                                + "  CLI_TELEFONE AS Telefone, "
                                + "  CLI_CPF AS Documento, "
                                + "  CLI_ENDERECO AS Endereco, "
                                + "  CLI_UF AS Uf "
                                + "  FROM CLIENTE  WHERE CLI_CD = "+cliente.IdCliente;  
                    FbCommand select = new FbCommand(SQL, conexaoFireBird);
                    FbDataAdapter Adapter = new FbDataAdapter(select);

                    DataTable dataTable = new DataTable();
                    Adapter.Fill(dataTable);

                    var teste = converte.ConverterParaLista<Cliente>(dataTable).First();
                    return converte.ConverterParaLista<Cliente>(dataTable).First();

                }
                catch (FbException e)
                {
                    throw e;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }
         public bool DeletarRegistro(string Idcliente)
        {
            conexao = new ConexaoDb();
            using (FbConnection conexaoFireBird = conexao.getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string SQL = "delete from CLIENTE where CLI_CD = "+Idcliente;
                    FbCommand cmd = new FbCommand(SQL, conexaoFireBird);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (FbException e)
                {
                    throw e;
                    return false;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
            
        }
        public void UpdateCliente(Cliente cliente)
        {
            conexao = new ConexaoDb();
            using (FbConnection conexaoFireBird = conexao.getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string SQL = " UPDATE  CLIENTE SET CLI_NOME = '" + cliente.Nome + "' "
                               + " ,CLI_CIDADE ='" + cliente.Cidade + "' "
                               + " ,CLI_UF='" + cliente.Uf + "' "
                               + " ,CLI_TELEFONE =" + cliente.Telefone + " "
                               + " ,CLI_CPF ='" + cliente.Documento + "' "
                               + " ,CLI_ENDERECO ='" + cliente.Endereco + "' "
                               + " WHERE CLI_CD = " + cliente.IdCliente + " ";
                    FbCommand cmd = new FbCommand(SQL, conexaoFireBird);
                    cmd.ExecuteNonQuery();
                }
                catch (FbException e)
                {
                    throw e;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

    }
}
