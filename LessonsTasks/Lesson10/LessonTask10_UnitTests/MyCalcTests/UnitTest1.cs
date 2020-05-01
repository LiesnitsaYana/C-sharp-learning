using System;
using LessonTask10_UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCalcTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 10;
            int y = 20;
            int expected = 30;

            MyCalc calc = new MyCalc();
            int actual = calc.Sum(x, y);

            Assert.AreEqual(expected, actual);

        }
    }
}
