using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCMadeireira.Models
{
    class Fornecimento
    {
        private int id;
        private Fornecedor fornecedor;
        private List<ProdVenda> produtos;
        private Usuario usuario;
        private DateTime dataInfo;
        private decimal valor;
        private string obs;

        public int Id { get => id; set => id = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public DateTime DataInfo { get => dataInfo; set => dataInfo = value; }
        internal Fornecedor Fornecedor { get => fornecedor; set => fornecedor = value; }
        internal List<ProdVenda> Produtos { get => produtos; set => produtos = value; }
        public string Obs { get => obs; set => obs = value; }
        internal Usuario Usuario { get => usuario; set => usuario = value; }

        public Fornecimento(int id, Fornecedor fornecedor, List<ProdVenda> produtos, DateTime dataInfo, decimal valor, string obs)
        {
            this.Id = id;
            this.Fornecedor = fornecedor;
            this.Produtos = produtos;
            this.DataInfo = dataInfo;
            this.Valor = valor;
            this.Obs = obs;
        }
        public Fornecimento(Fornecedor fornecedor, List<ProdVenda> produtos, Usuario usuario, DateTime dataInfo, decimal valor, string obs)
        {
            this.Fornecedor = fornecedor;
            this.Produtos = produtos;
            Usuario = usuario;
            this.DataInfo = dataInfo;
            this.Valor = valor;
            this.Obs = obs;
        }
        public Fornecimento(Fornecedor fornecedor, List<ProdVenda> produtos, Usuario usuario, DateTime dataInfo, decimal valor)
        {
            this.Fornecedor = fornecedor;
            this.Produtos = produtos;
            Usuario = usuario;
            this.DataInfo = dataInfo;
            this.Valor = valor;
            Obs = "";
        }
    }
}
