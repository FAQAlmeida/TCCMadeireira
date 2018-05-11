using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCMadeireira.Models
{
    class Usuario
    {
        int id;
        string nome;
        string senha;
        string nivel;
        DateTime dataInfo;

        public Usuario(int id, string nome, string senha, string nivel, DateTime dataInfo)
        {
            this.id = id;
            this.nome = nome;
            this.senha = senha;
            this.nivel = nivel;
            this.dataInfo = dataInfo;
        }

        public Usuario(string nome, string senha, string nivel, DateTime dataInfo)
        {
            this.nome = nome;
            this.senha = senha;
            this.nivel = nivel;
            this.dataInfo = dataInfo;
        }
    }
}
