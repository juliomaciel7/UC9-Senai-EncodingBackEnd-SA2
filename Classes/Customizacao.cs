using UC9_Senai_EncodingBackEnd_SA2.Extensions;

namespace UC9_Senai_EncodingBackEnd_SA2.Classes
{
    public class Customizacao
    {
        public void BarraCarregamento(string text, int time)
        {
            text.Write(ConsoleColor.Yellow);
            // loop para escrever os pontinhos
            for (int i = 0; i < 3; i++)
            {
                Console.Write(". ");
                Thread.Sleep(time);
            }
        }
    }
}
