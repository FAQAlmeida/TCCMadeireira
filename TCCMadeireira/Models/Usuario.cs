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
        public string Nome { get => nome; set => nome = value.ToUpper().Trim(); }
        public string Senha { get => senha; set => senha = value.ToUpper().Trim(); }
        public string Nivel { get => nivel; set => nivel = value.ToUpper().Trim(); }
        public DateTime DataInfo { get => dataInfo; set => dataInfo = value; }



        public Usuario(int id, string nome, string senha, string nivel, DateTime dataInfo)
        {
            Id = id;
            Nome = nome;
            Senha = senha;
            Nivel = nivel;
            DataInfo = dataInfo;
        }
        public Usuario(int id, string nome, string nivel, DateTime dataInfo)
        {
            Id = id;
            Nome = nome;
            Nivel = nivel;
            DataInfo = dataInfo;
        }
        public Usuario(int id, string nome, string nivel)
        {
            Id = id;
            Nome = nome;
            Nivel = nivel;
        }
        public Usuario(string nome, string senha)
        {
            Nome = nome;
            Senha = senha;
        }

        public Usuario(string nome, string senha, string nivel, DateTime dataInfo)
        {
            Nome = nome;
            Senha = senha;
            Nivel = nivel;
            DataInfo = dataInfo;
        }

        public override string ToString()
        {
            return String.Format(
                "ID: {0}\n" +
                "LOGIN: {1}\n" +
                "SENHA: {2}\n" +
                "NIVEL: {3}", Id, Nome, Senha, Nivel);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
