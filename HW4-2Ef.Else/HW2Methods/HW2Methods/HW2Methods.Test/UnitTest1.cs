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
        public void ÑomparisonNumberTest(int A, int B, int expected)
        {
            int actual = HomeworkIfElse.ÑomparisonNumber(A, B);
            Assert.AreEqual(expected, actual);
        }
    }
}