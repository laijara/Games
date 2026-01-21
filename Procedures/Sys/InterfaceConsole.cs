namespace Games.Procedures.Sys
{
    public class InterfaceConsole
    {
        public void ConsoleEnd()
        {
            Console.WriteLine("\nНажмите любую кнопку для продолжения...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}