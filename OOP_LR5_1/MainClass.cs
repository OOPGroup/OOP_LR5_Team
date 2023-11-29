using System.Text;

namespace OOP_LR5_1
{
    internal class MainClass
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool exit = false;
            while (true)
            {
                Console.WriteLine("Введіть 2 числа: ");
                double a = Convert.ToInt32(Console.ReadLine());
                double b = Convert.ToInt32(Console.ReadLine());
                OrdinaryCalc standart = new();
                AdvancedCalc engineer = new();

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
                        Console.WriteLine($"Результат: {standart.Sum(a, b)}");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine($"Результат: {standart.Minus(a, b)}");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine($"Результат: {standart.Multiplication(a, b)}");
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine($"Результат: {standart.Divide(a, b)}");
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine($"Результат для числа 1: {engineer.Kilometr_Mile(a)}");
                        Console.WriteLine($"Результат для числа 2: {engineer.Kilometr_Mile(b)}");
                        break;

                }
                if (exit == true)
                {
                    break;
                }
            }
        }
    }
}