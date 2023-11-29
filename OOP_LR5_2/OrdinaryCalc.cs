namespace OOP_LR5_2
{
    internal class OrdinaryCalc : AbstractCalc
    {
        public OrdinaryCalc()
        {
            // Ініціалізація значення за замовчуванням, наприклад, 0
            currentValue = 0;
        }

        public override double Sum(double a, double b)
        {
            currentValue = a + b;
            return currentValue;
        }

        public override double Minus(double a, double b)
        {
            currentValue = a - b;
            return currentValue;
        }

        public override double Multiplication(double a, double b)
        {
            currentValue = a * b;
            return currentValue;
        }

        public override double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Ділення на 0 неможливе");
                return -1;
            }

            currentValue = a / b;
            return currentValue;
        }
    }
}
