using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace AllHomeWorks
{
    public class Arrays
    {

        //минимальный элемент массива
        public static int MinimalElementOfArray(int n)
        {

        int[] a;
        a = new int[n];

            int Min = a[0];

        Random random = new Random();

            for (int i = 0; i<a.Length; i++) 
            {
                a[i] = random.Next(-20,20);
                Console.Write(a[i] + " ");
            }

    Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i<a.Length; i++)
            {
                if (a[i] < Min)
                {
                    Min = a[i];
                }
            }

            return Min;
          }


        //максимальный элемент массива

        public static int MaxElementOfArray(int n)
        {
            int[] a;
            a = new int[n];

            int Max = a[0];

            Random random = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(-20, 20);
                Console.Write(a[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > Max)
                {
                    Max = a[i];
                }
            }

            return Max;


        }

        //индекс минимального элемента массива

        static public int IndexOfMinimalEllementOfArray(int n)
        {
            int[] a;
            a = new int[n];

            int MinIndex = a[0];
            int j;
            Random random = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(-20, 20);
                Console.Write(a[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 1; i < a.Length - 1; i++)
            {
                for (j = i; j < a.Length; j++)
                {
                    if (a[j] < a[MinIndex])
                    {
                        MinIndex = j;
                    }
                }
            }
            return MinIndex;

        }

        //Индекс максимального элемента массива

        static public int IndexOfMaxElementOfArray(int n)
        {
            int[] a;
            a = new int[n];

            int MaxIndex = a[0];
            int j;
            Random random = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(-20, 20);
                Console.Write(a[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 1; i < a.Length - 1; i++)
            {
                for (j = i; j < a.Length; j++)
                {
                    if (a[j] > a[MaxIndex])
                    {
                        MaxIndex = j;
                    }
                }
            }
            return MaxIndex;

        }



        //Сумма элементов массива с нечетными индексами

        static public int SummOfEllementsWithOddIndexOfArray(int n)
        {
            int s = 0;
            int[] a;
            a = new int[n];

            Random random = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(-20, 20);
                Console.Write(a[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < a.Length; i++)
            {

                if (i % 2 != 0)
                {
                    s = s + a[i];

                }

            }
            return s;
        }




        //Посчитать количество нечетных элементов массива

        static public int QuantityOfOddElementsOfArray(int n)
        {
            int s = 0;
            int[] a;
            a = new int[n];

            Random random = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(-20, 20);
                Console.Write(a[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] % 2 != 0)
                {
                    s = s + 1;
                }

            }
            return s;
        }


        //Сделать реверс массива (массив в обратном направлении)

        static public int[] ReverseOfArray(int n)
        {
            int[] arr = new int[n];
            int b = arr[0];

            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-20, 20);
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < arr.Length / 2; i++)
            {
                b = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = b;
            }

            return arr;
        }

        //Сортировка по убыванию Прямой выбор

        static public int[] SelectionBubleFromMaxToMin(int n)
        {

            int[] a;
            a = new int[n];

            Random random = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(-20, 20);
                Console.Write(a[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();



            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] < a[j]) // сортировка по убыванию
                    {
                        int c = a[i];
                        a[i] = a[j];
                        a[j] = c;
                    }
                }
            }
            return a;
        }

        static public int[] SelectionFromMinToMax(int n)
        {
            int[] a;
            a = new int[n];

            Random random = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(-20, 20);
                Console.Write(a[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < a.Length - 1; i++)
            {
                int MinIndex = i;

                for (int j = i; j < a.Length; j++)
                {
                    if (a[j] < a[MinIndex])
                    {
                        MinIndex = j;
                    }
                }

                int c = a[i];
                a[i] = a[MinIndex];
                a[MinIndex] = c;
            }

            return a;


        }


    }
}
