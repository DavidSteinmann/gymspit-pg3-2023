
class AIController : Controller
{
    public AIController()
    {

    }

    public override string TakeTurn(Character first, Character second)
    {
        Random rnd = new Random();

        string[] choices = { "attack", "attack", "wait" };
        var randomIndex = rnd.Next(0, choices.Length);

        return choices[randomIndex];
    }
}
