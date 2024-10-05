namespace recordsexplorer{

  public record Person
  {
    public Person(string name, int age)
    {
      Name = name;
      Age = age;
    }

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
<<<<<<< HEAD
      public Person? Person { get; set; }
      public List<Hobby> Hobbies { get; set; } = new List<Hobby>();

      PersonWithHobbies(Person p, List<Hobby> hobbies){
        Person = p;
        this.Hobbies = hobbies;
      }
=======
    public Person? Person { get; set; }
    public List<Hobby> Hobbies { get; set; } = new List<Hobby>();
>>>>>>> 875ebd2 (✨ (records): Investigating constructors)
  }
}
