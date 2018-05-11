using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCCMadeireira.Bancos;
using TCCMadeireira.Bancos.DataSetMadeireiraV2TableAdapters;
using TCCMadeireira.Model;
using TCCMadeireira.Models;
using static TCCMadeireira.Bancos.DataSetMadeireiraV2;

namespace TCCMadeireira.Bancos
{
    /// <summary>
    /// Classe utilizada para acessar os table Adapters utilizado objetos
    /// <para>tem função de reduzir o código nos Frms</para>
    /// </summary>
    /// TODO Edit XML Comment Template for Banco
    class Banco
    {
        #region Atributos @TableAdapter
        private CLIENTESTableAdapter clientesTableAdapter = new CLIENTESTableAdapter();
        private FUNCIONARIOSTableAdapter funcionariosTableAdapter = new FUNCIONARIOSTableAdapter();
        private FORNECEDORESTableAdapter fornecedoresTableAdapter = new FORNECEDORESTableAdapter();
        private FORNECIMENTOSTableAdapter fornecimentosTableAdapter = new FORNECIMENTOSTableAdapter();
        private PRODUTOSTableAdapter produtosTableAdapter = new PRODUTOSTableAdapter();
        private VENDA_PRODUTOTableAdapter vendaprodutoTableAdapter = new VENDA_PRODUTOTableAdapter();
        private USERSTableAdapter usersTableAdapter = new USERSTableAdapter();
        private VENDASTableAdapter vendasTableAdapter = new VENDASTableAdapter();
        #endregion
        #region Cliente
        /// <summary>
        /// Overload do metódo "InserirCliente" do TableAdapter para suportar o objeto cliente
        /// </summary>
        /// <param name="cliente"> Objeto cliente, que devera conter todas as informações do cliente</param>
        public void InsertCliente(Cliente cliente)
        {
            clientesTableAdapter.Insert(cliente.Nome, cliente.Identidade, cliente.Cep, cliente.Rua, cliente.Numero, cliente.Bairro, cliente.Cidade, cliente.Estado, cliente.Telefone, cliente.Celular, cliente.Email, cliente.DataInfo, cliente.Obs);
        }
        /// <summary>
        /// Overload do metódo SelectCliente do TableAdapter  
        /// </summary>
        /// <param name="iden">Identidade para se pesquisar um cliente </param>
        /// <returns>DataTable com o cliente pesquisar </returns>
        public CLIENTESDataTable SelectCliente(string iden)
        {            
            return clientesTableAdapter.GetDataCliente(iden);
        }
        /// <summary>
         /// Overload do metódo "UpdateCliente" do TableAdapter para suportar o objeto cliente
         /// </summary>
         /// <param name="cliente"> Objeto cliente, que devera conter todas as informações do cliente</param>
        public void UpdateCliente(Cliente cliente)
        {
            clientesTableAdapter.Update(cliente.Nome,cliente.Identidade, cliente.Cep, cliente.Rua, cliente.Numero, cliente.Bairro, cliente.Cidade, cliente.Estado, cliente.Telefone, cliente.Celular, cliente.Email, cliente.DataInfo, cliente.Obs, cliente.Id);
        }
        public void DeleteCliente (Cliente cliente)
        {
            CLIENTESDataTable clientedt = SelectCliente(cliente.Identidade);
            clientesTableAdapter.Delete(Convert.ToInt32(clientedt.Rows[0]["id_cliente"]));
        }
        public CLIENTESDataTable SelectCliente()
        {
            return clientesTableAdapter.GetData();
        }
        #endregion
        #region Funcionario
        /// <summary>
        /// Overload do metódo "InserirFuncionario" do TableAdapter para suportar o objeto funcionario
        /// </summary>
        /// <param name="funcionario"> Objeto funcionario, que devera conter todas as informações do funcionario</param>
        public void InsertFuncionario(Funcionario funcionario)
        {            
            funcionariosTableAdapter.Insert(funcionario.Nome, funcionario.Identidade, funcionario.Cargo, funcionario.Cep, funcionario.Rua, funcionario.Numero, funcionario.Bairro, funcionario.Cidade, funcionario.Estado, funcionario.Telefone, funcionario.Celular, funcionario.Email, funcionario.DataInfo, funcionario.Obs);
        }
        /// <summary>
         /// Overload do metódo SelectFuncionario do TableAdapter  
         /// </summary>
         /// <param name="iden">Identidade para se pesquisar um funcionario</param>
         /// <returns>DataTable com o funcionario pesquisar</returns>
        public FUNCIONARIOSDataTable SelectFuncionario(string iden)
        {
            return funcionariosTableAdapter.GetDataFuncionario(iden);
        }
        /// <summary>
        /// Overload do metódo "UpdateFuncionario" do TableAdapter para suportar o objeto funcionario
        /// </summary>
        /// <param name="funcionario">Objeto funcionario, que devera conter todas as informações do funcionario</param>
        public void UpdateFuncionario(Funcionario funcionario)
        {
            funcionariosTableAdapter.Update(funcionario.Nome,funcionario.Identidade, funcionario.Cargo, funcionario.Cep, funcionario.Rua, funcionario.Numero, funcionario.Bairro, funcionario.Cidade, funcionario.Estado, funcionario.Telefone, funcionario.Celular, funcionario.Email, funcionario.DataInfo, funcionario.Obs, funcionario.Id);
        }
        public FUNCIONARIOSDataTable SelectFuncionario()
        {
            return funcionariosTableAdapter.GetData();
        }
        public void DeleteFuncionario(Funcionario funcionario)
        {
            FUNCIONARIOSDataTable funcionariodt = SelectFuncionario(funcionario.Identidade);
            funcionariosTableAdapter.Delete(Convert.ToInt32(funcionariodt[0]["id_funcionario"]));
        }
        #endregion
    }
}
