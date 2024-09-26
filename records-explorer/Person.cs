namespace recordsexplorer{

  public record Person
  {
      public string Name { get; init; } = "";
      public int Age { get; set; }
  }

  public record Hobby
  {
      public string Name { get; set; } = "";
      public int HoursPerWeek { get; set; }
  }

  public record PersonWithHobbies
  {
      public Person? Person { get; set; }
      public List<Hobby> Hobbies { get; set; } = new List<Hobby>();

      PersonWithHobbies(Person p, List<Hobby> hobbies){
        Person = p;
        this.Hobbies = hobbies;
      }
  }
}
