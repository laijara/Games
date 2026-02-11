namespace Games.Procedures.Games
{
    public class StoneCutterPaper
    {
        private void StoneCutterPaperSinglePlayer()
        {
            Procedures.Sys.InterfaceConsole interfaceConsole = new Procedures.Sys.InterfaceConsole();

            string inp;
            while (true)
            {
                try
                {
                    Console.WriteLine("Добро пожаловать в камень, ножницы, бумага, выберите режим:");
                    Console.WriteLine("0 - Выход, 1 - Один игрок, 2 - Два игрока");
                    Console.Write("\nВводите: ");
                    inp = Console.ReadLine().ToLower(new System.Globalization.CultureInfo("ru-RU", false));
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
                    interfaceConsole.ClearAndText("Неизвестная ошибка!\n");
                    continue;
                }
            }
            interfaceConsole.ConsolePause();
        }

        private void StoneCutterPaperMultiPlayer()
        {
            Procedures.Sys.InterfaceConsole interfaceConsole = new Procedures.Sys.InterfaceConsole();

            Console.WriteLine("MultiPlayer");
            interfaceConsole.ConsolePause();
        }

        public void StoneCutterPaperMain()
        {
            Procedures.Sys.InterfaceConsole interfaceConsole = new Procedures.Sys.InterfaceConsole();

            short inp;
            while (true)
            {
                try
                {
                    Console.WriteLine("Добро пожаловать в камень, ножницы, бумага, выберите режим:");
                    Console.WriteLine("0 - Выход, 1 - Один игрок, 2 - Два игрока");
                    Console.Write("\nВводите: ");
                    inp = Convert.ToInt16(Console.ReadLine());
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
                    interfaceConsole.ClearAndText("Неизвестная ошибка!\n");
                    continue;
                }

                if (inp == 1)
                {
                    StoneCutterPaperSinglePlayer();
                }
                else if (inp == 2)
                {
                    StoneCutterPaperMultiPlayer();
                }
                else if (inp == 0)
                {
                    interfaceConsole.ConsolePause();
                    break;
                }
                else
                {
                    interfaceConsole.ClearAndText("Ошибка ввода! Нет такого режима!");
                }
            }
        }
    }
}