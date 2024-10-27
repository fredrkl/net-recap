public record class Fruit(string Name, string Color, int Size);
public record class Apple(string Name, string Color, int Size, bool ripe) : Fruit(Name, Color, Size);
