using NUnit.Framework;
using System;

namespace HW3Methods.Test
{
    public class HomeworkCyclesTest
    {
        [TestCase(0,0,0)]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void SquaringNumberTest(int A, int B, double expected)
        {
            double actual = HomeworkCycles.SquaringNumber(A, B);
            Assert.AreEqual(expected, actual);
        }
    }
}