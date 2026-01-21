namespace Games.Procedures
{
    public class Start
    {
        public int StartProgram()
        {
            Procedures.Sys.InterfaceConsole interfaceConsole = new Procedures.Sys.InterfaceConsole();
            Procedures.Games.TagGameClass tagGameClass = new Procedures.Games.TagGameClass();

            int i = -1;
            while (true)
            {
                try
                {
                    Console.WriteLine("Выберите программу: ");
                    Console.WriteLine("0 - Выход");
                    Console.WriteLine("1 - Пятнашки");

                    Console.Write("\nВводите - ");
                    i = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка ввода! Введено не число!");
                    interfaceConsole.ConsoleEnd();
                    continue;
                }
                catch (StackOverflowException)
                {
                    Console.WriteLine("Ошибка ввода! Введено слишком маленькое или слишком большое число!");
                    interfaceConsole.ConsoleEnd();
                    continue;
                }
                catch (Exception)
                {
                    Console.WriteLine("Неизвестная ошибка!");
                    interfaceConsole.ConsoleEnd();
                    continue;
                }

                switch (i)
                {
                    case 0:
                        Console.Clear();
                        interfaceConsole.ConsoleEnd();
                        return 0;

                    case 1:
                        Console.Clear();
                        tagGameClass.TagGameMain();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Нет такой операции");
                        interfaceConsole.ConsoleEnd();
                        break;
                }
            }
        }
    }
}