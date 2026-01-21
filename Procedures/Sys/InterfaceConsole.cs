namespace Games.Procedures.Sys
{
    public class InterfaceConsole
    {
        public void ConsolePause()
        {
            Console.WriteLine("\nНажмите любую кнопку для продолжения...");
            Console.ReadKey();
            Console.Clear();
        }

        public void ConsolePauseFirstLine()
        {
            Console.WriteLine("Нажмите любую кнопку для продолжения...");
            Console.ReadKey();
            Console.Clear();
        }

        public void ConsolePauseAnyText(string text)
        {
            Console.WriteLine("\n" + text);
            Console.ReadKey();
            Console.Clear();
        }

        public void ConsolePauseAnyTextFirstLine(string text)
        {
            Console.WriteLine(text);
            Console.ReadKey();
            Console.Clear();
        }

        public void ClearAndText(string text)
        {
            Console.Clear();
            Console.WriteLine(text);
        }

        public void TextAndClear(string text)
        {
            Console.WriteLine(text);
            Console.Clear();
        }

        public void ClearAndTextAndClear(string text)
        {
            Console.Clear();
            Console.WriteLine(text);
            Console.Clear();
        }
    }
}