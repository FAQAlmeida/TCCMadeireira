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
        private FORNECIMENTO_PRODUTOTableAdapter fornecimentoprodutoTableAdapter = new FORNECIMENTO_PRODUTOTableAdapter();
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
            CLIENTESDataTable clientedt = SelectCliente(cliente.Identidade);
            cliente.Id = Convert.ToInt32(clientedt.Rows[0]["id_cliente"]);
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
        #region Fornecimento
        public FORNECIMENTOSDataTable SelectFornecimento()
        {
            return fornecimentosTableAdapter.GetData();
        }
        public FORNECIMENTOSDataTable SelectFornecimento(int id)
        {
            return fornecimentosTableAdapter.GetDataFornecimeto(id);
        }
        public void InsertFornecimento(Fornecimento fornecimento)
        {
            fornecimento.Id = fornecimentosTableAdapter.Insert(fornecimento.DataInfo, fornecimento.Valor, fornecimento.Fornecedor.Id, fornecimento.Obs);
            InsertMultProdForn(fornecimento);
        }
        public void UpdateFornecimento(Fornecimento fornecimento)
        {
            fornecimentosTableAdapter.Update(fornecimento.DataInfo, fornecimento.Valor, fornecimento.Fornecedor.Id, fornecimento.Obs, fornecimento.Id);
        }
        public void DeleteFornecimento(Fornecimento fornecimento)
        {
            fornecimentosTableAdapter.Delete(fornecimento.Id);
        }
        #endregion
        #region Fornecedor
        public FORNECEDORESDataTable SelectFornecedor()
        {
            return fornecedoresTableAdapter.GetData();
        }
        public FORNECEDORESDataTable SelectFornecedor(int id)
        {
            return fornecedoresTableAdapter.GetDataFornecedor(id);
        }
        public FORNECEDORESDataTable SelectFornecedor(string iden)
        {
            return fornecedoresTableAdapter.GetDataFornecedorIden(iden);
        }
        public void InsertFornecedor (Fornecedor fornecedor)
        {
            fornecedoresTableAdapter.Insert(fornecedor.Nome, fornecedor.Identidade, fornecedor.Cep, 
                fornecedor.Rua, fornecedor.Numero,fornecedor.Bairro, fornecedor.Cidade, fornecedor.Estado, 
                fornecedor.Telefone, fornecedor.Celular, fornecedor.Email, fornecedor.DataInfo, fornecedor.Obs);
        }
        public void UpdateFornecedor(Fornecedor fornecedor)
        {
            fornecedoresTableAdapter.Update(fornecedor.Nome, fornecedor.Identidade, fornecedor.Cep, fornecedor.Rua,
                fornecedor.Numero, fornecedor.Bairro, fornecedor.Cidade, fornecedor.Estado, fornecedor.Telefone,
                fornecedor.Celular, fornecedor.Email, fornecedor.DataInfo, fornecedor.Obs, fornecedor.Id);
        }
        public void DeleteFornecedor(Fornecedor fornecedor)
        {
            fornecedoresTableAdapter.Delete(fornecedor.Id);
        }
        #endregion
        #region Produto
        public PRODUTOSDataTable SelectProduto()
        {
            return produtosTableAdapter.GetData();
        }
        public PRODUTOSDataTable SelectProduto(int id)
        {
            return produtosTableAdapter.GetDataProduto(id);
        }
        public void UpdateProduto(Produto produto)
        {
            produtosTableAdapter.Update(produto.Nome, produto.Quantidade, produto.Valor, produto.Fornecedor.Id, produto.Obs, produto.Id);
        }
        public void InsertProduto(Produto produto)
        {
            produtosTableAdapter.Insert(produto.Nome, produto.Quantidade, produto.Valor, produto.Fornecedor.Id, produto.Obs);
        }
        public void DeleteProduto(Produto produto)
        {
            produtosTableAdapter.Delete(produto.Id);
        }

        #endregion
        #region ProdOper
        #region Venda
        public VENDA_PRODUTODataTable SelectProdutosVenda(Venda venda)
        {
            return vendaprodutoTableAdapter.GetDataVenda(venda.Id);
        }
        public VENDA_PRODUTODataTable SelectProdutoVenda(Produto produto)
        {
            return vendaprodutoTableAdapter.GetDataProdVenda(produto.Id);
        }
        public void InsertProdutoVenda(Venda venda, ProdVenda produto)
        {
            vendaprodutoTableAdapter.Insert(venda.Id, produto.Produto.Id, produto.Quantidade);
        }
        public void InsertMultProdVenda(Venda venda)
        {
            foreach(ProdVenda produto in venda.Produtos)
            {
                InsertProdutoVenda(venda, produto);
            }
        }
        #endregion
        #region Fornecimento
        public FORNECIMENTO_PRODUTODataTable SelectProdutosFornecimento(Fornecimento fornecimento)
        {
            return fornecimentoprodutoTableAdapter.GetDataFornecimento(fornecimento.Id);
        }
        public FORNECIMENTO_PRODUTODataTable SelectProdutosFornecimento(Produto produto)
        {
            return fornecimentoprodutoTableAdapter.GetDataProdFornecimento(produto.Id);
        }
        public void InsertProdutoForn(Fornecimento fornecimento, ProdVenda produto)
        {
            fornecimentoprodutoTableAdapter.Insert(fornecimento.Id, produto.Produto.Id, produto.Quantidade);
        }
        public void InsertMultProdForn(Fornecimento fornecimento)
        {
            foreach (ProdVenda produto in fornecimento.Produtos)
            {
                InsertProdutoForn(fornecimento, produto);
            }
        }
        #endregion
        #endregion
        #region Usuario
        public USERSDataTable SelectUsuario()
        {
            return usersTableAdapter.GetData();
        }
        public USERSDataTable SelectUsuario(int id)
        {
            return usersTableAdapter.GetDataUsuario(id);
        }
        public void InsertUsuario(Usuario usuario)
        {
            usersTableAdapter.Insert(usuario.Nome, usuario.Senha, usuario.Nivel);
        }
        public void UpdateUsuario(Usuario usuario)
        {
            usersTableAdapter.Update(usuario.Nome, usuario.Senha, usuario.Nivel, usuario.Id);
        }
        public void DeleteUSuario(Usuario usuario)
        {
            usersTableAdapter.Delete(usuario.Id);
        }
        #endregion
        #region Venda
        /// <summary>
        /// Overload do metódo "InserirFuncionario" do TableAdapter para suportar o objeto funcionario
        /// </summary>
        /// <param name="venda"> Objeto funcionario, que devera conter todas as informações do funcionario</param>
        public void InsertVenda(Venda venda)
        {
            venda.Id = vendasTableAdapter.Insert(venda.Cliente.Id, venda.Usuario.Id, venda.DataInfo, venda.Valor);
            InsertMultProdVenda(venda);
        }
        /// <summary>
        /// Overload do metódo SelectFuncionario do TableAdapter  
        /// </summary>
        /// <param name="id">Identidade para se pesquisar um funcionario</param>
        /// <returns>DataTable com o funcionario pesquisar</returns>
        public VENDASDataTable SelectVenda(int id)
        {
            return vendasTableAdapter.GetDataVenda(id);
        }
        /// <summary>
        /// Overload do metódo "UpdateFuncionario" do TableAdapter para suportar o objeto funcionario
        /// </summary>
        /// <param name="venda">Objeto funcionario, que devera conter todas as informações do funcionario</param>
        public void UpdateVenda(Venda venda)
        {
            vendasTableAdapter.Update(venda.Cliente.Id, venda.Usuario.Id, venda.DataInfo, venda.Valor, venda.Id);
        }
        public VENDASDataTable SelectVenda()
        {
            return vendasTableAdapter.GetData();
        }
        public void DeleteVenda(Venda venda)
        {
            VENDASDataTable vendadt = SelectVenda(venda.Id);
            funcionariosTableAdapter.Delete(Convert.ToInt32(vendadt[0]["id_venda"]));
        }
        #endregion
    }
}
