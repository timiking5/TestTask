using TestTask;

namespace TriangleTests
{
    public class TriangleTests
    {
        [Fact]
        public void DetermineTriangleType_ShouldReturnObtuseAngled()
        {
            // Arrange

            double a = 9, b = 5, c = 6;
            TriangleTypeEnum expected = TriangleTypeEnum.ObtuseAngled;
            // Act

            TriangleTypeEnum actual = TriangleMethods.DetermineTriangleType(a, b, c);

            // Assert

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DetermineTriangleType_ShouldReturnAcuteAngled()
        {
            // Arrange

            double a = 4, b = 3, c = 3;
            TriangleTypeEnum expected = TriangleTypeEnum.AcuteAngled;
            // Act

            TriangleTypeEnum actual = TriangleMethods.DetermineTriangleType(a, b, c);

            // Assert

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DetermineTriangleType_ShouldReturnSquareAngled()
        {
            // Arrange

            double a = 4, b = 3, c = 5;
            TriangleTypeEnum expected = TriangleTypeEnum.SquareAngled;
            // Act

            TriangleTypeEnum actual = TriangleMethods.DetermineTriangleType(a, b, c);

            // Assert

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DetermineTriangleType_ShouldThrowArgumentException()
        {
            // Arrange
            double a = 1, b = 1, c = 4;

            // Act && Arrange

            Assert.Throws<ArgumentException>(() => TriangleMethods.DetermineTriangleType(a, b, c));
        }
    }
}