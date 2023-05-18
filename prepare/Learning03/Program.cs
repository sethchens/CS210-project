using System;

namespace Learning03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fraction defaultFraction = new Fraction();
            Console.WriteLine(defaultFraction.GetFractionString());

            Fraction secondFraction = new Fraction(5);
            Console.WriteLine(secondFraction.GetFractionString());

            Fraction thirdFraction = new Fraction(3, 4);
            Console.WriteLine(thirdFraction.GetFractionString());

            Fraction forthFraction = new Fraction(5, 6);
            Console.WriteLine(forthFraction.GetDecimalValue());
        }
    }
}