using CalculateArea;
using NUnit.Framework;

namespace CalculateAreaTest
{
    public class CalculateTests
    {

        [Test]
        public void CircleAreaTest()
        {
            //Arrange
            var circle = new CircleArea(7);

            //Act
            var circleArea = circle.ÑalculationCircleArea();

            //Assert
            Assert.AreEqual(153.93804002589985, circleArea);
        }

        [Test]

        public void TriangleAreaTest()
        {
            //Arrange
            var triangle = new TriangleArea(3, 3, 3);

            //Act
            var triangleArea = triangle.ÑalculationTriangleArea();

            //Assert
            Assert.AreEqual(3.897114317029974, triangleArea);
        }



        [Test]

        public void CheckRightTriangleTest()
        {
            //Arrange
            var triangle = new TriangleArea(3, 4, 5);

            //Act
            var checkTriangle = triangle.CheckRightTriangle();

            //Assert
            Assert.AreEqual(true, checkTriangle);
        }

        [Test]

        public void CheckNotRightTriangleTest()
        {
            //Arrange
            var triangle = new TriangleArea(3, 6, 5);

            //Act
            var checkTriangle = triangle.CheckRightTriangle();

            //Assert
            Assert.AreEqual(false, checkTriangle);
        }



    }
}