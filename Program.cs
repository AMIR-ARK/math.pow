using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a value for x: ");
        double x = double.Parse(Console.ReadLine());

        double result = CalculateExpression(x);

        Console.WriteLine("The result of the expression is: {0}", result);

        Console.ReadKey();
    }

    static double CalculateExpression(double x)
    {
        double pow = Math.Pow(x, 2);
        double result = pow + (2 * x) - 4;

        return result;
    }
}