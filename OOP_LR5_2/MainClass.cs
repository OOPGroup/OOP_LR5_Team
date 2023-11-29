using System.Text;

namespace OOP_LR5_2
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool exit = false;

            AbstractCalc ordinary = new AdvancedCalc();

            while (true)
            {
                Console.WriteLine("Введіть 2 числа: ");
                double a = Convert.ToInt32(Console.ReadLine());
                double b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Оберіть операцію");
                Console.WriteLine("1. Додавання");
                Console.WriteLine("2. Віднімання");
                Console.WriteLine("3. Множення");
                Console.WriteLine("4. Ділення");
                Console.WriteLine("5. Кілометр -> миля");
                Console.WriteLine("0. Вихід");

                int choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 0:
                        exit = true;
                        break;
                    case 1:
                        Console.Clear();
                        Console.WriteLine($"Результат: {ordinary.Sum(a, b)}");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine($"Результат: {ordinary.Minus(a, b)}");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine($"Результат: {ordinary.Multiplication(a, b)}");
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine($"Результат: {ordinary.Divide(a, b)}");
                        break;
                    case 5:
                        if (ordinary is IAdvanced advancedCalc)
                        {
                            Console.Clear();
                            Console.WriteLine($"Результат для числа 1: {advancedCalc.Kilometr_Mile(a)}");
                            Console.WriteLine($"Результат для числа 2: {advancedCalc.Kilometr_Mile(b)}");
                        }
                        break;
                }

                if (exit)
                {
                    break;
                }
            }
        }
    }
}