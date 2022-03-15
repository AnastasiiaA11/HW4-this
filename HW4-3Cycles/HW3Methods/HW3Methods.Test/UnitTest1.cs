using NUnit.Framework;
using System;

namespace HW3Methods.Test
{
    public class HomeworkCyclesTest
    {
        [TestCase(0,5,0)]
        [TestCase(2,2,4)]
        [TestCase(4,4,256)]
        [TestCase(8,2,64)]
        public void SquaringNumberTest(int A, int B, int expected)
        {
            int actual = HomeworkCycles.SquaringNumber(A, B);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-2,-1)]
        [TestCase(-6,-8)]
        [TestCase(-1,-1)]
        public void SquaringNumberTest_EnteredValuesCannotBeNegative_ShouldThrowException(int A, int B)
        {
            Assert.Throws<Exception>(() => HomeworkCycles.SquaringNumber(A,B));
        }

        [TestCase(100,"100 200 300 400 500 600 700 800 900 1000 ")]
        [TestCase(500,"500 1000 ")]
        [TestCase(812,"812 ")]
        public void OutputAllNumbersTest(int A, string expected)
        {
            string actual = HomeworkCycles.OutputAllNumbers(A);
            Assert.AreEqual(expected,actual);
        }


        [TestCase(0)]
        [TestCase(-10)]
        [TestCase(-100)]
        public void OutputAllNumbersTest_NumberLessThanZero_ShouldThrowException(int A)
        {
            Assert.Throws<Exception>(() => HomeworkCycles.OutputAllNumbers(A));
        }

        [TestCase(10,3)]
        [TestCase(8,2)]
        [TestCase(15,3)]
        public void FindTheNumberOfPositiveIntegersTest(int numberA,int expected)
        {
            int actual= HomeworkCycles.FindTheNumberOfPositiveIntegers(numberA);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(50,25)]
        [TestCase(100,50)]
        [TestCase(8,4)]
        public void OutputTheLargestDivisorTest(int numberOne, int expected)
        {
            int actual = HomeworkCycles.OutputTheLargestDivisor(numberOne);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2,20,21)]
        [TestCase(8,21,35)]
        [TestCase(-10,50,189)]
        public void GetTheSumOfAllNumbersinaGroupTest(int numberOneA, int numberOneB, int expected)
        {
            int actual = HomeworkCycles.GetTheSumOfAllNumbersinaGroup(numberOneA, numberOneB);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10,-2)]
        [TestCase(2,-5)]
        [TestCase(15,-5)]
        public void GetTheSumOfAllNumbersinaGroupTest_AlessB_ShouldThrowException(int numberOneA, int numberOneB)
        {
            Assert.Throws<Exception>(() => HomeworkCycles.GetTheSumOfAllNumbersinaGroup(numberOneA, numberOneB));
        }

        [TestCase(1,1)]
        [TestCase(7,13)]
        [TestCase(5,5)]
        public void PrintTheNthNumberOfTheFibonacciSeriesTest(int N, int expected)
        {
            int actual = HomeworkCycles.PrintTheNthNumberOfTheFibonacciSeries(N);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-2)]
        public void PrintTheNthNumberOfTheFibonacciSeriesTest_ThenNlessZero(int N)
        {
            Assert.Throws<Exception>(() => HomeworkCycles.PrintTheNthNumberOfTheFibonacciSeries(N));
        }
    }
}