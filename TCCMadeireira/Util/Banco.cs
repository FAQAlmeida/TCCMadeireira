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
        #region Cliente
        /// <summary>
        /// Overload do metódo "InserirCliente" do TableAdapter para suportar o objeto cliente
        /// </summary>
        /// <param name="cliente"> Objeto cliente, que devera conter todas as informações do cliente</param>
        public void InsertCliente(Cliente cliente)
        {
            CLIENTESTableAdapter clientesTableAdapter = new CLIENTESTableAdapter();
            clientesTableAdapter.Insert(cliente.Nome, cliente.Identidade, cliente.Cep, cliente.Rua, cliente.Numero, cliente.Bairro, cliente.Cidade, cliente.Estado, cliente.Telefone, cliente.Celular, cliente.Email, cliente.DataInfo, cliente.Obs);
        }
        /// <summary>
        /// Overload do metódo SelectCliente do TableAdapter  
        /// </summary>
        /// <param name="iden">Identidade para se pesquisar um cliente </param>
        /// <returns>DataTable com o cliente pesquisar </returns>
        public CLIENTESDataTable SelectCliente(string iden)
        {
            CLIENTESTableAdapter clientesTableAdapter = new CLIENTESTableAdapter();
            return clientesTableAdapter.GetDataCliente(iden);
        }
        /// <summary>
         /// Overload do metódo "UpdateCliente" do TableAdapter para suportar o objeto cliente
         /// </summary>
         /// <param name="cliente"> Objeto cliente, que devera conter todas as informações do cliente</param>
        public void UpdateCliente(Cliente cliente)
        {
            CLIENTESTableAdapter clientesTableAdapter = new CLIENTESTableAdapter();
            clientesTableAdapter.Update(cliente.Nome, cliente.Cep, cliente.Rua, cliente.Numero, cliente.Bairro, cliente.Cidade, cliente.Estado, cliente.Telefone, cliente.Celular, cliente.Email, cliente.DataInfo, cliente.Obs, cliente.Identidade);
        }
        #endregion
        #region Funcionario
        /// <summary>
        /// Overload do metódo "InserirFuncionario" do TableAdapter para suportar o objeto funcionario
        /// </summary>
        /// <param name="funcionario"> Objeto funcionario, que devera conter todas as informações do funcionario</param>
        public void InsertFuncionario(Funcionario funcionario)
        {
            FUNCIONARIOSTableAdapter funcionariosTableAdapter = new FUNCIONARIOSTableAdapter();
            funcionariosTableAdapter.Insert(funcionario.Nome, funcionario.Identidade, funcionario.Cargo, funcionario.Cep, funcionario.Rua, funcionario.Numero, funcionario.Bairro, funcionario.Cidade, funcionario.Estado, funcionario.Telefone, funcionario.Celular, funcionario.Email, funcionario.DataInfo, funcionario.Obs);
        }
        /// <summary>
         /// Overload do metódo SelectFuncionario do TableAdapter  
         /// </summary>
         /// <param name="iden">Identidade para se pesquisar um funcionario</param>
         /// <returns>DataTable com o funcionario pesquisar</returns>
        public FUNCIONARIOSDataTable SelectFuncionario(string iden)
        {
            FUNCIONARIOSTableAdapter funcionariosTableAdapter = new FUNCIONARIOSTableAdapter();
            return funcionariosTableAdapter.GetDataFuncionario(iden);
        }
        /// <summary>
        /// Overload do metódo "UpdateFuncionario" do TableAdapter para suportar o objeto funcionario
        /// </summary>
        /// <param name="funcionario">Objeto funcionario, que devera conter todas as informações do funcionario</param>
        public void UpdateFuncionario(Funcionario funcionario)
        {
            FUNCIONARIOSTableAdapter funcionariosTableAdapter = new FUNCIONARIOSTableAdapter();
            funcionariosTableAdapter.Update(funcionario.Nome,  funcionario.Cargo, funcionario.Cep, funcionario.Rua, funcionario.Numero, funcionario.Bairro, funcionario.Cidade, funcionario.Estado, funcionario.Telefone, funcionario.Celular, funcionario.Email, funcionario.DataInfo, funcionario.Obs, funcionario.Identidade);
        }
        #endregion
    }
}
