
//Console.WriteLine("Enter password:");

string password = Console.ReadLine();

if (password == "1234")
{
    Console.WriteLine("You are the chosen one!");
}
else
{
    Console.WriteLine("Wrong password");
}

//// 'Hello, jmeno!'


//Console.WriteLine("What is your name?");
//string name = Console.ReadLine();
//Console.WriteLine("Hello, " + name);


Console.WriteLine("Cyklus for:");

// Cyklus for - udělej něco několikrát
for (int i = 0; i < 5; i = i + 1)
{
    // Proměnná i má číslo aktuální iterace (aktuálního cyklu)
    Console.WriteLine(i);
}

Console.WriteLine("Cyklus while:");

// Cyklus while - může být to samé jako for
int number = 0;
while (number < 5)
{
    Console.WriteLine(number);

    // Toto všechno jsou identické zápisy
    number = number + 1;
    //number += 1;
    //number++;
}


Console.WriteLine("Cyklus do while:");

// Nastavím si stejnou iterační proměnnou
int otherNumber = 0;
do
{
    // Cyklus vždy proběhne alespoň jednou
    Console.WriteLine(otherNumber);
    otherNumber = otherNumber + 1;

    // Podmínka se kontroluje až na konci
} while (otherNumber < 5);


bool success = false;
int numIterations = 0;
do
{
    Console.WriteLine("Enter a number:");
    // Vstup od uživatele je vždy string
    string numIterationsString = Console.ReadLine();

    numIterations = 0;
    // Převedu string na int speciální funkcí
    success = int.TryParse(numIterationsString, out numIterations);
    Console.WriteLine("success = " + success);

} while (!success);

// Převedené číslo můžu použít
for (int i = 0; i < numIterations; i = i + 1)
{
    Console.WriteLine(i);
}
