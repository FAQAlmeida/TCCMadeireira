using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCCMadeireira.Bancos;
using TCCMadeireira.Model;
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
        public void Insert(Cliente cliente)
        {
            DataSetMadeireiraTableAdapters.CLIENTESTableAdapter cLIENTESTableAdapter = new DataSetMadeireiraTableAdapters.CLIENTESTableAdapter();
            cLIENTESTableAdapter.Insert(cliente.Nome, cliente.Identidade, cliente.Cep, cliente.Rua, cliente.Numero, cliente.Bairro, cliente.Cidade, cliente.Estado, cliente.Telefone, cliente.Celular, cliente.Email, cliente.DataInfo, cliente.Obs);
        }
        public CLIENTESDataTable Select(string iden)
        {
            DataSetMadeireiraTableAdapters.CLIENTESTableAdapter cLIENTESTableAdapter = new DataSetMadeireiraTableAdapters.CLIENTESTableAdapter();
            return cLIENTESTableAdapter.GetDataCliente(iden);
        }
        public void Update(Cliente cliente)
        {
            DataSetMadeireiraTableAdapters.CLIENTESTableAdapter cLIENTESTableAdapter = new DataSetMadeireiraTableAdapters.CLIENTESTableAdapter();
            cLIENTESTableAdapter.Update(cliente.Nome, cliente.Cep, cliente.Rua, cliente.Numero, cliente.Bairro, cliente.Cidade, cliente.Estado, cliente.Telefone, cliente.Celular, cliente.Email, cliente.DataInfo, cliente.Obs, cliente.Identidade);
        }
        #endregion
    }
}
