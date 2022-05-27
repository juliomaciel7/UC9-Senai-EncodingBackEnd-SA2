using UC9_Senai_EncodingBackEnd_SA2.Interfaces;

namespace UC9_Senai_EncodingBackEnd_SA2.Classes
{
    public class Endereco 
    {
        public string NomeRua { get; set; }
        public int NumeroCasa { get; set; }
        public string Complemento { get; set; }
        public bool Comercial { get; set; }
    }
}