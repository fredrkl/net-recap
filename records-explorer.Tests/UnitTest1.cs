using recordsexplorer;

namespace records_explorer.Tests;

public class UnitTest1
{
  [Fact]
  public void Test1()
  {
    var country = new Country("Spain");
    var hoby = new Hobby() { Name = "Soccer", HoursPerWeek = 10 };

    Assert.Equal("Spain", country.Name);
  }

  [Fact]
  public void Test2()
  {
    // Arrange
    int expected = 1;

    // Act
    int actual = 1;

    // Assert
    Assert.Equal(expected, actual);
  }
}
