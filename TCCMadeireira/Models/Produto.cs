using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCMadeireira.Models
{
    class Produto
    {
        int id;
        string nome;
        Fornecedor fornecedor;
        int valor;
        int quantidade;
        DateTime dataInfo;
        
        public Produto(int id, string nome, Fornecedor fornecedor, int valor, int quantidade, DateTime dataInfo) {
            this.id = id;
            this.nome = nome.ToUpper().Trim();
            this.fornecedor = fornecedor;
            this.valor =  valor;
            this.quantidade = quantidade;
            this.dataInfo = dataInfo;
        }
        public Produto(string nome, Fornecedor fornecedor, int valor, int quantidade, DateTime dataInfo)
        {
            this.nome = nome.ToUpper().Trim();
            this.fornecedor = fornecedor;
            this.valor = valor;
            this.quantidade = quantidade;
            this.dataInfo = dataInfo;
        }

    }
}
