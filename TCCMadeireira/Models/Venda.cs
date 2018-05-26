using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCCMadeireira.Model;

namespace TCCMadeireira.Models
{
    class Venda
    {
        private int id;
        private Cliente cliente;
        private Usuario usuario;
        private List<ProdVenda> produtos;
        private DateTime dataInfo;
        private decimal valor;

        public int Id { get => id; set => id = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        internal List<ProdVenda> Produtos { get => produtos; set => produtos = value; }
        public DateTime DataInfo { get => dataInfo; set => dataInfo = value; }
        public decimal Valor { get => valor; set => valor = value; }
        internal Usuario Usuario { get => usuario; set => usuario = value; }

        public Venda(int id, Cliente cliente, Usuario usuario, List<ProdVenda> produto, DateTime dataInfo, decimal valor)
        {
            this.Id = id;
            this.Usuario = usuario;
            this.Cliente = cliente;
            this.Produtos = produto;
            this.DataInfo = dataInfo;
            this.Valor = valor;
        }

        public Venda(Cliente cliente, List<ProdVenda> produto, Usuario usuario, DateTime dataInfo, decimal valor)
        {
            this.Cliente = cliente;
            this.Usuario = usuario;
            this.Produtos = produto;
            this.DataInfo = dataInfo;
            this.Valor = valor;
        }

    }
}
