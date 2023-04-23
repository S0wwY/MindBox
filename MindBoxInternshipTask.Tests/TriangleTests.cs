using MindBoxInternshipTask.Figures;

namespace MindBoxInternshipTask.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void TriangleNegativeSidesTest()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-1, 4, 5));
            Assert.Throws<ArgumentException>(() => new Triangle(3, -1, 5));
            Assert.Throws<ArgumentException>(() => new Triangle(3, 4, -1));
        }

        [Test]
        public void TriangleSquareTest()
        {
            var triangle = new Triangle(3, 4, 5);

            Assert.AreEqual(6, triangle.Square);
        }

        [Test]
        public void TriangleRightAngleTest()
        {
            var triangle = new Triangle(3, 4, 5);

            Assert.AreEqual(true, triangle.IsRightTriangle);
        }

        [Test]
        public void TriangleNotRightAngleTest()
        {
            var triangle = new Triangle(2, 4, 5);

            Assert.AreEqual(false, triangle.IsRightTriangle);
        }
    }
}
