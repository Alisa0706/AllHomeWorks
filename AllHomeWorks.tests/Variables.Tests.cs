using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using AllHomeWorks;

namespace AllHomeWorks.tests
{
    public class VariablesTests
    {
        [TestCase(1, 2, 9)]
        [TestCase(0, 3, 3)]
        [TestCase(-3, -2, -11)]
        public void SolutionFor(int a, int b, double expected)
        {
            double actual = Variables.SolutionFor(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2,2)]
        public void SolutionForNegative(int a, int b)
        {
            try
            {
                Variables.SolutionFor(a, b);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }


        [TestCase(4, 2, new int[2] { 2,0 })]
        [TestCase(-10, 5, new int[2] { -2, 0 })]
        [TestCase(7, 2, new int[2] { 3, 1 })]
        public void SolutionForAdevoteB(int a, int b, int[] expected)
        {
            int [] actual = Variables.SolutionForAdevoteB(a, b);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(1, 9, 10, 1)]
        [TestCase(2, 8, 4, -2)]
        [TestCase(7, 4, -10,-2)]
        public void SolutionForX(double a, double b, double c, double expected)
        {
            double actual = Variables.SolutionForX(a, b,c);
            Assert.AreEqual(expected, actual);

        }


        [TestCase(1, 2, 3, 4, new double[2] { 1, 5 })]
        //[TestCase(1, 2, 3, 4, new double[2] { 1, 5 })]
        //[TestCase(1, 2, 3, 4, new double[2] { 1, 5 })]

        public void SolutionForY(int X1, int Y1, int X2, int Y2, double[] expected)
        {
            double[] actual = Variables.SolutionForY(X1,Y1,X2,Y2);
            Assert.AreEqual(expected, actual);

        }



    }
}
