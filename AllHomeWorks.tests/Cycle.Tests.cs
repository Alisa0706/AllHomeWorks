using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using AllHomeWorks;

namespace AllHomeWorks.tests
{
    public class CycleTests
    {
        //а в степени б

        [TestCase(2, 2, 4)]
        [TestCase(569, 0, 1)]
        [TestCase(2, -2, 0.25)]
        public void aPowerB(int a, int b, double expected)
        {
            double actual = Cycle.aPowerB(a, b);
            Assert.AreEqual(expected, actual);
        }

        //Вывести все числа от 1 до 1000, которые делятся на A

        [TestCase(200, new int [5] {200,400,600,800,1000})]
        public void AllDigitsThatYouCanDevoteA(int a, int[] expected)
        {
            int [] actual = Cycle.AllDigitsThatYouCanDevoteA(a);
            Assert.AreEqual(expected, actual);
        }

        //Найдите количество положительных целых чисел, квадрат которых меньше A.
        [TestCase(10,3)]
        [TestCase(17,4)]
        [TestCase(0,0)]
        public void PositiveIntegersInSquareLessThanA(int a, int expected)
        {
            int actual = Cycle.PositiveIntegersInSquareLessThanA(a);
            Assert.AreEqual(expected, actual);

        }

        //Вывести наибольший делитель(кроме самого A) числа A.
        [TestCase(21,7)]
        [TestCase(100,50)]
        [TestCase(16,8)]
        public void LargestDivisor(int a, int expected)
        {
            int actual = Cycle.LargestDivisor(a);
            Assert.AreEqual(expected, actual);
        }

        //Пользователь вводит 2 числа (A и B). 
        //Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7. 
        //(Учтите, что при вводе B может оказаться меньше A).
        [TestCase(1,22,42)]
        [TestCase(0,-15,-21)]
        [TestCase(1,2,0)]
        public void SummOfAllDigitsFromAtoBThatYouCanDevoteOnSevenWithoutLeftover(int a, int b, int expected)
        {
            int actual = Cycle.SummOfAllDigitsFromAtoBThatYouCanDevoteOnSevenWithoutLeftover(a, b);
            Assert.AreEqual(expected, actual);

        }

        //Пользователь вводит 1 число (N). Выведите N-ое число ряда фибоначчи. 
        //В ряду фибоначчи каждое следующее число является суммой двух предыдущих. 
        //Первое и второе считаются равными 1.
        [TestCase(3, 2)]
        [TestCase(5, 5)]
        [TestCase(7, 13)]
        public void DigitNofRowFibonachi(int n,int expected)
        {
            int actual = Cycle.DigitNofRowFibonachi(n);
            Assert.AreEqual(expected, actual);
        }

        //Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида
        [TestCase(20, 15, 5)]
        [TestCase(21, 14, 7)]
        //[TestCase(0, 15, 0)]
        public void NOD(int a, int b, int expected)
        {
            int actual = Cycle.NOD(a, b);
            Assert.AreEqual(expected, actual);

        }

        // Пользователь вводит целое положительное число, которое является кубом целого числа N.
        //    Найдите число N методом половинного деления.

        [TestCase(27, 3)]
        [TestCase(8, 2)]
        [TestCase(1000, 10)]

        public void FindN(int a, int expected)
        {
            int actual = Cycle.FindN(a);
            Assert.AreEqual(expected, actual);

        }


        //Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.
        [TestCase(22563,2)]
        [TestCase(1077,3)]
        [TestCase(2222,0)]
        
        public void QuantityOffOddDigits(int a, int expected)
        {
            int actual = Cycle.QuantityOffOddDigits(a);
            Assert.AreEqual(expected, actual);

        }

        //Пользователь вводит 1 число.Найти число, 
        //которое является зеркальным отображением последовательности цифр 
        //заданного числа, например, задано число 123, вывести 321.

        [TestCase(123, 321)]
        [TestCase(4567, 7654)]
        [TestCase(1010, 0101)]

        public void InvertedDigit(int a, int expected)
        {
            int actual = Cycle.InvertedDigit(a);
            Assert.AreEqual(expected, actual);

        }

        //Пользователь вводит целое положительное  число (N). Выведите количество чисел в диапазоне от 1 до N, 
        //сумма четных цифр которых больше суммы нечетных. 

        [TestCase(8, 3)]
        [TestCase(10, 4)]

        public void NumbersWithSummEvenDigitsMoreThanOdds(int a, int expected)
        {
            int actual = Cycle.NumbersWithSummEvenDigitsMoreThanOdds(a);
            Assert.AreEqual(expected, actual);

        }




        //Пользователь вводит 2 числа.
        //Сообщите, есть ли в написании двух чисел одинаковые цифры. 
        //Например, для пары 123 и 3456789, ответом будет являться “ДА”, 
        //а, для пары 500 и 99 - “НЕТ”.

        [TestCase(12345, 77577, true)]
        [TestCase(12345, 999999, false)]
        [TestCase(10004, 3330777, true)]

        public void IfThereIsSameDigits(int a, int b, bool expected)
        {
            bool actual = Cycle.IfThereIsSameDigits(a,b);
            Assert.AreEqual(expected, actual);
        }


    }
}
