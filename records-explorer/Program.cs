var something = new Car{ Make = "Opel", Model="Ampera", Year=2003 };
var another = something with { Year = 2006 };
Console.WriteLine(another.Make); // Output: Opel
var x = 4;
var y = x + 5;
var z = y + 6;
Console.WriteLine("Appelsin"); // Output: Opel

var team = new Team("Real Madrid", "Spain");

public record Team(string Name, string Country);
