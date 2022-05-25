using UC9_Senai_EncodingBackEnd_SA2.Interfaces;

namespace UC9_Senai_EncodingBackEnd_SA2.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public Endereco Endereco { get; set; }
        public decimal Remuneracao { get; set; }

        public abstract decimal PagarImposto(decimal remuneracao);

        public void VerificarEcriarPastaArquivo(string caminhoArquivo)
        {
            string pasta = caminhoArquivo.Split("/")[0];
            string arquivo = caminhoArquivo.Split("/")[1];
            // Verificar se a pasta existe. O objetivo é criar a pasta
            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);

            if (File.Exists(arquivo))
            {
                using (File.Create(arquivo)) { }
            }
                
        }
    }
}
