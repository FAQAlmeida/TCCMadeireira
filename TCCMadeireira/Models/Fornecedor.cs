using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCCMadeireira.Model;

namespace TCCMadeireira.Models
{
    class Fornecedor
    {
        private int id;
        private string nome, identidade, cep, rua, numero, bairro, cidade, estado, telefone, celular, email, obs;
        private DateTime dataInfo;
        private ValidarCpfCnpj cpfCnpj = new ValidarCpfCnpj();

        public int Id { get { return id; } set { id = value; }  }
        public string Nome { get { return nome; } set { nome = value.ToUpper().Trim(); } }
        public string Identidade { get { return identidade; } set { identidade = value.ToUpper().Trim(); } }
        public string Cep { get { return cep; } set { cep = value.ToUpper().Trim(); } }
        public string Rua { get { return rua; } set { rua = value.ToUpper().Trim(); } }
        public string Numero { get { return numero; } set { numero = value.ToUpper().Trim(); } }
        public string Bairro { get { return bairro; } set { bairro = value.ToUpper().Trim(); } }
        public string Cidade { get { return cidade; } set { cidade = value.ToUpper().Trim(); } }
        public string Estado { get { return estado; } set { estado = value.ToUpper().Trim(); } }
        public string Telefone { get { return telefone; } set { telefone = value.ToUpper().Trim(); } }
        public string Celular { get { return celular; } set { celular = value.ToUpper().Trim(); } }
        public string Email { get { return email; } set { email = value.ToUpper().Trim(); } }
        public string Obs { get { return obs; } set { obs = value.ToUpper().Trim(); } }
        public DateTime DataInfo { get { return dataInfo; } set { dataInfo = value; }}

        public Fornecedor(int id, string nome, string identidade, string cep, string rua, string numero, string bairro, string cidade, string estado, string telefone, string celular, string email, string obs, DateTime dataInfo)
        {
            if(cpfCnpj.ValidarCpf(identidade) || cpfCnpj.ValidarCnpj(identidade))
            {
                this.id = id;
                this.nome = nome.ToUpper().Trim();
                this.identidade = identidade.ToUpper().Trim();
                this.cep = cep.ToUpper().Trim();
                this.rua = rua.ToUpper().Trim();
                this.numero = numero.ToUpper().Trim();
                this.bairro = bairro.ToUpper().Trim();
                this.cidade = cidade.ToUpper().Trim();
                this.estado = estado.ToUpper().Trim();
                this.telefone = telefone.ToUpper().Trim();
                this.celular = celular.ToUpper().Trim();
                this.email = email.ToUpper().Trim();
                this.obs = obs.ToUpper().Trim();
                this.dataInfo = dataInfo;
            }
            else
            {
                throw new Exception("CPF ou CNPJ inválido");
            }            
        }
        public Fornecedor(string nome, string identidade, string cep, string rua, string numero, string bairro, string cidade, string estado, string telefone, string celular, string email, string obs, DateTime dataInfo)
        {
            if (cpfCnpj.ValidarCpf(identidade) || cpfCnpj.ValidarCnpj(identidade))
            {
                this.nome = nome.ToUpper().Trim();
                this.identidade = identidade.ToUpper().Trim();
                this.cep = cep.ToUpper().Trim();
                this.rua = rua.ToUpper().Trim();
                this.numero = numero.ToUpper().Trim();
                this.bairro = bairro.ToUpper().Trim();
                this.cidade = cidade.ToUpper().Trim();
                this.estado = estado.ToUpper().Trim();
                this.telefone = telefone.ToUpper().Trim();
                this.celular = celular.ToUpper().Trim();
                this.email = email.ToUpper().Trim();
                this.obs = obs.ToUpper().Trim();
                this.dataInfo = dataInfo;
            }
            else
            {
                throw new Exception("CPF ou CNPJ inválido");
            }
        }
        public Fornecedor(string identidade)
        {
            if(cpfCnpj.ValidarCnpj(identidade) || cpfCnpj.ValidarCpf(identidade))
            {
                this.Identidade = identidade;
            }
            else
            {
                throw new Exception("CPF ou CNPJ inválido");
            }
        }
    }
}
