using MindBoxInternshipTask.Figures;

namespace MindBoxInternshipTask.Tests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void CircleNegativeRadiusTest()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }

        [Test]
        public void CircleSquareCalculate()
        {
            var circle = new Circle( 5);

            Assert.AreEqual(78.53981633974483, circle.Square);
        }
    }
}
