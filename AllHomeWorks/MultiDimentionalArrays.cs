using System;
using System.Collections.Generic;
using System.Text;

namespace AllHomeWorks
{
   public static class MultiDimentionalArrays


    {

        //Минимальный элемент двумерного массива
        static public int MinElementOfArray(int[,] a)

        {
            int Min = a[0, 0];


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

            //Максимальный элемент двумерного массива

            static public int MaxElementOfArray(int[,] a)

            {
                int Max = a[0, 0];

                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] > Max)
                        {
                            Max = a[i, j];
                        }
                    }
                }

                return Max;

            }


        //Индекс максимального элемента

        public static string MaxIndexArray(int[,]a)
        {
            int b = 0;
            int c = 0;
            int MaxIndex = a[0, 0];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > MaxIndex)
                    {
                        MaxIndex = a[i, j];
                        b = i;
                        c = j;
                    }
                }
            }
            return new string ($"{b},{c}");


        }

        //Индекс минимального элемента
        public static string MinIndexArray(int[,] a)
        {
            int b = 0;
            int c = 0;
            int MinIndex = a[0, 0];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] < MinIndex)
                    {
                        MinIndex = a[i, j];
                        b = i;
                        c = j;
                    }
                }
            }
            return new string($"{b},{c}");


        }

        //количество элементов массива, которые больше всех своих соседей одновременно

        public static int QuantityOfElementsArrayThatBiggerThanAllEllementsAround(int[,] a)
        {
            int Digit = a[0, 0];
            int s = 0;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Digit = a[i, j];

                    if ((i - 1 < 0 || j -1 <0              || Digit > a[i - 1, j - 1])&&
                        (i - 1 < 0                         || Digit > a[i -1, j ]) &&
                        (i - 1 < 0 || j+1 > a.GetLength(1)-1 || Digit > a[i - 1, j +1]) &&

                        (j - 1 < 0                 || Digit > a[i, j - 1]) &&
                        (j + 1 > a.GetLength(1)-1    || Digit > a[i, j + 1]) &&

                        (i + 1 > a.GetLength(0)-1 || j - 1 < 0              || Digit > a[i +1, j - 1]) &&
                        (i + 1 > a.GetLength(0)-1                           || Digit > a[i + 1, j ]) &&
                        (i + 1 > a.GetLength(0)-1 || j + 1 > a.GetLength(1)-1 || Digit > a[i + 1, j+1 ])) 
                    {
                        s = s + 1;
                    }

                }

            }

            return s;
        }



    }
}

