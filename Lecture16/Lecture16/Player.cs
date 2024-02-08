
class Player : Character
{
    public Player(int health, int attack) : base(health, attack)
    {

    }

    public override string TakeTurn()
    {
        Console.WriteLine("What do you want to play? 'a' - attack, 'w' - wait");

        string response = Console.ReadLine();
        switch (response)
        {
            case "a":
                return "attack";

            case "w":
                return "wait";
        }

        Console.WriteLine("Invalid move, playing 'wait'");
        return "wait";
    }
}
