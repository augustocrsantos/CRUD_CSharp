using CadastroCliente.Controller;
using CadastroCliente.Entidade;
using CadastroCliente.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCliente.View
{
    public partial class FrmCliente : Form
    {
        private Cliente cliente;
        private DaoClienteController dao;
        private List<Cliente> listIdCliente;
        private int W_index = 0;

        public FrmCliente()
        {
            InitializeComponent();
            cliente = new Cliente();
            dao = new DaoClienteController();
            listIdCliente = new List<Cliente>();
            CarregaCombox();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        { try
            {
                string erro = Validacao(CarregaValores(cliente));
                if (erro == null)
                {
                    if (maskedTextBoxCodigo.Text != "" && maskedTextBoxCodigo.Text != null)
                    {
                        cliente.IdCliente = Convert.ToInt32(maskedTextBoxCodigo.Text);
                        dao.UpdateCliente(CarregaValores(cliente));
                        MessageBox.Show("Dados Atualizados com sucesso");                        
                    }
                    else
                    {
                        dao.SalvarCliente(CarregaValores(cliente));
                        limparCampos();
                        MessageBox.Show("Dados Salvos com sucesso");
                    }
                }
                else
                {
                    MessageBox.Show(erro);
                }
              
            }catch(Exception erro)
            {
                MessageBox.Show("Erro ao salvar Dados  " +erro);
            }
           
        }
        private void CarregaCombox()
        {
            comboBoxUf.DataSource = Enum.GetValues(typeof(UfEnum.Uf));            
        }

        private Cliente CarregaValores (Cliente cliente)
        {  
            cliente.Nome = maskedTextBoxNome.Text;
            cliente.Telefone = maskedTextBoxTelefone.Text != "" ?
            Convert.ToInt32(maskedTextBoxTelefone.Text) : 0;
            cliente.Cidade = maskedTextBoxTelefone.Text;
            cliente.Documento = maskedTextBoxDocumento.Text;
            cliente.Endereco = maskedTextBoxEndereco.Text;
            cliente.Uf = comboBoxUf.Text;           

            return cliente;
        }
        
        private void limparCampos()
        {
            maskedTextBoxCodigo.Clear();
            maskedTextBoxNome.Clear();
            maskedTextBoxTelefone.Clear();
            maskedTextBoxTelefone.Clear();
            maskedTextBoxDocumento.Clear();
            maskedTextBoxEndereco.Clear();
            maskedTextBoxCidade.Clear();            
            comboBoxUf.SelectedIndex = -1;            
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            comboBoxUf.SelectedIndex = -1;           
            HabilitaDesabilitaCampos(false,false,false);
            HabilitaBotao(true,false,true,false,false,false,false);
        }

        private void FrmCliente_Shown(object sender, EventArgs e)
        {
         
        }
        private void HabilitaDesabilitaCampos(bool status, bool Idcliente, bool nome)
        {           
            maskedTextBoxCidade.Enabled = status;
            maskedTextBoxCodigo.Enabled = Idcliente;
            maskedTextBoxDocumento.Enabled = status;
            maskedTextBoxEndereco.Enabled = status;
            maskedTextBoxNome.Enabled = nome;
            maskedTextBoxTelefone.Enabled = status;          
            comboBoxUf.Enabled = status;
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            HabilitaDesabilitaCampos(false, true, true);
            HabilitaBotao(true, false, true, true, false, false, false);
            labelTotalRegistro.Visible = false;
            limparCampos();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            HabilitaBotao(true, true, true, true, true, true, true);
            string where = "";
           if(maskedTextBoxCodigo.Text != "" || maskedTextBoxNome.Text != "")
           {
                where = " WHERE ";
                where += maskedTextBoxCodigo.Text !=""? " CLI_CD = "+ maskedTextBoxCodigo.Text: " ";
                where += maskedTextBoxCodigo.Text != "" && maskedTextBoxNome.Text != "" ? "AND" : " ";
                where += maskedTextBoxNome.Text != "" ? " CLI_NOME = '" + maskedTextBoxNome.Text + "'" : " ";
           }
            listIdCliente = dao.RetonaIdCliente(where);
            if (!listIdCliente.Any())
            {
                MessageBox.Show("Cliente não cadastrado");
            }
            else
            {
                labelTotalRegistro.Visible = true;
                labelTotalRegistro.Text = "Total de Registros: " + listIdCliente.Count;
                PreencherCampos(dao.PesquisaCliente(listIdCliente.First()));
            }
            
               HabilitaDesabilitaCampos(true, false, true);
            
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            HabilitaDesabilitaCampos(true, false, true);
            HabilitaBotao(true, false, true, false, false, false, true);
            limparCampos();
            labelTotalRegistro.Visible = false;
        }
        private void PreencherCampos(Cliente cliente)
        {
             maskedTextBoxCodigo.Text = cliente.IdCliente.ToString();
             maskedTextBoxNome.Text = cliente.Nome;
             maskedTextBoxTelefone.Text = cliente.Telefone.ToString();
             maskedTextBoxCidade.Text = cliente.Cidade;
             maskedTextBoxDocumento.Text = cliente.Documento;
             maskedTextBoxEndereco.Text = cliente.Endereco;
            CarregaCombox();
            comboBoxUf.SelectedIndex = -1;
             comboBoxUf.SelectedText = cliente.Uf;          
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            if (listIdCliente.Any())
            {
                if ( W_index-1 >= 0)
                {
                    W_index = W_index - 1;
                    PreencherCampos(dao.PesquisaCliente(listIdCliente[W_index]));
                }
                else
                {
                    MessageBox.Show("Este é o primeiro registro");
                }
            }

        }

        private void buttonProximo_Click(object sender, EventArgs e)
        {
            if (listIdCliente.Any())
            {
                if(listIdCliente.Count > W_index+1)
                {
                    W_index = W_index + 1;
                    PreencherCampos(dao.PesquisaCliente(listIdCliente[W_index]));
                }
                else
                {
                    MessageBox.Show("Este é o ultimo registro");
                }
            }
        }
        private void HabilitaBotao(bool incluir, bool excluir, bool pesquisar, bool buscar,
            bool proximo, bool anterior, bool salvar)
        {
            buttonPesquisar.Enabled = pesquisar;
            buttonAnterior.Enabled = anterior;
            buttonProximo.Enabled = proximo;
            buttonInserir.Enabled = incluir;
            buttonExcluir.Enabled = excluir;
            buttonBuscar.Enabled = buscar;
            buttonSalvar.Enabled = salvar;
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja excluir registro", "Excluir Registro", 
            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
            {
                if (dao.DeletarRegistro(maskedTextBoxCodigo.Text))
                {
                    MessageBox.Show("Registro excluido com sucesso!");
                    limparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir registro, Verifique!");
                }
            }
        }
        private string Validacao(Cliente cliente)
        {
            string adicionaErro = null;
            ValidarController validarController = new ValidarController();
            List<string> erro = validarController.Validar(cliente);
            if (erro != null)
            {
                foreach (var item in erro)
                {
                    adicionaErro += item;

                }
                return adicionaErro;
            }
            else
            {
                return null;
            }
        }

        private void maskedTextBoxDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir somente numeros
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
