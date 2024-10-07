var x = 4;
var y = x + 5;
var z = y + 6;

var spain = new Country("Spain");
var madrid = new City("Madrid", spain);
var team = new Team("Real Madrid", madrid);

var barcelona = madrid with { Name = "Barcelona" };
var team2 = team with { Name = "FC Barcelona", city = barcelona }; // In this case it would be equaly easy to create a new team from scratch without using the with keyword. This is only for showcasing.

var anotherSpain = new Country("Spain");
var norway = anotherSpain with {Name = "Norway"};

Console.WriteLine($"Spain equal another record with same name: {spain == anotherSpain}"); // Returns true
Console.WriteLine($"Spain equal another record with same name: {spain == norway}"); // Returns false
Console.WriteLine($"The Barcelona team is {team2}"); // Returns Barcelona Team { Name = FC Barcelona, city = City { Name = Barcelona, Country = Country { Name = Spain } } }

//spain.Name = "Sweden"; // This will not compile because the property is init only

var person = new Person("John", "Doe");
var person2 = person;
recordsexplorer.Person person3 = new recordsexplorer.Person("John", 5);

Console.WriteLine($"Person equal another record with same name: {person == person2}"); // Returns true
Console.WriteLine($"Person equal another person with reference equal: {ReferenceEquals(person, person2)}"); // Returns true
Console.WriteLine($"Record person method example: {person3.PrintDetails()}"); // Returns Name: John, Age: 5

public record Country(string Name); // Stored on the heap
public record struct City(string Name, Country Country); // Stored on the stack
public record struct Team(string Name, City city); // Stored on the stack

public record Person(string FirstName, string LastName);
public record class Employee(string FirstName, string LastName, string EmployeeId) : Person(FirstName, LastName);

// Example of a record class
public record class Car()
{
    public string Make { get; set; } = string.Empty;
    public string Model { get; init; } = string.Empty;
    public int Year { get; init; } = 0;
}
