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
        private string nome;
        private Fornecedor fornecedor;
        private Produto[] produtos;
        private DateTime dataInfo;
        private decimal valor;
        private string obs;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public DateTime DataInfo { get => dataInfo; set => dataInfo = value; }
        internal Fornecedor Fornecedor { get => fornecedor; set => fornecedor = value; }
        internal Produto[] Produtos { get => produtos; set => produtos = value; }
        public string Obs { get => obs; set => obs = value; }
        

        public Fornecimento(int id, string nome, Fornecedor fornecedor, Produto[] produtos, DateTime dataInfo, decimal valor, string obs)
        {
            this.Id = id;
            this.Nome = nome;
            this.Fornecedor = fornecedor;
            this.Produtos = produtos;
            this.DataInfo = dataInfo;
            this.Valor = valor;
            this.Obs = obs;
        }
        public Fornecimento(string nome, Fornecedor fornecedor, Produto[] produtos, DateTime dataInfo, decimal valor, string obs)
        {
            this.Nome = nome;
            this.Fornecedor = fornecedor;
            this.Produtos = produtos;
            this.DataInfo = dataInfo;
            this.Valor = valor;
            this.Obs = obs;
        }
    }
}
