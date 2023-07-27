namespace TestFigureArea
{
    public class Tests
    {
        [Test]
        public void TestCircle()
        {
            var circle = new Circle(5);
            Assert.That(circle.GetArea(), Is.EqualTo(Math.PI * 25));
        }
        [Test]
        public void TestNegativeCircle()
        {
            var circle = new Circle(-5);
            Assert.That(circle.GetArea(), Is.EqualTo(0));
        }
        [Test]
        public void TestTriangle()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.GetArea(), Is.EqualTo(6));
        }
        [Test]
        public void TestNegativeTriangle()
        {
            var triangle = new Triangle(3, 2, 1);
            Assert.That(triangle.IsValid(), Is.False);
        }

        [Test]
        public void TestRectangular()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.IsRectangular(), Is.True);
        }
    }
}
