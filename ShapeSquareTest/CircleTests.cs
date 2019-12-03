using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeSquare;

namespace ShapeSquareTest
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Square_radius10_3141593returned()
        {
            //arrage
            double radius = 10;
            double expected = 314.159;

            //act
            Circle c  = new Circle(radius);
            double actual = Math.Round(c.ShapeSquare(), 3);

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
