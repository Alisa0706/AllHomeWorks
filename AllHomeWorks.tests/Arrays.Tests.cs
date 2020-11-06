using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using AllHomeWorks;

namespace AllHomeWorks.tests
{
    public class ArraysTests
    {
        //Найти минимальный элемент массива


        [TestCase(new int[4] { 1, 2, 3, 4 }, 1)]
        [TestCase(new int[4] { -1, 0, 3, -15 }, -15)]
        [TestCase(new int[4] { 89, 2, 55, 4 }, 2)]
        public void MinimalElementOfArray(int[] n, int expected)
        {
            int actual = Arrays.MinimalElementOfArray(n);
            Assert.AreEqual(expected, actual);

        }

        //Найти максимальный элемент массива


        [TestCase(new int[4] { 1, 2, 3, 4 }, 4)]
        [TestCase(new int[4] { 11, 102, -3, 4 }, 102)]
        [TestCase(new int[4] { 1, -2, 55, 89 }, 89)]
        public void MaxElementOfArray(int[] a, int expected)
        {
            int actual = Arrays.MaxElementOfArray(a);
            Assert.AreEqual(expected, actual);

        }

        //индекс минимального элемента массива

        [TestCase(new int[4] { 1, 2, 3, 4 }, 0)]
        [TestCase(new int[4] { -1, 0, 3, -15 }, 3)]
        [TestCase(new int[4] { 89, 2, 55, 4 }, 1)]
        public void IndexOfMinimalEllementOfArray(int[] a, int expected)
        {
            int actual = Arrays.IndexOfMinimalEllementOfArray(a);
            Assert.AreEqual(expected, actual);

        }

        //индекс максимального элемента массива

        [TestCase(new int[4] { 1, 2, 3, 4 }, 3)]
        [TestCase(new int[4] { -1, 0, 3, -15 }, 2)]
        [TestCase(new int[4] { 89, 2, 55, 4 }, 0)]
        public void IndexOfMaxElementOfArray(int[] a, int expected)
        {
            int actual = Arrays.IndexOfMaxElementOfArray(a);
            Assert.AreEqual(expected, actual);

        }

        //Сумма элементов массива с нечетными индексами

        [TestCase(new int[4] { 1, 2, 3, 4 }, 6)]
        [TestCase(new int[4] { -1, 0, 3, -15 }, -15)]
        [TestCase(new int[4] { 89, 2, 55, 4 }, 6)]
        public void SummOfEllementsWithOddIndexOfArray(int[] a, int expected)
        {
            int actual = Arrays.SummOfEllementsWithOddIndexOfArray(a);
            Assert.AreEqual(expected, actual);

        }

        //Посчитать количество нечетных элементов массива

        [TestCase(new int[4] { 1, 2, 3, 4 }, 2)]
        [TestCase(new int[4] { -1, 0, 3, -15 }, 3)]
        [TestCase(new int[4] { 89, 2, 55, 4 }, 2)]
        public void QuantityOfOddElementsOfArray(int[] a, int expected)
        {
            int actual = Arrays.QuantityOfOddElementsOfArray(a);
            Assert.AreEqual(expected, actual);
        }

        //Сделать реверс массива (массив в обратном направлении)

        [TestCase(new int[4] { 1, 2, 3, 4 }, new int[4] { 4, 3 , 2, 1})]
        [TestCase(new int[4] { 1, 20, 30, 40 }, new int[4] { 40, 30 , 20, 1})]
        [TestCase(new int[4] { 11, 21, 31, 41 }, new int[4] { 41, 31 , 21, 11})]
        public void ReverseOfArray(int[] arr, int[] expected)
        {
            int[] actual = Arrays.ReverseOfArray(arr);
            Assert.AreEqual(expected, actual);
        }

        //Поменять местами первую и вторую половину массива, 
        //например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.

        [TestCase(new int[4] { 1, 2, 3, 4 }, new int[4] { 3, 4, 1, 2 })]
        [TestCase(new int[4] { 1, 20, 30, 40 }, new int[4] { 30, 40, 1, 20 })]
        [TestCase(new int[4] { 11, 21, 31, 41 }, new int[4] { 31, 41, 11, 21 })]
        public void ChangeHalfsOfArray(int[] a, int[] expected)
        {
            int[] actual = Arrays.ChangeHalfsOfArray(a);
            Assert.AreEqual(expected, actual);
        }


        //Сортировка по убыванию пузырек 

        [TestCase(new int[4] { 1, 2, 3, 4 }, new int[4] { 4, 3, 2, 1 })]
        [TestCase(new int[4] { 1, 20, 30, 40 }, new int[4] { 40, 30, 20, 1 })]
        [TestCase(new int[4] { 11, 21, 31, 41 }, new int[4] { 41, 31, 21, 11 })]
        public void SelectionBubleFromMaxToMin(int[] a, int[] expected)
        {
            int[] actual = Arrays.SelectionBubleFromMaxToMin(a);
            Assert.AreEqual(expected, actual);
        }

        //Сортировка по возрастанию прямой выбор

        [TestCase(new int[4] { 5, 1, 3, 7 }, new int[4] { 1, 3, 5, 7 })]
        [TestCase(new int[4] { 15, 11, 13, 17 }, new int[4] { 11, 13, 15, 17 })]
        [TestCase(new int[4] { 50, 10, 30, 70 }, new int[4] { 10, 30, 50, 70 })]
        public void SelectionFromMinToMax(int[] a, int[] expected)
        {
            int[] actual = Arrays.SelectionFromMinToMax(a);
            Assert.AreEqual(expected, actual);
        }



    }
}
