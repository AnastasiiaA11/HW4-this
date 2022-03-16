using NUnit.Framework;
using System;

namespace HW2Methods.Test
{
    public class HomeworkIfElseTest
    {
        [TestCase(5, 2, 7)]
        [TestCase(2, 2, 4)]
        [TestCase(8, 10, -2)]
        [TestCase(10, 2, 12)]
        public void СomparisonNumberTest(int A, int B, int expected)
        {
            int actual = HomeworkIfElse.СomparisonNumber(A, B);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1,2, "Ответ:первая четверть")]
        [TestCase(-8,2, "Ответ:вторая четверть")]
        [TestCase(-10,-5, "Ответ:третья четверть")]
        [TestCase(2,-1, "Ответ:четвертая четверть")]
        public void BelongsQuarterTest(int X, int Y, string expected)
        {
            string actual = HomeworkIfElse.BelongsQuarter(X, Y);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(15,10,8, new int[] { 8, 10, 15 })]
        [TestCase(10,-8,6, new int[] {-8, 6, 10})]
        [TestCase(-1,-10,-55, new int[] {-55,-10,-1})]
        [TestCase(7,0,8, new int[] {0,7,8})]
        public void PrintToConsoleInAscendingOrderTest(int A, int B, int C, int[] expected)
        {
            int[] actual = HomeworkIfElse.PrintToConsoleInAscendingOrder(A,B,C);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2,9,1, "result1 = -0,1139990636706174; result2 = -4,386000936329383")]
        [TestCase(2,1,8, "Ответ: нет корней")]
        [TestCase(1,6,9,"X = -3")]
        public void PrintToTheConsoleTheSolutionOfTheQuadraticEquationTest(int A, int B, int C,string expected)
        {
            string actual = HomeworkIfElse.PrintToTheConsoleTheSolutionOfTheQuadraticEquation(A, B, C);
            Assert.AreEqual(expected, actual);
            
        }

        [TestCase(18, "восемнадцать")]
        [TestCase(25, "двадцать пять")]
        [TestCase(10,"десять")]
        public void WritingInWordsTest(int number, string expected)
        {
            string actual = HomeworkIfElse.WritingInWords(number);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1)]
        [TestCase(6)]
        [TestCase(-1)]
        public void WritingInWords_EnteredNotWhatIsOrdered(int number)
        {
            Assert.Throws<Exception>(() => HomeworkIfElse.WritingInWords(number));
        }
    }
}