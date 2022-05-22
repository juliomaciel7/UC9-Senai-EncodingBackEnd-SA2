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
    }
}
