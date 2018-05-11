using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCMadeireira.Models
{
    class ProdVenda
    {
        Produto produto;
        int quantidade;

        public ProdVenda(Produto produto, int quantidade)
        {
            this.produto = produto;
            this.quantidade = quantidade;
        }
    }
}
