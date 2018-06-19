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
        private List<ProdOper> produtos;
        private DateTime dataInfo;
        private decimal valor;
        private string endEntrega;

        public int Id { get => id; set => id = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        internal List<ProdOper> Produtos { get => produtos; set => produtos = value; }
        public DateTime DataInfo { get => dataInfo; set => dataInfo = value; }
        public decimal Valor { get => valor; set => valor = value; }
        internal Usuario Usuario { get => usuario; set => usuario = value; }

        public Venda(int id, Cliente cliente, Usuario usuario, List<ProdOper> produto, DateTime dataInfo, decimal valor)
        {
            this.Id = id;
            this.Usuario = usuario;
            this.Cliente = cliente;
            this.Produtos = produto;
            this.DataInfo = dataInfo;
            this.Valor = valor;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            EndEntrega = endEntrega.Trim();
=======
>>>>>>> parent of 1497c66... .
=======
>>>>>>> parent of 1497c66... .
=======
>>>>>>> parent of 1497c66... .
        }

        public Venda(Cliente cliente, List<ProdOper> produto, Usuario usuario, DateTime dataInfo, decimal valor)
        {
            this.Cliente = cliente;
            this.Usuario = usuario;
            this.Produtos = produto;
            this.DataInfo = dataInfo;
            this.Valor = valor;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            EndEntrega = endEntrega.Trim();
=======
>>>>>>> parent of 1497c66... .
=======
>>>>>>> parent of 1497c66... .
=======
>>>>>>> parent of 1497c66... .
        }

        public override string ToString()
        {
            StringBuilder @string = new StringBuilder();
            foreach(ProdOper prod in Produtos)
            {
                @string.AppendFormat("\t{0}\t{1}\n", prod.Produto.Nome, prod.Quantidade);
            }
            return String.Format(
                "Venda: {0}\n" +
                "Cliente: {1}\n" +
                "Produtos: \n{2}\n" +
                "Data: {3}\n" +
                "Vendedor: {4}\n" +
                "Valor: R${5}", Id, Cliente.Nome, @string, DataInfo, Usuario.Nome, Valor);
        }
    }
}
