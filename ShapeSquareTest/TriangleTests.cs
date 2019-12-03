using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeSquare;

namespace ShapeSquareTest
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Square_3and4and5_6returned()
        {
            //arrage
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            //act
            Triangle t = new Triangle(a, b, c);
            double actual = t.ShapeSquare();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsoscelesTriangle_3and4and3_true()
        {
            //arrage
            double a = 3;
            double b = 4;
            double c = 3;
         

            //act
            Triangle t = new Triangle(a, b, c);
            bool actual = t.IsoscelesTriangle();

            //assert
            Assert.IsTrue(actual);

        }
    }
}
