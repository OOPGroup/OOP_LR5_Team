namespace OOP_LR5_2
{
    internal class AdvancedCalc : OrdinaryCalc, IAdvanced
    {
        public double Kilometr_Mile(double a)
        {
            if (a >= 1 && a <= 1000)
            {
                a = a * 0.621371;
                return a;
            }

            Console.WriteLine("Не вірний діапазон (1 <= a <= 1000)");
            return -1;
        }
    }
}
