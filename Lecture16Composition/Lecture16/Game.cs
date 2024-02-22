
class Game
{
    private Character player1;
    private Character player2;

    public Game(Character player1, Character player2)
    {
        this.player1 = player1;
        this.player2 = player2;
    }

    private void PrintState()
    {
        Console.WriteLine($"player1: health={player1.GetHealth()}, attack={player1.GetAttack()}");
        Console.WriteLine($"player2: health={player2.GetHealth()}, attack={player2.GetAttack()}");
    }

    public void PlayGame()
    {
        Console.WriteLine("Let the game begin!");
        PrintState();

        while (true)
        {
            ///// PLAYER 1

            Console.WriteLine("Player 1 takes their turn");
            string result = player1.controller.TakeTurn(player1, player2);
            Console.WriteLine($"Player 1 plays {result}");

            switch (result)
            {
                case "attack":
                    player2.DecreseHealth(player1.GetAttack());
                    break;

                case "wait":
                    break;
            }

            PrintState();

            if (!player2.IsAlive())
            {
                Console.WriteLine("Player1 wins!");
                return;
            }



            ///// PLAYER 2

            Console.WriteLine("Player 2 takes their turn");
            string result2 = player2.controller.TakeTurn(player2, player1);
            Console.WriteLine($"Player 2 plays {result2}");

            switch (result2)
            {
                case "attack":
                    player1.DecreseHealth(player2.GetAttack());
                    break;

                case "wait":
                    break;
            }

            PrintState();

            if (!player1.IsAlive())
            {
                Console.WriteLine("Player2 wins!");
                return;
            }

            Console.WriteLine();
        }
    }
}