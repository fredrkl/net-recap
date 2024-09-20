namespace MyNamespace {

  public class Person
  {
      public string Name { get; init; } = "";
      public int Age { get; set; }
  }

  public class Hobby
  {
      public string Name { get; set; } = "";
      public int HoursPerWeek { get; set; }
  }

  public class PersonWithHobbies
  {
      public Person? Person { get; set; }
      public List<Hobby> Hobbies { get; set; } = new List<Hobby>();
  }
}
