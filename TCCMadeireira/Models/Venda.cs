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
        int id;
        Cliente cliente;
        Produto [] produto;
        DateTime dataInfo;
        decimal valor;

        public Venda(int id, Cliente cliente, Produto[] produto, DateTime dataInfo, decimal valor)
        {
            this.id = id;
            this.cliente = cliente;
            this.produto = produto;
            this.dataInfo = dataInfo;
            this.valor = valor;
        }

        public Venda(Cliente cliente, Produto[] produto, DateTime dataInfo, decimal valor)
        {
            this.cliente = cliente;
            this.produto = produto;
            this.dataInfo = dataInfo;
            this.valor = valor;
        }
    }
}
