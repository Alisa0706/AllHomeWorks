using System;
using System.Collections.Generic;
using System.Text;

namespace AllHomeWorks
{
    public static class Conditions
    {

        //Пользователь вводит 2 числа (A и B). 
        //Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.

        static public int ActionsAandB(int a, int b)
        {
            int c = 0;
            if (a > b)
            {
                c = a + b;
            }


            if (a == b)
            {
                c = a * b;
            }


            if (a < b)
            {
                c = a - b;
            }

            return c;


        }



        //Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит 
        //точка с координатами (X,Y).
        static public string SideOfQuadrant(float x, float y)
        {
            if (x > 0 && y > 0)
            {
                return new string("Right upper side");

            }
            if (x > 0 && y < 0)
            {
                return new string("Right lower side");

            }
            if (x < 0 && y > 0)
            {
                return new string("Left upper side");

            }
            if (x < 0 && y < 0)
            {
                return new string("Left lower side");

            }
            return new string("0");
        }


        //Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.

        static public string WrightDigitsFromSmallToLarge(int a, int b, int c)
        {

            if (a < b && a < c)
            {
                if (b < c)
                {
                    return new string ($" {a}, {b}, {c}");
                }

                else
                {
                    return new string ($" {a}, {c}, {b}");
                }
            }

            else if (b < a && b < c)
            {
                if (a < c)
                {
                    return new string ($" {b}, {a}, {c}");
                }

                else
                {
                    return new string ($" {b}, {c}, {a}");
                }
            }
            else if (a < b)
            {
                return new string ($" {c}, {a}, {b}");
            }
            else
            {
                return new string ($" {c}, {b}, {a}");
            }
            
        }



        //корни квадратного уравнения

        static public double[] SolutionForEquation(int a, int b, int c)
        {
            double D = (b * b) - 4 * a * c;

            if (D > 0)
            {
                double X1, X2;
                X1 = (-b + Math.Sqrt(D)) / (2 * a);
                X2 = (-b - Math.Sqrt(D)) / (2 * a);

                double[] Roots = new double[] { X1, X2 };
                return Roots;

            }
            else if (D == 0)
            {
                double X1;
                X1 = (-b / (2 * a));

                double[] Root = new double[] { X1 };
                return Root;

            }
            else
            {

                return new double[0];
            }

        }

        // Число прописью
        static public string DigitInLine(int twoDigit)
        {
            string result = "";

            if (twoDigit < 20)
            {

                switch (twoDigit)
                {
                    case 10:
                        result = "Ten";
                        break;
                    case 11:
                        result = "Eleven";
                        break;
                    case 12:
                        result = "Twelve";
                        break;
                    case 13:
                        result = "Thirteen";
                        break;
                    case 14:
                        result = "Forteen";
                        break;
                    case 15:
                        result = "Fivteen";
                        break;
                    case 16:
                        result = "Sixteen";
                        break;
                    case 17:
                        result = "Seventeen";
                        break;
                    case 18:
                        result = "Eighteen";
                        break;
                    case 19:
                        result = "Nineteen";
                        break;
                   
                }
                return (result);
            }
            
            switch(twoDigit/10)

        { 
            case 2:
                result += "Twenty";
                break;
            case 3:
                result += "Thity";
                break;
            case 4:
                result += "Forty";
                break;
            case 5:
                result += "Fivty";
                break;
            case 6:
                result += "Sixty";
                break;
            case 7:
                result += "Seventy";
                break;
            case 8:
                result += "Eighty";
                break;
            case 9:
                result += "Ninety";
                break;

        }
            switch (twoDigit % 10)

            {
            case 1:
                result += "One";
                break;
            case 2:
                result += "Two";
                break;
            case 3:
                result += "Three";
                break;
            case 4:
                result += "Four";
                break;
            case 5:
                result += "Five";
                break;
            case 6:
                result += "Six";
                break;
            case 7:
                result += "Seven";
                break;
            case 8:
                result += "Eight";
                break;
            case 9:
                result += "Nine";
                break;

            }

            return (result);
        }



    }
}
