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
                    interfaceConsole.ClearAndText("Ошибка ввода! Введено не число!\n");
                    continue;
                }
                catch (StackOverflowException)
                {
                    interfaceConsole.ClearAndText("Ошибка ввода! Введено слишком маленькое или слишком большое число!\n");
                    continue;
                }
                catch (Exception)
                {
                    interfaceConsole.ClearAndText("Ошибка ввода! Введено слишком маленькое или слишком большое число!\n");
                    continue;
                }

                switch (i)
                {
                    case 0:
                        Console.Clear();
                        return 0;

                    case 1:
                        Console.Clear();
                        tagGameClass.TagGameMain();
                        break;

                    default:
                        interfaceConsole.ClearAndText("Нет такой операции!\n");
                        break;
                }
            }
        }
    }
}