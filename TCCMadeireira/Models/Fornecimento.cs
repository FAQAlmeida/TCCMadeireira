using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCMadeireira.Models
{
    class Fornecimento
    {
        int id;
        string nome;
        Fornecedor fornecedor;
        Produto[] produtos;
        DateTime dataInfo;

        public Fornecimento(int id, string nome, Fornecedor fornecedor, Produto[] produtos, DateTime dataInfo)
        {
            this.id = id;
            this.nome = nome;
            this.fornecedor = fornecedor;
            this.produtos = produtos;
            this.dataInfo = dataInfo;
        }
        public Fornecimento(string nome, Fornecedor fornecedor, Produto[] produtos, DateTime dataInfo)
        {
            this.nome = nome;
            this.fornecedor = fornecedor;
            this.produtos = produtos;
            this.dataInfo = dataInfo;
        }
    }
}
