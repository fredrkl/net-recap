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

  [Fact]
  public void Records_value_comparison3()
  {
    // Arrange
    var country1 = new Country("Spain");
    var country2 = country1 with { Name = "Spain" };

    // Act
    var actual = country1 == country2;

    // Assert
    Assert.True(actual);
  }

  [Fact]
  public void Records_value_comparison4()
  {
    // Arrange
    var country1 = new Country("Spain");
    var country2 = country1 with { Name = "Sweden" };

    // country1.Name = "Sweden"; // This is not allowed
    
    // Act
    var actual = country1 == country2;

    // Assert
    Assert.False(actual);
  }
}
