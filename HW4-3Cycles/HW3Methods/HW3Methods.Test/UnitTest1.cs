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
        public void PrintTheNthNumberOfTheFibonacciSeriesTest_ThenNlessZero_ShouldThrowException(int N)
        {
            Assert.Throws<Exception>(() => HomeworkCycles.PrintTheNthNumberOfTheFibonacciSeries(N));
        }

        [TestCase(30,18,6)]
        [TestCase(15,3,3)]
        [TestCase(50,15,5)]
        public void FindTheGreatestComminDivisorTest(int NumberM, int NumberQ, int expected)
        {
            int actual= HomeworkCycles.FindTheGreatestComminDivisor(NumberM, NumberQ);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0,0)]
        [TestCase(-1,2)]
        [TestCase(2,0)]
        public void FindTheGreatestComminDivisorTest_ThenNumberZero_ShouldThrowException(int NumberM, int NumberQ)
        {
            Assert.Throws<Exception>(() => HomeworkCycles.FindTheGreatestComminDivisor(NumberM,NumberQ));
        }

        [TestCase(64,4)]
        [TestCase(343,7)]
        [TestCase(729,9)]
        public void FindaNumberUsingTheHalfDivisionMethodTest(int enteredNumber,int expected)
        {
            int actual = HomeworkCycles.FindaNumberUsingTheHalfDivisionMethod(enteredNumber);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-8)]       
        public void FindaNumberUsingTheHalfDivisionMethodTest_ThenEnteredNumberLesszero(int enteredNumber)
        {
            Assert.Throws<Exception>(() => HomeworkCycles.FindaNumberUsingTheHalfDivisionMethod(enteredNumber));
        }

        [TestCase(38,19)]
        [TestCase(91,46)]
        [TestCase(-69,0)]
        public void FindNumberOfOddDigitsTest(int NumberEntered, int expected)
        {
            int actual = HomeworkCycles.FindNumberOfOddDigits(NumberEntered);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(596,695)]
        [TestCase(15,51)]
        [TestCase(16975,57961)]
        public void FindaNumberThatIsaMirrorImageOfaSequencefDigitsOfaGivenNumberTest(int NumberEnteredUser, int expected)
        {
            int actual = HomeworkCycles.FindaNumberThatIsaMirrorImageOfaSequencefDigitsOfaGivenNumber(NumberEnteredUser);
             Assert.AreEqual(expected, actual);
        }
        [TestCase(0)]
        [TestCase(-100)]     
        public void FindaNumberThatIsaMirrorImageOfaSequencefDigitsOfaGivenNumberTest_NumberEnteredUserNotBeLessZero(int NumberEnteredUser)
        {
            Assert.Throws<Exception>(() => HomeworkCycles.FindaNumberThatIsaMirrorImageOfaSequencefDigitsOfaGivenNumber(NumberEnteredUser));
        }

        [TestCase(10, new int[] { 2, 4, 6, 8 })]
        [TestCase(5, new int[] {2,4})]
        public void OutputNumbersInTheRangeTest(int N, int[] expected)         {
            int[] actual = HomeworkCycles.OutputNumbersInTheRange(N);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-100)]
        public void OutputNumbersInTheRangeTest_NEnteredUserNotBeLessZero(int N)
        {
            Assert.Throws<Exception>(() => HomeworkCycles.OutputNumbersInTheRange(N));
        }

        [TestCase(589, 123658, true)]
        [TestCase(007, 555, false)]
        public void TellMeIfThereAreTheSameDigitsInTheSpellingOfTwoNumbersTest(int NumberEnteredA, int NumberEnteredB, bool expected)
        {
            bool actual = HomeworkCycles.TellMeIfThereAreTheSameDigitsInTheSpellingOfTwoNumbers(NumberEnteredA, NumberEnteredB);
            Assert.AreEqual(expected, actual);
        }
       
        [TestCase(-2,23)]
        public void TellMeIfThereAreTheSameDigitsInTheSpellingOfTwoNumbersTest_EnteredUserNotBeLessZero(int NumberEnteredA, int NumberEnteredB)
        {
            Assert.Throws<Exception>(() => HomeworkCycles.TellMeIfThereAreTheSameDigitsInTheSpellingOfTwoNumbers(NumberEnteredA, NumberEnteredB));
        }
    }
}