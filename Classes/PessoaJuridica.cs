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
        public string caminhoArquivo { get; private set; } = "Database/PessoaJuridica.csv";

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


        // ******* Método para inserir os dados no arquivo, fazendo menção a um banco de dados. ********** //
        public void Inserir(PessoaJuridica pj)
        {
            VerificarEcriarPastaArquivo(caminhoArquivo);
            string[] pjString = {$"{pj.Nome}, {pj.CNPJ}, {pj.NomeFantasia}" };
            File.AppendAllLines(caminhoArquivo, pjString);
        }
        // ******* Método para inserir os dados no arquivo, fazendo menção a um banco de dados. ********** //


        // ******* Método para ler os dados cadastrados pelo usuário ********** //
        public List<PessoaJuridica> Ler()
        {
            List<PessoaJuridica> listaPJ = new List<PessoaJuridica>();

            string[] linhas = File.ReadAllLines(caminhoArquivo);

            foreach  (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaJuridica cadaPJ = new PessoaJuridica();

                cadaPJ.Nome = atributos[0];
                cadaPJ.CNPJ = atributos[1];
                cadaPJ.NomeFantasia = atributos[2];

                listaPJ.Add(cadaPJ);
            }

            return listaPJ;
        }
        // ******* Método para ler os dados cadastrados pelo usuário ********** //
    }
}
