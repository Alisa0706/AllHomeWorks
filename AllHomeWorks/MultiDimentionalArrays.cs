using System;
using System.Collections.Generic;
using System.Text;

namespace AllHomeWorks
{
    class MultiDimentionalArrays


    {
        static public MinIndexOfArray(int a)

        {

            int[,] a = new int[n, m];
            int Min = a[0, 0];

            Random random = new Random();

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = random.Next(-20, 20);
                    Console.Write(String.Format("{0,5} ", a[i, j]));
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] < Min)
                    {
                        Min = a[i, j];
                    }
                }
            }

            return Min;

        }


    }
}
