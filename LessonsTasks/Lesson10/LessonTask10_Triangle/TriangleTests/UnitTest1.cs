using System;
using LessonTask10_Triangle;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleTests
{
    [TestClass]
    public class UnitTest1
    {
        Point p1 = new Point(1, 2);
        Point p2 = new Point(2, 3);
        Point p3 = new Point(3, 4);

        [TestMethod]
        public void DistanceMethodChecking()
        {
            Triangle tr = new Triangle(p1, p2, p3);
            double expected = 2;
            double actual = tr.Distance(p1, p2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PerimetrMethodChecking()
        {
            Triangle tr = new Triangle(p1, p2, p3);
            double expected = 12;
            double actual = tr.Perimetr();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SquareMethodChecking()
        {
            Triangle tr = new Triangle(p1, p2, p3);
            double expected = 192;
            double actual = tr.Square();

            Assert.AreEqual(expected, actual);
        }
    }
}
