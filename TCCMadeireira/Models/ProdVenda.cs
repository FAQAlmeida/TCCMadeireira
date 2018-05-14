using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCMadeireira.Models
{
    class ProdVenda
    {
        private Produto produto;
        private int quantidade;

        public ProdVenda(Produto produto, int quantidade)
        {
            this.Produto = produto;
            this.Quantidade = quantidade;
        }

        public int Quantidade { get => quantidade; set => quantidade = value; }
        internal Produto Produto { get => produto; set => produto = value; }
    }
}
