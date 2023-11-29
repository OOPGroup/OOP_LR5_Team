namespace OOP_LR5_1
{
    internal class OrdinaryCalc
    {
        //В даному випадку у класі OrdinaryCalc є конструктор за замовчуванням, але це не явно вказано в коді.

        //Метод для додавання
        public double Sum(double a, double b)
        {
            return a + b;
        }

        //Метод для віднімання
        public double Minus(double a, double b)
        {
            return a - b;
        }

        //Метод для множення
        public double Multiplication(double a, double b)
        {
            return a * b;
        }

        //Метод для ділення
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Ділення на 0 неможливе");
                return -1;
            }
            return a / b;
        }
    }
}
