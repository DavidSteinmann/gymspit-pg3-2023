
class AI : Character
{
    public AI(int health, int attack) : base(health, attack)
    {

    }

    public override string TakeTurn()
    {
        Random rnd = new Random();

        string[] choices = { "attack", "attack", "wait" };
        var randomIndex = rnd.Next(0, choices.Length);

        return choices[randomIndex];
    }
}
