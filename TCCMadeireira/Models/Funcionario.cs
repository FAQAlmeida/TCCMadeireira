using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCCMadeireira.Model;

namespace TCCMadeireira.Models
{
    class Funcionario
    {
        string id, nome, identidade, cargo, cep, rua, numero, bairro, cidade, estado, telefone, celular, email, obs;
        DateTime dataInfo;
        ValidarCpfCnpj cpfCnpj = new ValidarCpfCnpj();

        public Funcionario(string nome, string identidade, string cargo, string cep, string rua, string numero, string bairro, string cidade, string estado, string telefone, string celular, string email, DateTime dataInfo, string obs)
        {
            if (cpfCnpj.ValidarCpf(identidade.Trim()) || cpfCnpj.ValidarCnpj(identidade.Trim()))
            {
                this.nome = nome.ToUpper().Trim();
                this.identidade = identidade.Trim();
                this.cargo = cargo.ToUpper().Trim();
                this.cep = cep.Trim();
                this.rua = rua.ToUpper().Trim();
                this.numero = numero.Trim();
                this.bairro = bairro.ToUpper().Trim();
                this.cidade = cidade.ToUpper().Trim();
                this.estado = estado.ToUpper().Trim();
                this.telefone = telefone.Trim();
                this.celular = celular.Trim();
                this.email = email.ToUpper().Trim();
                this.DataInfo = dataInfo;
                this.obs = obs.ToUpper().Trim();
            }
            else
            {
                throw new Exception("CPF ou CNPJ inválido");
            }
        }
        public Funcionario(string identidade)
        {
            if(cpfCnpj.ValidarCnpj(identidade.Trim()) || cpfCnpj.ValidarCpf(identidade.Trim()))
            {
                this.identidade = identidade.Trim();
            }
            else
            {
                throw new Exception("CPF ou CNPJ invádo");
            }
        }

        public string Id { get => id; set => id = value; }
        public string Nome { get => nome.ToUpper(); set => nome = value; }
        public string Identidade { get => identidade; set => identidade = value; }
        public string Cargo { get => cargo; set => Cargo = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Rua { get => rua.ToUpper(); set => rua = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro.ToUpper(); set => bairro = value; }
        public string Cidade { get => cidade.ToUpper(); set => cidade = value; }
        public string Estado { get => estado.ToUpper(); set => estado = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Email { get => email.ToUpper(); set => email = value; }
        public string Obs { get => obs; set => obs = value; }
        public DateTime DataInfo { get => dataInfo; set => dataInfo = value; }
    }
}
