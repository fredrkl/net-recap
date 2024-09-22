var something = new Car{ Make = "Opel", Model="Ampera", Year=2003 };
var another = something with { Year = 2006 };
var x = 4;
var y = x + 5;
var z = y + 6;

var spain = new Country("Spain");
var madrid = new City("Madrid", spain);
var team = new Team("Real Madrid", madrid);

var barcelona = madrid with { Name = "Barcelona" };
var team2 = team with { Name = "FC Barcelona", city = barcelona }; // In this case it would be equaly easy to create a new team from scratch without using the with keyword. This is only for showcasing.

var anotherSpain = new Country("Spain");

Console.WriteLine($"Spain equal another record with same name: {spain == anotherSpain}");


public record Country(string Name); // Stored on the heap
public record struct City(string Name, Country Country); // Stored on the stack
public record struct Team(string Name, City city); // Stored on the stack
