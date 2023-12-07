
using System.Text.Json;
using System.Transactions;

int Fibonacci(int n)
{
    if (n == 1)
    {
        return 1;
    }
    if (n == 0)
    {
        return 0;
    }

    int x = Fibonacci(n - 1);
    int y = Fibonacci(n - 2);

    return x + y;
}


long Factorial(int f)
{
    if (f == 0)
    {
        return 1;
    }
    if (f == 1)
    {
        return 1;
    }

    long previous = Factorial(f - 1);
    return f * previous;
}


//Console.WriteLine(Fibonacci(10));

//Console.WriteLine(Factorial(12));

for (int i = 1; i < 16; i++)
{
    Console.WriteLine($"{i} : {Factorial(i)}");
}





// normal array
int[] numbers = new int[] { 5, 6, 88, 0, -1 };
//Console.WriteLine(numbers[0]);

// 2d array
int[,] tictactoe = new int[,] { { 1, 0, 2 },
                                { 2, 5, 7 },
                                { 8, 10, -4 },
                                { 9, -10, 74 },};


Console.WriteLine(tictactoe[0, 0]);

Console.WriteLine(tictactoe[1, 1]);
tictactoe[1, 1] = 42;
Console.WriteLine(tictactoe[1, 1]);

Console.WriteLine("vypis:");

// Vypis vsech pozic
for (int i = 0; i < tictactoe.GetLength(0); i++)
{
    for (int j = 0; j < tictactoe.GetLength(1); j++)
    {
        Console.WriteLine(tictactoe[i, j]);
    }
}

// jagged array
int[][] ticTacToePlus = new int[][]{new[] { 1, 0, 2 },
                                    new[] { 2, 3 },
                                    new[] { 8, 10, 3, 4 },
                                    new[] { 9 }};


Console.WriteLine(ticTacToePlus[0][0]);

Console.WriteLine(ticTacToePlus[2][1]);
ticTacToePlus[2][1] = 42;
Console.WriteLine(ticTacToePlus[2][1]);

ticTacToePlus[1] = new int[] { 5, 4, 3, 2, 1 }; 

Console.WriteLine("Length");
Console.WriteLine(ticTacToePlus.Length);

Console.WriteLine(ticTacToePlus[0].Length);





Random rand = new Random(123);

int nahoda = rand.Next();

//int nahoda = rand.Next(int.MinValue, int.MaxValue);
//float randomFloat = rand.NextSingle();
//double randomDouble = rand.NextDouble();
//long randomLong = rand.NextInt64();

Console.WriteLine("Random");
Console.WriteLine(nahoda);




int[] unsorted = new int[10];
for (int i = 0; i < unsorted.Length; i++)
{
    unsorted[i] = rand.Next(100);
}

Console.WriteLine("vypis pole");
for (int i = 0; i < unsorted.Length; i++)
{
    Console.WriteLine(unsorted[i]);
}

Array.Sort(unsorted);

Console.WriteLine("vypis serazenyho pole");
for (int i = 0; i < unsorted.Length; i++)
{
    Console.WriteLine(unsorted[i]);
}

