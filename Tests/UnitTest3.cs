using Microsoft.EntityFrameworkCore;
using Project;

namespace Tests
{
    public class UnitTest3
    {
        [Fact]
        public void Search_ValidTerm_ReturnsResults()
        {
            // Arrange
            var context = new SampleDbContext();
            var searcher = new DataSearcher(context);
            var term = "example";
            var expectedResults = new List<Customer> { new Customer { Name = "example 1" }, new Customer { Name = "example 2" } };

            // Act
            var results = searcher.Search(term);

            // Assert
            Assert.All(expectedResults, (expected, i) => Assert.Equal(expected.Name, results[i].Name));
        }
    }
}