using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCMadeireira.Model
{
    /// <summary>
    /// Classe para validação dos documentos para registro no DB
    /// </summary>
    class ValidarCpfCnpj
    {
        /// <summary>
        /// Método para validação de CPF
        /// <para>O método possui verificação em 3 etapas</para>
        /// <para>1) Checa se a string fornecida não está num copnjunto de CPFs errados conhecidos</para>
        /// <para>2) Checagem do 1º digito verificador por cálculo</para>
        /// <para>3) Checagem do 2º digito verificador por cálculo</para>
        /// </summary>
        /// <param name="cpf">Parâmetro de entrada do CPF</param>
        /// <returns></returns>
        public bool ValidarCpf(string cpf)
        {
            try
            {
                //TODO Regular expression comparission
                string[] cpfError = new string[] {
                "000.000.000-00", "111.111.111-11",
                "222.222.222-22", "333.333.333-33",
                "444.444.444-44", "555.555.555-55",
                "666.666.666-66", "777.777.777-77",
                "888.888.888-88", "999.999.999-99"
            };

                if (!cpfError.Contains(cpf))
                {
                    int PA = 10;
                    int calc = 0;
                    for (int i = 0; i <= 10; i++)
                    {
                        if (cpf[i].ToString() != "." && cpf[i].ToString() != "-")
                        {
                            calc = calc + (int.Parse(cpf[i].ToString()) * PA);
                            PA--;
                        }
                    }
                    calc = (calc * 10) % 11;
                    if (calc == int.Parse(cpf[12].ToString()))
                    {
                        PA = 11;
                        calc = 0;
                        for (int i = 0; i <= 12; i++)
                        {
                            if (cpf[i].ToString() != "." && cpf[i].ToString() != "-")
                            {
                                calc = calc + (int.Parse(cpf[i].ToString()) * PA);
                                PA--;
                            }
                        }
                        calc = (calc * 10) % 11;
                        if (calc == int.Parse(cpf[13].ToString()))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Método para validação de CNPJ
        /// <para>Possui verificação em 3 etapas</para>
        /// <para>1) Checa se a string fornecida não está num conjunto de CPFs errados conhecidos</para>
        /// <para>2) Checagem do 1º digito verificador por cálculo</para>
        /// <para>3) Checagem do 2º digito verificador por cálculo</para>
        /// </summary>
        /// <param name="cnpj">Parâmetro de entrada do CNPJ</param>
        /// <returns></returns>
        public bool ValidarCnpj(string cnpj)
        {
            try
            {
                //TODO Regular expression comparission
                string[] cnpjError = new string[] {
                    "00.000.000/0000-00", "11.111.111/1111-11",
                    "22.222.222/2222-22", "33.333.333/3333-33",
                    "44.444.444/4444-44", "55.555.555/5555-55",
                    "66.666.666/6666-66", "77.777.777/7777-77",
                    "88.888.888/8888-88", "99.999.999/9999-99"
                };
                List<int> dgVer = new List<int> { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                string[] dgError = new string[] { ".", "/", "-", "," };
                if (!cnpjError.Contains(cnpj))
                {
                    int calc = 0;
                    for (int i = 0; i <= cnpj.Length - 3; i++)
                    {
                        if (!dgError.Contains(cnpj[i].ToString()))
                        {
                            calc = calc + (Convert.ToInt32(cnpj[i].ToString()) * dgVer[0]);
                            dgVer.RemoveAt(0);
                        }
                    }
                    calc %= 11;
                    if (calc >= 2)
                    {
                        calc = 11 - calc;
                    }
                    else
                    {
                        calc = 0;
                    }
                    if (calc == Convert.ToInt32(cnpj[cnpj.Length - 2].ToString()))
                    {
                        dgVer = new List<int> { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                        calc = 0;
                        for (int i = 0; i <= cnpj.Length - 2; i++)
                        {
                            if (!dgError.Contains(cnpj[i].ToString()))
                            {
                                calc = calc + (Convert.ToInt32(cnpj[i].ToString()) * dgVer[0]);
                                dgVer.RemoveAt(0);
                            }
                        }
                        calc %= 11;
                        if (calc >= 2)
                        {
                            calc = 11 - calc;
                        }
                        else
                        {
                            calc = 0;
                        }
                        if (calc == Convert.ToInt32(cnpj[cnpj.Length - 1].ToString()))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}