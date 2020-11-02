using System;

namespace AllHomeWorks
{
    static public class Variables
    {
         
        static public double SolutionFor(double a, double b)
        {
            double result = 5 * a + b * b / (b - a);
            return (int)result;
        }


        static public int[] SolutionFor_A_devote_B(int a, int b)
        {
            int result = a / b;
            int rest = a % b;
            int[] Array = new int[] { result, rest };
            return Array;


        }

        static public double SolutionFor_X(double a, double b, double c)
        {
            double X = (c - b) / a;
            return X;

        }

        static public double[] SolutionFor_Y(int X1, int Y1, int X2, int Y2)
        {
            double a = (Y2 - Y1) / (X2 - X1);
            double b = (X2 * Y2 - X1 * Y1) / (X2 - X1);

            double[] Array = new double[] { a, b };
            return Array;


        }



    }
}
