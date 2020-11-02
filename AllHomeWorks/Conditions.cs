using System;
using System.Collections.Generic;
using System.Text;

namespace AllHomeWorks
{
   public static class Conditions
    {
        static public double[] Actions_a_and_b (int a, int b, int c)
        {
            if (a > b)
            {
                c = a + b;
            }


            if (a == b)
            {
                c = a * b;
            }


            if (a < b)
            {
                c = a - b;
            }

            double[] Array = new double[] { a, b };
            return Array;


        }


        //корни квадратного уравнения
        static public double[] SolutionForEquation(int a, int b, int c)
        {
            double D = (b * b) - 4 * a * c;

            if (D > 0)
            {
                double X1, X2;
                X1 = (-b + Math.Sqrt(D)) / (2 * a);
                X2 = (-b - Math.Sqrt(D)) / (2 * a);

                double[] Roots = new double[] { X1, X2 };
                return Roots;

            }
            else if (D == 0)
            {
                double X1;
                X1 = (-b / (2 * a));

                double[] Root = new double[] { X1 };
                return Root;

            }
            else
            {

                return new double[0];
            }

        }


    }
}
