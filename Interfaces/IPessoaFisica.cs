namespace UC9_Senai_EncodingBackEnd_SA2.Interfaces
{
    public interface IPessoaFisica
    {
        bool ValidarCpf(string cpf);
        bool ValidarDataNascimento(DateTime nascimento);
    }
}
