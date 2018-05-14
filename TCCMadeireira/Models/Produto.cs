using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCMadeireira.Models
{
    class Produto
    {
        private int id;
        private string nome;
        private Fornecedor fornecedor;
        private int valor;
        private int quantidade;
        private DateTime dataInfo;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        internal Fornecedor Fornecedor { get => fornecedor; set => fornecedor = value; }
        public int Valor { get => valor; set => valor = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public DateTime DataInfo { get => dataInfo; set => dataInfo = value; }

        public Produto(int id, string nome, Fornecedor fornecedor, int valor, int quantidade, DateTime dataInfo) {
            this.Id = id;
            this.Nome = nome.ToUpper().Trim();
            this.Fornecedor = fornecedor;
            this.Valor =  valor;
            this.Quantidade = quantidade;
            this.DataInfo = dataInfo;
        }
        public Produto(string nome, Fornecedor fornecedor, int valor, int quantidade, DateTime dataInfo)
        {
            this.Nome = nome.ToUpper().Trim();
            this.Fornecedor = fornecedor;
            this.Valor = valor;
            this.Quantidade = quantidade;
            this.DataInfo = dataInfo;
        }

    }
}
