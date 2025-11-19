using Assignment3_S29927;
using NUnit.Framework;

namespace Assignment3_S29927_Tests
{
    [TestFixture]
    public class Tests
    {
        private readonly IShape sphere    = new Sphere(5);
        private readonly IShape cube      = new Cube(4);
        private readonly IShape rectangle = new Rectangle(4, 8);
        private readonly IShape cylinder  = new Cylinder(3, 7);

        [Test]
        public void TestSphereCalculateArea()
            => Assert.That(sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));

        [Test]
        public void TestSphereCalculateVolume()
            => Assert.That(sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001));

        [Test]
        public void TestCubeCalculateArea()
            => Assert.That(cube.CalculateArea(), Is.EqualTo(96).Within(0.001));

        [Test]
        public void TestCubeCalculateVolume()
            => Assert.That(cube.CalculateVolume(), Is.EqualTo(64).Within(0.001));

        [Test]
        public void TestRectangleCalculateArea()
            => Assert.That(rectangle.CalculateArea(), Is.EqualTo(32).Within(0.001));

        [Test]
        public void TestRectangleCalculateVolume()
            => Assert.That(rectangle.CalculateVolume(), Is.EqualTo(0).Within(0.001));

        [Test]
        public void TestCylinderCalculateArea()
            => Assert.That(cylinder.CalculateArea(), Is.EqualTo(188.496).Within(0.001));

        [Test]
        public void TestCylinderCalculateVolume()
            => Assert.That(cylinder.CalculateVolume(), Is.EqualTo(197.920).Within(0.001));

        [Test]
        public void TestSphereZeroRadiusAreaIsZero()
        {
            var zeroSphere = new Sphere(0);
            Assert.That(zeroSphere.CalculateArea(), Is.EqualTo(0).Within(0.001));
        }

        [Test]
        public void TestCubeZeroSideVolumeIsZero()
        {
            var zeroCube = new Cube(0);
            Assert.That(zeroCube.CalculateVolume(), Is.EqualTo(0).Within(0.001));
        }

        [Test]
        public void TestCylinderDifferentDimensionsArea()
        {
            var cyl = new Cylinder(2, 10); 
            Assert.That(cyl.CalculateArea(), Is.EqualTo(150.796).Within(0.001));
        }
    }
}
