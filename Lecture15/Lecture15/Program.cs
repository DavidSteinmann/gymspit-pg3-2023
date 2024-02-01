
Cat garfield = new Cat("Garfield");
Dog bernard = new Dog("Bernard");
Animal john = new Animal("John", "duck");

garfield.Speak();
Animal garf = garfield;
garf.Speak();

garfield.SayHello();
garfield.Speak();

bernard.SayHello();
bernard.Speak();
bernard.Fetch();

john.SayHello();
john.Speak();

class Animal
{
    public string Name;
    public string Type;

    public Animal(string name, string type)
    {
        Name = name;
        Type = type;
    }

    public void SayHello()
    {
        Console.WriteLine($"Hello, I'm {Name}, I'm a {Type}.");
    }

    public virtual void Speak()
    {
        Console.WriteLine("Default speaking");
        Console.WriteLine("I don't know");
    }
}

class Dog : Animal
{
    public Dog(string name) : base(name, "dog")
    {
    }

    public void Speak()
    {
        Console.WriteLine("dog overriden speaking");
        Console.WriteLine("Bark");
    }

    public void Fetch()
    {
        Console.WriteLine("Fetching");
    }
}

class Bulldog : Dog
{
    public Bulldog(string name) : base(name)
    {
    }
}

class Cat : Animal
{
    public Cat(string name) : base(name, "cat")
    {
    }

    public override void Speak()
    {
        Console.WriteLine("cat overriden speaking");
        Console.WriteLine("Meow");
    }
}
























