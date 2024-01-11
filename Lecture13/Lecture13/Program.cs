
internal class Program
{
    private static int Sum(int a, int b)
    {
        return a + b;
    }

    private static void Main(string[] args)
    {
        foreach (var argument in args)
        {
            Console.WriteLine(argument);
        }

        int soucet = Sum(3, 6);

        Person person = new Person("Test Test");
        person.NumFingers = 1;
        person.Address = "Spitalska 2";
        person.Height = 1.80f;

        Person person2 = new Person("Martin Novak");

        Person[] people = new Person[4];

        people[0] = person;
        people[1] = person2;

        people[0].PrintPerson();
        people[1].PrintPerson();


        Car myCar = new Car();
        myCar.Model = "Fiat Multipla";
        myCar.Color = "Pink";

        Console.WriteLine(myCar.Model);

        Car myCar2 = myCar;
        myCar2.Model = "Skoda";

        Console.WriteLine(myCar.Model);


        int a = 2;
        int b = a;
        b = 4;

        myCar.Start();
        myCar.PrintState();

        myCar.GetGoing();
        myCar.PrintState();

        myCar.Accelerate(-5);
        myCar.PrintState();

        myCar.SlowDown();
        myCar.PrintState();

        myCar.SlowDown();
        myCar.PrintState();

        myCar.SlowDown();
        myCar.PrintState();

        myCar.SlowDown();
        myCar.PrintState();

        myCar.StopGoing();
        myCar.PrintState();

        myCar.ShutDown();
        myCar.PrintState();


        int mojeCislo = 3;
        float mojeCislo2 = 2.2f;
    }
}