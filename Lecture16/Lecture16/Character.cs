class Character
{
    private int health;
    private int attack;

    public Character(int health, int attack)
    {
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

    public virtual string TakeTurn()
    {
        return "";
    }
}