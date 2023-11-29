namespace OOP_LR5_1
{
    internal class AdvancedCalc : OrdinaryCalc
    {
        //В даному випадку у класі CalculatorStandart є конструктор за замовчуванням, але це не явно вказано в коді.

        //Метод для переводу з кілометрів у милю
        public double Kilometr_Mile(double a)
        {
            if (a >= 1 && a <= 1000)
            {
                a *= 0.621371;
                return a;
            }
            Console.WriteLine("Не вірний діапазон. (1 <= a <= 1000)");
            return -1;
        }
    }
}
