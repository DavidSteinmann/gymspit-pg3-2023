

class Person
{
    public string Name;
    public string BirthDate;
    public int RodneCislo;
    public string Address;
    public int NumFingers;
    public string Gender;
    public float Height;

    public void PrintPerson()
    {
        Console.WriteLine(Name);
        Console.WriteLine(Address);
        Console.WriteLine(NumFingers);
        Console.WriteLine(Gender);
        Console.WriteLine(Height);
        Console.WriteLine(RodneCislo);
        Console.WriteLine(BirthDate);
    }

    public Person(string name)
    {
        Name = name;
        Console.WriteLine("Creating person");
    }
}
