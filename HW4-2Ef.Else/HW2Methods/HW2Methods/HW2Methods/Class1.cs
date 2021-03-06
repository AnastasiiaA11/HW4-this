using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2Methods
{
    public static class HomeworkIfElse
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



        public static int[] PrintToConsoleInAscendingOrder(int A, int B, int C)
        {
            int[] result = new int[] { A, B, C };
            
            
            for (int i = 0; i < result.Length; i += 1)
            {
                for (int j = 1 + i; j < result.Length; j++)
                    if (result[j] < result[i])
                    {
                        int c = result[i];
                        result[i] = result[j];
                        result[j] = c;
                    }
            }
            return result;
        }
        public static void Write(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }


        public static string PrintToTheConsoleTheSolutionOfTheQuadraticEquation(int A, int B, int C)
        {
            string result = " ";
            double D = ((B * B) - (4 * A * C));

            if (D > 0)

            {

                return $"result1 = {(-B + Math.Sqrt(D)) / (2 * A)}; result2 = {(-B - Math.Sqrt(D)) / (2 * A)}";

            }
            else if (D == 0)
            {
                return $"X = {(double)((-B)) / ((2 * A))}";

            }
            else if (D < 0)
            {
                result = "Ответ: нет корней";
            }
            return result;
        }



        public static string WritingInWords(int number)
        {
            int dozens = number / 10; //десятки
            int units = number % 10; // единицы
            string firstWord = "";
            string secondWord = "";
            string result;

            if (number < 10 || number > 99)
            {
                throw new Exception("");
            }

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
                result = firstWord + " " + secondWord;
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
