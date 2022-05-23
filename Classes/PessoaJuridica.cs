using System.Text.RegularExpressions;
using UC9_Senai_EncodingBackEnd_SA2.Extensions;
using UC9_Senai_EncodingBackEnd_SA2.Interfaces;

namespace UC9_Senai_EncodingBackEnd_SA2.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }

        public override decimal PagarImposto(decimal remuneracao)
        {
            if (remuneracao <= 1500)
            {
                return remuneracao * 0.03m; // Retorna 3%
            }
            else if (remuneracao <= 3500)
            {
                return remuneracao * 0.05m; // Retorna 5%
            }
            else if (remuneracao <= 6000)
            {
                return remuneracao * 0.07m; // Retorna 7%
            }
            else
            {
                return remuneracao * 0.09m; // Retorna 9%
            }
        }

        

        // Análise correpondências e conferi o número total de caracteres
        public bool ValidarCnpj(string cnpj)
        {
            if (Regex.IsMatch(cnpj, @"(^(\d2)\.\d{3}\.\d{3}\/\d{4}\-\d{2})|(\d{18})$") || Regex.IsMatch(cnpj, @"(^(\d2)\d{3}\d{3}\/\d{4}\d{2})|(\d{16})$") || Regex.IsMatch(cnpj, @"(^(\d2)\d{3}\d{3}\d{4}\d{2})|(\d{14})$"))
            {
                if (cnpj.Length == 18)
                {
                    if (cnpj.Substring(11, 4) == "0001")
                    {
                        return true;
                    }
                }
                else if (cnpj.Length == 16)
                {
                    if (cnpj.Substring(9, 4) == "0001")
                    {
                        return true;
                    }
                }
                else if (cnpj.Length == 14)
                {
                    if (cnpj.Substring(8, 4) == "0001")
                    {
                        return true;
                    }
                }
                return true;
            }
            else
            {
                "Digite seu CNPJ corretamente. Padrão: NN.NNN.NNN/NNNN-NN".WriteLine(ConsoleColor.DarkRed);
            }
            return false;
        }
    }
}
