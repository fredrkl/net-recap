var something = new Car{ Make = "Opel", Model="Ampera", Year=2003 };
var another = something with { Year = 2006 };
Console.WriteLine(another.Make); // Output: Opel
var x = 4;
var y = x + 5;
var z = y + 6;
Console.WriteLine("Appelsin"); // Output: Opel

var spain = new Country("Spain");
var madrid = new City("Madrid", spain);
var team = new Team("Real Madrid", madrid);

var barcelona = madrid with { Name = "Barcelona" };



public record struct Country(string Name); // Stored on the stack
public record struct City(string Name, Country Country); // Stored on the stack
public record struct Team(string Name, City city); // Stored on the stack
