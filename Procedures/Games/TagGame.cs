namespace Games.Procedures.Games
{
    public class TagGameClass
    {
        private int[] gameArr = [0, 0, 0, 0, 0, 0, 0, 0, 0];

        private void gameShow()
        {
            for (int i = 1; i < 10; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(gameArr[i - 1]);
                }
                else
                {
                    Console.Write(gameArr[i - 1]);
                }
            }
        }

        private void randNumbGen()
        {
            Random rnd = new Random();
            for (int i = 1; i < 10; i++)
            {
                gameArr[i - 1] = rnd.Next(0, 2);
            }
        }

        private void GuideGame()
        {
            Procedures.Sys.InterfaceConsole interfaceConsole = new Procedures.Sys.InterfaceConsole();

            Console.Clear();
            Console.WriteLine("Добро пожаловать в пятнашки!");
            Console.WriteLine("\nИнструкция к игре: ");
            Console.WriteLine("1. Для победы необходимо обратить всё поле в единицы");
            Console.WriteLine("2. При изменении одной ячейки меняются и соседние");
            Console.WriteLine("3. Управление происходит числами от 1 до 9");
            Console.WriteLine("\nКлавиши к управлению:\n");
            Console.WriteLine("123");
            Console.WriteLine("|||");
            Console.WriteLine("000");
            Console.WriteLine("\n456");
            Console.WriteLine("|||");
            Console.WriteLine("000");
            Console.WriteLine("\n789");
            Console.WriteLine("|||");
            Console.WriteLine("000");
            interfaceConsole.ConsolePause();
        }

        public void TagGameMain()
        {
            Procedures.Sys.InterfaceConsole interfaceConsole = new Procedures.Sys.InterfaceConsole();

            short inp;

            randNumbGen();
            gameShow();

            while (true)
            {
                try
                {
                    Console.Write("\nЧтобы перейти в режим обучения напишите: -1");
                    Console.Write("\nЧтобы выйти напишите: -2");
                    Console.Write("\nХод: ");
                    inp = Convert.ToInt16(Console.ReadLine());
                }
                catch (FormatException)
                {
                    interfaceConsole.ClearAndText("Ошибка ввода! Введено не число!\n");
                    gameShow();
                    continue;
                }
                catch (StackOverflowException)
                {
                    interfaceConsole.ClearAndText("Ошибка ввода! Введено слишком маленькое или слишком большое число!\n");
                    gameShow();
                    continue;
                }
                catch (Exception)
                {
                    interfaceConsole.ClearAndText("Неизвестная ошибка!\n");
                    gameShow();
                    continue;
                }

                if (inp > 0 && inp < 10)
                {
                    switch (inp)
                    {
                        case 1:
                            gameArr[0] = gameArr[0] == 0 ? 1 : 0;
                            gameArr[1] = gameArr[1] == 0 ? 1 : 0;
                            gameArr[3] = gameArr[3] == 0 ? 1 : 0;
                            break;

                        case 2:
                            gameArr[1] = gameArr[1] == 0 ? 1 : 0;
                            gameArr[0] = gameArr[0] == 0 ? 1 : 0;
                            gameArr[2] = gameArr[2] == 0 ? 1 : 0;
                            gameArr[4] = gameArr[4] == 0 ? 1 : 0;
                            break;

                        case 3:
                            gameArr[2] = gameArr[2] == 1 ? 0 : 1;
                            gameArr[1] = gameArr[1] == 1 ? 0 : 1;
                            gameArr[5] = gameArr[5] == 1 ? 0 : 1;
                            break;

                        case 4:
                            gameArr[3] = gameArr[3] == 1 ? 0 : 1;
                            gameArr[0] = gameArr[0] == 1 ? 0 : 1;
                            gameArr[4] = gameArr[4] == 1 ? 0 : 1;
                            gameArr[6] = gameArr[6] == 1 ? 0 : 1;
                            break;

                        case 5:
                            gameArr[4] = gameArr[3] == 1 ? 0 : 1;
                            gameArr[1] = gameArr[1] == 1 ? 0 : 1;
                            gameArr[3] = gameArr[3] == 1 ? 0 : 1;
                            gameArr[5] = gameArr[5] == 1 ? 0 : 1;
                            gameArr[7] = gameArr[7] == 1 ? 0 : 1;
                            break;

                        case 6:
                            gameArr[5] = gameArr[5] == 1 ? 0 : 1;
                            gameArr[2] = gameArr[2] == 1 ? 0 : 1;
                            gameArr[4] = gameArr[4] == 1 ? 0 : 1;
                            gameArr[8] = gameArr[8] == 1 ? 0 : 1;
                            break;

                        case 7:
                            gameArr[6] = gameArr[6] == 1 ? 0 : 1;
                            gameArr[3] = gameArr[3] == 1 ? 0 : 1;
                            gameArr[7] = gameArr[7] == 1 ? 0 : 1;
                            break;

                        case 8:
                            gameArr[7] = gameArr[7] == 1 ? 0 : 1;
                            gameArr[4] = gameArr[4] == 1 ? 0 : 1;
                            gameArr[6] = gameArr[6] == 1 ? 0 : 1;
                            gameArr[8] = gameArr[8] == 1 ? 0 : 1;
                            break;

                        case 9:
                            gameArr[8] = gameArr[8] == 1 ? 0 : 1;
                            gameArr[5] = gameArr[5] == 1 ? 0 : 1;
                            gameArr[7] = gameArr[7] == 1 ? 0 : 1;
                            break;
                    }
                }
                else if (inp == -1)
                {
                    GuideGame();
                }
                else if (inp == -2)
                {
                    interfaceConsole.ConsolePause();
                    break;
                }
                else
                {
                    interfaceConsole.ClearAndText("Ошибка ввода! Введено слишком маленькое или слишком большое число!\n");
                    gameShow();
                    continue;
                }

                Console.Clear();
                gameShow();

                if (gameArr[0] == 1 &&
                    gameArr[1] == 1 &&
                    gameArr[2] == 1 &&
                    gameArr[3] == 1 &&
                    gameArr[4] == 1 &&
                    gameArr[5] == 1 &&
                    gameArr[6] == 1 &&
                    gameArr[7] == 1 &&
                    gameArr[8] == 1)
                {
                    interfaceConsole.ClearAndText("ПОЗДРАВЛЯЮ С ПОБЕДОЙ!!!");
                    interfaceConsole.ConsolePause();
                    break;
                }
            }
        }
    }
}