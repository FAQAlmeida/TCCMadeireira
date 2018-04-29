using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCMadeireira.Model
{
    class Cliente
    {
        string id, nome, identidade, cep, rua, numero, bairro, cidade, estado, telefone, celular, email, obs;
        DateTime dataInfo;
        ValidarCpfCnpj cpfCnpj = new ValidarCpfCnpj();

        public Cliente(string nome, string identidade, string cep, string rua, string numero, string bairro, string cidade, string estado, string telefone, string celular, string email, DateTime dataInfo, string obs)
        {
            if (cpfCnpj.ValidarCpf(identidade) || cpfCnpj.ValidarCnpj(identidade))
            {
                this.nome = nome.ToUpper().Trim();
                this.identidade = identidade.Trim();
                this.cep = cep.Trim();
                this.rua = rua.ToUpper().Trim();
                this.numero = numero.Trim();
                this.bairro = bairro.ToUpper().Trim();
                this.cidade = cidade.ToUpper().Trim();
                this.estado = estado.ToUpper().Trim();
                this.telefone = telefone.Trim();
                this.celular = celular.Trim();
                this.email = email.ToUpper().Trim();
                this.dataInfo = dataInfo;
                this.obs = obs.ToUpper().Trim();
            }
            else
            {
                throw new Exception("CPF ou CNPJ inválido");
            }
        }
        public Cliente(string identidade)
        {
            if (cpfCnpj.ValidarCpf(identidade))
            {
                this.identidade = identidade.Trim();
            }
            else
            {
                throw new Exception("CPF ou CNPJ inválido");
            }
        }

        public string Id { get => id; set => id = value; }
        public string Nome { get => nome.ToUpper(); set => nome = value; }
        public string Identidade { get => identidade; set => identidade = value; }
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
