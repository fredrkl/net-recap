using recordsexplorer;

namespace records_explorer.Tests;

public class RecordsTests
{
  [Fact]
  public void Test1()
  {
    var country = new Country("Spain");
    var hoby = new Hobby() { Name = "Soccer", HoursPerWeek = 10 };

    Assert.Equal("Spain", country.Name);
  }

  [Fact]
  public void Records_value_comparison()
  {
    // Arrange
    var country1 = new Country("Spain");
    var country2 = new Country("Spain");

    // Act
    var actual = country1 == country2;

    // Assert
    Assert.True(actual);
  }
  
  [Fact]
  public void Records_value_comparison2()
  {
    // Arrange
    var country1 = new Country("Spain");
    var country2 = new Country("Norway");

    // Act
    var actual = country1 == country2;

    // Assert
    Assert.False(actual);
  }
}
