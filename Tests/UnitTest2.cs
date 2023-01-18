using Project;

namespace Tests
{
    public class UnitTest2
    {
        [Fact]
        public void IsAdmin_AdminUser_ReturnsTrue()
        {
            // Arrange
            var user = new User { Role = "admin" };
            var validator = new UserValidator();

            // Act
            var result = validator.IsAdmin(user);

            // Assert
            Assert.True(result);
        }
    }
}