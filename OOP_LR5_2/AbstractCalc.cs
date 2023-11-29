namespace OOP_LR5_2
{
    public abstract class AbstractCalc
    {
        protected double currentValue;

        public double GetCurrentValue()
        {
            return currentValue;
        }

        public abstract double Sum(double a, double b);
        public abstract double Minus(double a, double b);
        public abstract double Multiplication(double a, double b);
        public abstract double Divide(double a, double b);
    }
}