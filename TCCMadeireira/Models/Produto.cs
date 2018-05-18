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
        private decimal quantidade;
        private string obs;
        private DateTime dataInfo;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        internal Fornecedor Fornecedor { get => fornecedor; set => fornecedor = value; }
        public int Valor { get => valor; set => valor = value; }
        public decimal Quantidade { get => quantidade; set => quantidade = value; }
        public DateTime DataInfo { get => dataInfo; set => dataInfo = value; }
        public string Obs { get => obs; set => obs = value; }

        public Produto(int id, string nome, Fornecedor fornecedor, int valor, decimal quantidade, DateTime dataInfo, string obs) {
            this.Id = id;
            this.Nome = nome.ToUpper().Trim();
            this.Fornecedor = fornecedor;
            this.obs = obs;
            this.Valor =  valor;
            this.Quantidade = quantidade;
            this.DataInfo = dataInfo;
        }
        public Produto(string nome, Fornecedor fornecedor, int valor, decimal quantidade, DateTime dataInfo, string obs)
        {
            this.Nome = nome.ToUpper().Trim();
            this.obs = obs;
            this.Fornecedor = fornecedor;
            this.Valor = valor;
            this.Quantidade = quantidade;
            this.DataInfo = dataInfo;
        }

    }
}
