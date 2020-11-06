using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AllHomeWorks
{
    public class Cycle

    {
        //а в степени б
        static public double aPowerB(int a, int b)
        {

            double c = Math.Pow(a, b);

            return c;
        }




        //Вывести все числа от 1 до 1000, которые делятся на A

        static public int[] AllDigitsThatYouCanDevoteA(int a)
        {

            int[] arr = new int[1000 / a];
            int t = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    arr[t] = i;
                    t++;
                };
            }
            return arr;
        }


        //Найдите количество положительных целых чисел, квадрат которых меньше A.

        static public int PositiveIntegersInSquareLessThanA(int a)
        {


            int s = 0;
            for (int i = 1; i < a; i++)
            {
                if (i * i < a)
                {
                    s += 1;
                }
            }
            return s;
        }


        //Вывести наибольший делитель(кроме самого A) числа A.

        static public int LargestDivisor(int a)
        {

            int s = 0;
            for (int i = 1; i < a - 1; i++)
            {
                if (a % i == 0)
                {
                    s = i;
                }
            }
            return s;
        }


        //Пользователь вводит 2 числа (A и B). 
        //Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7. 
        //(Учтите, что при вводе B может оказаться меньше A).

        public static int SummOfAllDigitsFromAtoBThatYouCanDevoteOnSevenWithoutLeftover(int a, int b)
        {

            int c;
            int s = 0;

            if (b < a)
            {
                c = a;
                a = b;
                b = c;
            }
            for (int i = a; i < b; i++)
            {
                if (i % 7 == 0)
                { s += i; }
            }

            return s;
        }


        //Пользователь вводит 1 число (N). Выведите N-ое число ряда фибоначчи. 
        //В ряду фибоначчи каждое следующее число является суммой двух предыдущих. 
        //Первое и второе считаются равными 1.


        public static int DigitNofRowFibonachi(int n)
        {
            int i;
            int c = 1;
            int b = 1;
            int a = 1;

            for (i = 3; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;

        }

        //Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.

        static public int NOD(int a, int b)
        {
            int c = 0;
            while (a != 0 && b != 0)
            {
                if (a > b)
                { a = a % b; }
                else
                { b = b % a; }
            }
            c = a + b;
            return c;
        }

        // Пользователь вводит целое положительное число, которое является кубом целого числа N.
        //    Найдите число N методом половинного деления.

        static public int FindN(int a)
        {
            int leftBound = 0;
            int RightBound = a;

            int current = 0;

            while (Math.Pow(current, 3) != a)
            {
                current = (leftBound + RightBound) / 2;
                if (Math.Pow(current, 3) > a)
                {
                    RightBound = current;
                }
               else
                {
                    leftBound = current;
                }
            }

            return current;
        }


        //Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.

        static public int QuantityOffOddDigits(int a)
        {

            int s = 0;
            int b = 0;

            while (a != 0)
            {
                b = a % 10;
                if (b % 2 == 1)
                {
                    s += 1;
                }
                a /= 10;
            }

            return s;

        }

        //Пользователь вводит 1 число.Найти число, 
        //которое является зеркальным отображением последовательности цифр 
        //заданного числа, например, задано число 123, вывести 321.


        static public int InvertedDigit(int a)
        {
            int b = 0;
            int s = 0;

            while (a != 0)
            {
                b = a % 10;
                a /= 10;
                s = s * 10 + b;
            }
            return s;

        }

        //Пользователь вводит целое положительное  число (N). Выведите количество чисел в диапазоне от 1 до N, 
        //сумма четных цифр которых больше суммы нечетных. 
        
        static public int NumbersWithSummEvenDigitsMoreThanOdds(int a)
        {
            int b;
            int Digit;

            int SummEven = 0;
            int SummOdd = 0;

            int result = 0;

            for (int i = 0; i < a; i++)
            {
                b = i;
                SummEven = 0;
                SummOdd = 0;

                while (b != 0)
                {
                    Digit = b % 10;

                    if (Digit % 2 == 0)
                    {
                        SummEven += Digit;
                    }
                    else
                    {
                        SummOdd += Digit;
                    }
                    b /= 10;

                }
                if (SummEven > SummOdd)
                {
                    result++;
                }
            }
            
            return result;
        }



        //Пользователь вводит 2 числа.Сообщите, есть ли в написании двух чисел одинаковые цифры. 
        //Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.
        static public bool IfThereIsSameDigits(int a, int b)
        {

            //Trace.Write("ddsf0");

            while (a != 0)
            {
                int d = a % 10;
                int bCopy = b;

                while (bCopy!=0) 
                {
                    int c = bCopy % 10;
                    if (d == c)
                    {
                        return true;
                    }
                    else
                    {
                        bCopy /= 10;
                        
                    }
                }
                a = a / 10;
            }
                
            return false;

        }











    }
}
