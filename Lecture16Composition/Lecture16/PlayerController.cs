
class PlayerController : Controller
{
    public PlayerController()
    {

    }

    public override string TakeTurn(Character first, Character second)
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
