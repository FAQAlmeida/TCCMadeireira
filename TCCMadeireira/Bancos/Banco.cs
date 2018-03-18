using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCCMadeireira.Bancos;
using TCCMadeireira.Bancos.DataSetMadeireiraTableAdapters;
using TCCMadeireira.Model;
using TCCMadeireira.Models;
using static TCCMadeireira.Bancos.DataSetMadeireira;

namespace TCCMadeireira.Bancos
{
    /// <summary>
    /// Classe utilizada para acessar os table Adapters utilizado objetos
    /// <para>tem função de reduxir o código nos Frms</para>
    /// </summary>
    /// TODO Edit XML Comment Template for Banco
    class Banco
    {
        #region Cliente
        public void InsertCliente(Cliente cliente)
        {
            CLIENTESTableAdapter cLIENTESTableAdapter = new CLIENTESTableAdapter();
            cLIENTESTableAdapter.Insert(cliente.Nome, cliente.Identidade, cliente.Cep, cliente.Rua, cliente.Numero, cliente.Bairro, cliente.Cidade, cliente.Estado, cliente.Telefone, cliente.Celular, cliente.Email, cliente.DataInfo, cliente.Obs);
        }
        public CLIENTESDataTable SelectCliente(string iden)
        {
            CLIENTESTableAdapter cLIENTESTableAdapter = new CLIENTESTableAdapter();
            return cLIENTESTableAdapter.GetDataCliente(iden);
        }
        public void UpdateCliente(Cliente cliente)
        {
            CLIENTESTableAdapter cLIENTESTableAdapter = new CLIENTESTableAdapter();
            cLIENTESTableAdapter.Update(cliente.Nome, cliente.Cep, cliente.Rua, cliente.Numero, cliente.Bairro, cliente.Cidade, cliente.Estado, cliente.Telefone, cliente.Celular, cliente.Email, cliente.DataInfo, cliente.Obs, cliente.Identidade);
        }
        #endregion
        #region Funcionario
        public void InsertFuncionario(Funcionario funcionario)
        {
            FUNCIONARIOSTableAdapter fUNCIONARIOSTableAdapter = new FUNCIONARIOSTableAdapter();
            fUNCIONARIOSTableAdapter.Insert(funcionario.Nome, funcionario.Identidade, funcionario.Cargo, funcionario.Cep, funcionario.Rua, funcionario.Numero, funcionario.Bairro, funcionario.Cidade, funcionario.Estado, funcionario.Telefone, funcionario.Celular, funcionario.Email, funcionario.DataInfo, funcionario.Obs);
        }
        public FUNCIONARIOSDataTable SelectFuncionario(string iden)
        {
            FUNCIONARIOSTableAdapter fUNCIONARIOSTableAdapter = new FUNCIONARIOSTableAdapter();
            return fUNCIONARIOSTableAdapter.GetDataFuncionario(iden);
        }
        public void UpdateFuncionario(Funcionario funcionario)
        {
            FUNCIONARIOSTableAdapter fUNCIONARIOSTableAdapter = new FUNCIONARIOSTableAdapter();
            fUNCIONARIOSTableAdapter.Update(funcionario.Nome,  funcionario.Cargo, funcionario.Cep, funcionario.Rua, funcionario.Numero, funcionario.Bairro, funcionario.Cidade, funcionario.Estado, funcionario.Telefone, funcionario.Celular, funcionario.Email, funcionario.DataInfo, funcionario.Obs, funcionario.Identidade);
        }
        #endregion
    }
}
