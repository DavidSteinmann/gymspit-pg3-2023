
int[] myNumbers = { 1, 2, 3 };
Console.WriteLine(myNumbers[1]);

//Console.WriteLine(myNumbers[10]);


int Divide(int a, int b)
{
    if (b == 0)
    {
        throw new Exception("b cannot be 0");
    }

    if (a == 7)
    {
        throw new InvalidDataException("a is no valid");
    }

    return a / b;
}

Console.WriteLine("Start");

// try-catch block - můžeme zachytit výjimky
try
{
    // Normální cesta běhu kódu
    int result = Divide(7, 0);
    Console.WriteLine(result);
}
// Pokud kód v try bloku hodí výjimku, zavolá se příslušný catch blok
// Zde odchytáváme pouze InvalidDataException
catch (InvalidDataException e)
{
    // V proměnné e máme výjimku
    Console.WriteLine("ERROR INVALID DATA. exception was:");
    Console.WriteLine(e);
}
// Zde odchytáváme všechny druhy výjimek, Exception je nadřazená všem
catch (Exception e)
{
    // V proměnné e máme výjimku
    Console.WriteLine("ERROR, exception was:");
    Console.WriteLine(e);
}

// Po try-catch bloku pokračuje kód normálně
Console.WriteLine("End");

/*
Console.WriteLine("Enter path");
string path = Console.ReadLine();
try
{
    string contents = File.ReadAllText(path);
    Console.WriteLine(contents);
}
catch (Exception e)
{
    Console.WriteLine("File does not exist");
}
*/

static string GetPathFromUser()
{
    Console.WriteLine("Enter path");
    string path = Console.ReadLine();
    return path;
}

static void PrintErrorMessage()
{
    Console.WriteLine("File does not exist");
}

static string GetFileContents(string path)
{
    return File.ReadAllText(path);
}

static void PrintFileContents(string path)
{
    try
    {
        string contents = GetFileContents(path);
        Console.WriteLine(contents);
    }
    catch (Exception e)
    {
        PrintErrorMessage();
    }
}

static void UserReadFile()
{
    string path = GetPathFromUser();

    PrintFileContents(path);
}


UserReadFile();

