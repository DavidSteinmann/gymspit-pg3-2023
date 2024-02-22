class Character
{
    private int health;
    private int attack;

    public Controller controller;

    public Character(Controller controller, int health, int attack)
    {
        this.controller = controller;
        this.health = health;
        this.attack = attack;
    }

    public void DecreseHealth(int amount)
    {
        this.health -= amount;
    }

    public int GetAttack()
    {
        return this.attack;
    }

    public int GetHealth()
    {
        return this.health;
    }

    public bool IsAlive()
    {
        return this.health > 0;
    }
}