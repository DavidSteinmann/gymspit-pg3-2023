
Character ai1 = new AI(200, 10);
Character ai2 = new AI(250, 8);

Game aiGame = new Game(ai1, ai2);
Console.WriteLine("playing ai game");
aiGame.PlayGame();
Console.WriteLine("end of ai game");



Character me = new Player(100, 20);
Character r2d2 = new AI(50, 25);

Game myGame = new Game(me, r2d2);

myGame.PlayGame();
