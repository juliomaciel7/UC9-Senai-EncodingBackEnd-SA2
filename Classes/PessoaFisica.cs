using System.Text.RegularExpressions;
using UC9_Senai_EncodingBackEnd_SA2.Extensions;
using UC9_Senai_EncodingBackEnd_SA2.Interfaces;

namespace UC9_Senai_EncodingBackEnd_SA2.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string CPF { get; set; }
        public string DataNascimento { get; set; }

        public override decimal PagarImposto(decimal remuneracao)
        {
            return 0m;
        }

        public bool ValidarCpf(string cpf)
        {
         
                if (Regex.IsMatch(cpf, @"(^(\d{3}\.\d{3}\.\d{3}\-\d{2})|(\d{14})$)") || Regex.IsMatch(cpf, @"(^(\d{3}\d{3}\d{3}\-\d{2})|(\d{12})$)") || Regex.IsMatch(cpf, @"(^(\d{3}\d{3}\d{3}\d{2})|(\d{11})$)"))
            {
                return true;
            }
            else
            {
                "\nCPF inválido. Digite seu cpf novamente: NNN.NNN.NNN-NN".WriteLine(ConsoleColor.DarkRed);
            }
           
       
            return false;
        }

        // Método validar data de nascimento com parâmentro string
        public bool ValidarDataNascimento(string nascimento)
        {
            // Variável para receber a data convertida
            DateTime dataConvertida;


            // Condicional para encontrar correspondências
            if (Regex.IsMatch(nascimento, @"(^(\d{2}\/\d{2}\/\d{4})|(\d{10}))") || Regex.IsMatch(nascimento, @"(^(\d{2}\-\d{2}\-\d{4})|(\d{10}))") || Regex.IsMatch(nascimento, @"(^(\d{2}\d{2}\d{4})|(\d{8}))"))
            {
                if (DateTime.TryParse(nascimento, out dataConvertida))
                {
                    DateTime dataAtual = DateTime.Today;
                    int idade = (int)((dataAtual - dataConvertida).TotalDays / 365);

                    // Condicional para conferir se é de maior
                    if (idade >= 18)
                    {
                        return true;
                    }
                    else
                    {
                        "\nO cadastro é permitido para maiores de idade. Obrigado pela compreensão!".WriteLine(ConsoleColor.DarkRed);
                    }
                  

                }
                
                Console.WriteLine($"Data de nascimento: {string.Join("/", nascimento)}");
                return true;
                
            }
            else
            {
                "\nData de nascimento inválida. Digite novamente em formato DD/NN/AAAA".WriteLine(ConsoleColor.DarkRed);
            }

            return false;
        }


        // Sobrecarga do método ValidarDataNascimento com parâmetro do tipo string
        public bool ValidarDataNascimento(DateTime nascimento)
        {
            DateTime dataAtual = DateTime.Today;
            int idade = (int)((dataAtual - nascimento).TotalDays / 365);
            // Condicional para conferir se é de maior
            try
            {
                if (idade >= 18)
                    return true;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                throw new ArgumentOutOfRangeException(nameof(idade), "\nO cadastro é permitido para pessoas com idade igual ou maior de 18 anos. Obrigado pela compreensão");
            }

            return false;
        } // Método validar data de nascimento com parâmentro DateTime
    }
}