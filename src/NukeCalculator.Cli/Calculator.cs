namespace NukeCalculator.Cli
{
    using System;

    public class Calculator
    {
        public double Calculate(double a, double b, string op)
        {
            switch (op)
            {
                case "+":
                {
                    return  a + b;
                }
                default:
                {
                    throw new ArgumentException($"Unsupported operator '{op}'");
                }
            }
        }
    }
}