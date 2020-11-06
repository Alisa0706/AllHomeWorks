using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace AllHomeWorks
{
    public class Arrays
    {
        //создание рандомного массива
        public static int[] RandomArray(int count)
        {

            int[] a;
            a = new int[count];


            Random random = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(-20, 20);
            }
            return a;

        }


        //минимальный элемент массива
        public static int MinimalElementOfArray(int[] a)
        {
            //int a[] = { 1, 2, 3, 4 };
            //int[] a =  {1,2,3,4};

            int Min = a[0];

            //Console.WriteLine();
            //Console.WriteLine();

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

        public static int MaxElementOfArray(int[] a)
        {
            int Max = a[0];

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

        static public int IndexOfMinimalEllementOfArray(int[]a)
        {
           
            int MinIndex = 0;
            int min = a[0];
            int j;

                for (j = 0; j < a.Length; j++)
                {
                    if (a[j] < min)
                    {
                        MinIndex = j;
                        min = a[j];
                    }
                }
            
            return MinIndex;
        }

        //Индекс максимального элемента массива

        static public int IndexOfMaxElementOfArray(int []a)
        {
            
            int MaxIndex = 0;
            int max = a[0];
            int j;

                for (j = 0; j < a.Length; j++)
                {
                    if (a[j] > a[MaxIndex])
                    {
                        MaxIndex = j;
                    }
                }
            
            return MaxIndex;
        }



        //Сумма элементов массива с нечетными индексами

        static public int SummOfEllementsWithOddIndexOfArray(int []a)
        {
            int s = 0;

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

        static public int QuantityOfOddElementsOfArray(int []a)
        {
            int s = 0;

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

        static public int[] ReverseOfArray(int []arr)
        {
            int b = arr[0];

            for (int i = 0; i < arr.Length / 2; i++)
            {
                b = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = b;
            }

            return arr;
        }

        //Поменять местами первую и вторую половину массива, 
        //например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.

        static public int[] ChangeHalfsOfArray(int []a)
        {
            int b = a[0];
            int c = a[0];

            for (int i = 0; i < a.Length / 2; i++)
            {
                c = a[i];
                a[i] = a[i + (1 + a.Length) / 2];
                a[i + (1 + a.Length) / 2] = c;

            }
            return a;
        }


//Сортировка по убыванию пузырек

        static public int[] SelectionBubleFromMaxToMin(int []a)
        {

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

        //Сортировка по возрастанию прямой выбор

        static public int[] SelectionFromMinToMax(int []a)
        {
            

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
