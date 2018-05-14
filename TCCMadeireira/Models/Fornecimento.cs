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

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        internal Fornecedor Fornecedor { get => fornecedor; set => fornecedor = value; }
        internal Produto[] Produtos { get => produtos; set => produtos = value; }
        public DateTime DataInfo { get => dataInfo; set => dataInfo = value; }

        public Fornecimento(int id, string nome, Fornecedor fornecedor, Produto[] produtos, DateTime dataInfo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Fornecedor = fornecedor;
            this.Produtos = produtos;
            this.DataInfo = dataInfo;
        }
        public Fornecimento(string nome, Fornecedor fornecedor, Produto[] produtos, DateTime dataInfo)
        {
            this.Nome = nome;
            this.Fornecedor = fornecedor;
            this.Produtos = produtos;
            this.DataInfo = dataInfo;
        }
    }
}
