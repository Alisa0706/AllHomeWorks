using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using AllHomeWorks;


namespace AllHomeWorks.tests
{
    public class MultiDimentionalArraysTests
    {
        int[,] GetaMock(int n)
        {

            switch (n)
            {
                case 1:
                    return new int[,]
                {
                {1,2,3},
                {4,5,6}
                };
                case 2:
                    return new int[,]
                {
                {10,22,33},
                {41,5,-6}
                };

                default:
                    throw new Exception();
            }
        }


        //Минимальный элемент двумерного массива
        [TestCase(1,1)]
        public void MinElementOfArray(int n, int expected) 
        {
            
            int actual = MultiDimentionalArrays.MinElementOfArray(GetaMock(n));
            Assert.AreEqual(expected, actual);

        }

        //Максимальный элемент двумерного массива
        [TestCase(2, 41)]
        public void MaxElementOfArray(int n, int expected)
        {

            int actual = MultiDimentionalArrays.MaxElementOfArray(GetaMock(n));
            Assert.AreEqual(expected, actual);

        }

        //Индекс максимального элемента

        [TestCase(2, "1,0")]
        public void MaxIndexArray(int n, string expected)
        {

            string actual = MultiDimentionalArrays.MaxIndexArray(GetaMock(n));
            Assert.AreEqual(expected, actual);

        }

        //Индекс минимального элемента

        [TestCase(2, "1,2")]
        public void MinIndexArray(int n, string expected)
        {

            string actual = MultiDimentionalArrays.MinIndexArray(GetaMock(n));
            Assert.AreEqual(expected, actual);

        }

        //количество элементов массива, которые больше всех своих соседей одновременно

        [TestCase(2, 2)]
        public void QuantityOfElementsArrayThatBiggerThanAllEllementsAround(int n, int expected)
        {

            int actual = MultiDimentionalArrays.QuantityOfElementsArrayThatBiggerThanAllEllementsAround(GetaMock(n));
            Assert.AreEqual(expected, actual);

        }


    }
}
