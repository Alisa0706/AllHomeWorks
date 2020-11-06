using NUnit.Framework;
using AllHomeWorks;

namespace AllHomeWorks.tests
{
    public class ConditionsTests
    {

        //Пользователь вводит 2 числа (A и B). 
        //Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.


        [TestCase(2, 1, 3)]
        [TestCase(5, 7, -2)]
        [TestCase(4, 4, 16)]
        public void ActionsAandB(int a, int b, int expected)
        {
            int actual = Conditions.ActionsAandB(a, b);
            Assert.AreEqual(expected, actual);

        }

        //Пользователь вводит 2 числа(X и Y). Определить какой четверти принадлежит
        //точка с координатами(X, Y).

        [TestCase(2, 1, "Right upper side")]
        [TestCase(2, -1, "Right lower side")]
        [TestCase(-2, 1, "Left upper side")]
        public void SideOfQuadrant(float x, float y, string expected)
        {
            string actual = Conditions.SideOfQuadrant(x, y);
            Assert.AreEqual(expected, actual);
        }


        //Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.

        [TestCase(1, 2, 3, " 1, 2, 3")]
        [TestCase(5, 0, 10, " 0, 5, 10")]
        [TestCase(-20, 1, 1000, " -20, 1, 1000")]
        public void WrightDigitsFromSmallToLarge(int a, int b, int c, string expected)
        {
            string actual = Conditions.WrightDigitsFromSmallToLarge(a, b, c);
            Assert.AreEqual(expected, actual);
        }


        //корни квадратного уравнения

        [TestCase(1,-4,4, new double [1] {2})]
        [TestCase(1,-2,15, new double [0] {})]
        [TestCase(1,2,-15, new double [2] {3,-5})]
        public void SolutionForEquation(int a, int b, int c, double[] expected)
        {
            double[] actual = Conditions.SolutionForEquation(a, b, c);
            Assert.AreEqual(expected, actual);

        }
        // Число прописью

        [TestCase(15, "Fivteen")]
        [TestCase(92, "NinetyTwo")]
        [TestCase(20, "Twenty")]
        public void DigitInLine(int twoDigit, string expected)
        {
            string actual = Conditions.DigitInLine(twoDigit);
            Assert.AreEqual(expected, actual);
        }

    }
} 