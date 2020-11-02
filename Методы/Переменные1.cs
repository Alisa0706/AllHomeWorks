using System;
using AllHomeWorks;

namespace Методы
{
    class Переменные1
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Введите n");

            double n = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Введите m");

            double m = Convert.ToDouble(Console.ReadLine());

            double result = Variables.SolutionFor(n, m);

            Console.WriteLine($" 5 * a + b * b / (b - a) = {result}");

        }

        
    }
}
