using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCMadeireira.Models
{
    class Usuario
    {
        private int id;
        private string nome;
        private string senha;
        private string nivel;
        private DateTime dataInfo;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Nivel { get => nivel; set => nivel = value; }
        public DateTime DataInfo { get => dataInfo; set => dataInfo = value; }

        public Usuario(int id, string nome, string senha, string nivel, DateTime dataInfo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Senha = senha;
            this.Nivel = nivel;
            this.DataInfo = dataInfo;
        }
        public Usuario(int id, string nome, string nivel, DateTime dataInfo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Nivel = nivel;
            this.DataInfo = dataInfo;
        }
        public Usuario(int id, string nome, string nivel)
        {
            this.Id = id;
            this.Nome = nome;
            this.Nivel = nivel;
        }

        public Usuario(string nome, string senha, string nivel, DateTime dataInfo)
        {
            this.Nome = nome;
            this.Senha = senha;
            this.Nivel = nivel;
            this.DataInfo = dataInfo;
        }
    }
}
