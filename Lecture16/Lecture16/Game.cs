
class Game
{
    private Character player1;
    private Character player2;

    public Game(Character player1, Character player2)
    {
        this.player1 = player1;
        this.player2 = player2;
    }

    public void PlayGame()
    {
        while (true)
        {
            string result = player1.TakeTurn();

            switch (result)
            {
                case "attack":
                    player2.DecreseHealth(player1.GetAttack());
                    break;

                case "wait":
                    break;
            }

            if (!player2.IsAlive())
            {
                Console.WriteLine("Player1 wins!");
                return;
            }


            string result2 = player2.TakeTurn();

            switch (result2)
            {
                case "attack":
                    player1.DecreseHealth(player2.GetAttack());
                    break;

                case "wait":
                    break;
            }

            if (!player1.IsAlive())
            {
                Console.WriteLine("Player2 wins!");
                return;
            }
        }
    }
}