namespace Games.Procedures.Sys
{
    public class DataAnalysis
    {
        public int DataInput(short input)
        {
            Procedures.Sys.InterfaceConsole interfaceConsole = new Procedures.Sys.InterfaceConsole();

            while (true)
            {
                try
                {
                    Console.Write("\nВводите: ");
                    input = Convert.ToInt16(Console.ReadLine());
                    break;
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
            return input;
        }

        public string DataInput(string input, bool alt)
        {
            return input;
        }
    }
}