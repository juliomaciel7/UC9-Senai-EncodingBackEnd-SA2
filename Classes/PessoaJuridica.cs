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
            throw new NotImplementedException();
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}
