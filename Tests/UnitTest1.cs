using Project;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Sum_TwoNumbers_ReturnsSum()
        {
            // Arrange
            var calculator = new Calculator();
            var a = 2;
            var b = 3;
            var expected = 5;

            // Act
            var result = calculator.Sum(a, b);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}