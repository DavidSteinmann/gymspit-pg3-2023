
// Funkce FindMax

int FindMax(int[] array)
{
    // Tady je to problematické
    if (array.Length == 0)
    {
        return -1;
    }

    int max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }

    return max;
}

int FindMaxIndex(int[] array)
{
    if (array.Length == 0)
    {
        // Konvence, víme, že prvek na -1 pozici neexistuje 
        return -1;
    }

    int max = array[0];
    int maxIndex = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
            maxIndex = i;
        }
    }

    return maxIndex;
}

int[] array = new int[] { 1, 8, 16, -4, 1, 5 };

int maximum = FindMax(array);
int maximumIndex = FindMaxIndex(array);

Console.WriteLine($"Found maximum: {maximum} with index {maximumIndex}");


// Jednodussi vypis vsech prvku pres foreach
foreach (int num in array)
{
    Console.WriteLine(num);
}

Console.WriteLine();

static void GreetUser(string name = "default_user")
{
    Console.WriteLine("Hello, " + name + "!");
    GreetUser(name);
}

static void GreetTwoUsers(string user1, string user2)
{
    GreetUser(user1);
    GreetUser(user2);
}

int FindSumOfArray(int[] array, int firstI = 0)
{
    return 0;
}

GreetUser("Martin");
//GreetUser("John");

//GreetUser();

//Console.WriteLine("aaaa");
//GreetTwoUsers("Jack", "Josh");

int sum = FindSumOfArray(array, 2);




Console.WriteLine("type 1 for square");
Console.WriteLine("type 2 for rectangle");

int GetSelection(string[] options)
{
    
    // TODO

}

string[] options = new string[] { "square", "rectangle", "sphere" };

int userSelected = GetSelection(options);


switch (userSelected)
{
    case 1:
        PrintSquare();
        break;

    case 2:
        break;

    default:
        break;
}



// Nasleduje tip jak strukturovat program


int magic = 42;

static int GetNumber()
{

}

static int Discriminant(int a, int b, int c)
{

}

static void PrintEquation(int a, int b, int c)
{
    int discriminant = Discriminant(a, b, c);

    if (discriminant > 0)
    {

    }
}

static void Dosazuj(int a, int b, int c)
{

}

static bool ShouldContinue()
{
    string continueString = Console.ReadLine();
    if (continueString == "no")
    {
        return true;
    }

    return false;
}



while (true)
{
    int a = GetNumber();
    int b = GetNumber();
    int c = GetNumber();

    PrintEquation(a, b, c);

    Dosazuj(a, b, c);

    if (!ShouldContinue())
        break;
}







