namespace UC9_Senai_EncodingBackEnd_SA2.Extensions
{
    public static class Extension
    {
        // Método de extensão para customizar o WriteLine
        public static void WriteLine(this string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        // Método de extensão para customizar o Write
        public static void Write(this string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }

     }
  }

