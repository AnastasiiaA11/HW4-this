using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2Methods
{

    static class HomeworkIfElse
    {
        public static int СomparisonNumber(int A, int B)
        {
            int result;

            if (A > B)
            {
                result = A + B;
            }
            else if (A == B)
            {
                result = A * B;
            }
            else
            {
                result = A - B;
            }
            return result;

        }



        public static string BelongsQuarter(int X, int Y)
        {
            string result;

            if (X > 0 && Y > 0)
            {
                result = "Ответ:первая четверть";
            }
            else if (X < 0 && Y > 0)
            {
                result = "Ответ:вторая четверть";
            }
            else if (X < 0 && Y < 0)
            {
                result = "Ответ:третья четверть";
            }
            else
            {
                result = "Ответ:четвертая четверть";
            }

            return result;
        }



        public static void PrintToConsoleInAscendingOrder(int A, int B, int C)
        {
            if (A < B && A < C)
            {
                Console.WriteLine(A);
                Console.WriteLine(Math.Min(B, C));
                Console.WriteLine(Math.Max(B, C));
            }
            if (B < A && B < C)
            {
                Console.WriteLine(B);
                Console.WriteLine(Math.Min(A, C));
                Console.WriteLine(Math.Max(A, C));
            }
            if (C < B && C < A)
            {
                Console.WriteLine(C);
                Console.WriteLine(Math.Min(A, B));
                Console.WriteLine(Math.Max(A, B));
            }
        }


        public static string PrintToTheConsoleTheSolutionOfTheQuadraticEquation(int A, int B, int C)
        {

            double D = ((B * B) - (4 * A * C));

            if (D > 0)

            {

                return $"result1 = {(-B + Math.Sqrt(D)) / (2 * A)}; result2 = {(-B - Math.Sqrt(D)) / (2 * A)}";

            }
            else if (D == 0)
            {
                return $"X = {((double)(-B)) / ((2 * A))}";

            }
            else if (D < 0)
            {
                return "Ответ: нет корней";
            }

        }



        public static string WritingInWords(int number)
        {
            int dozens = number / 10; //десятки
            int units = number % 10; // единицы
            string firstWord = "";
            string secondWord = "";
            string result;

            if (dozens >= 2 && dozens < 10)
            {
                switch (dozens) //Конструкция switch/case оценивает некоторое выражение и сравнивает его значение с набором значений. И при совпадении значений выполняет определенный код.
                {
                    case 2: firstWord = "двадцать"; break;//Оператор break завершает выполнение ближайшего внешнего break
                    case 3: firstWord = "тридцать"; break;
                    case 4: firstWord = "сорок"; break;
                    case 5: firstWord = "пятьдесят"; break;
                    case 6: firstWord = "шестьдесят"; break;
                    case 7: firstWord = "семьдесят"; break;
                    case 8: firstWord = "восемьдесят"; break;
                    case 9: firstWord = "девяносто"; break;
                }
                switch (units)
                {
                    case 0: secondWord = ""; break;
                    case 1: secondWord = "один"; break;
                    case 2: secondWord = "два"; break;
                    case 3: secondWord = "три"; break;
                    case 4: secondWord = "четыре"; break;
                    case 5: secondWord = "пять"; break;
                    case 6: secondWord = "шесть"; break;
                    case 7: secondWord = "семь"; break;
                    case 8: secondWord = "восемь"; break;
                    case 9: secondWord = "девять"; break;
                }
                result = number + " - " + firstWord + " " + secondWord;
            }
            else if (dozens == 1)
            {
                switch (number)
                {
                    case 10: firstWord = "десять"; break;
                    case 11: firstWord = "одиннадцать"; break;
                    case 12: firstWord = "двенадцать"; break;
                    case 13: firstWord = "тринадцать"; break;
                    case 14: firstWord = "четырнадцать"; break;
                    case 15: firstWord = "пятнадцать"; break;
                    case 16: firstWord = "шестнадцать"; break;
                    case 17: firstWord = "семнадцать"; break;
                    case 18: firstWord = "восемнадцать"; break;
                    case 19: firstWord = "девятнадцать"; break;
                }
                result = firstWord;
            }
            else
            {
                result = "Введите двузначное число корректно";
            }
            return result;
        }
    }
}



