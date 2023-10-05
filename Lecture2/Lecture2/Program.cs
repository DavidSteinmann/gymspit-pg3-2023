
// Opakování z minula
Console.WriteLine("Enter password:");
string password = Console.ReadLine();

// Podmínka - password musí mít hodnotu "1234"
if (password == "1234") // Poznámka: toto není návod na ukládání hesel
{
    Console.WriteLine("You are the chosen one!");
}
else
{
    Console.WriteLine("Wrong password");
}


// Úkol: Zeptat se uživatele na jméno a vypsat:
// 'Hello, {jmeno}!'

Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine("Hello, " + name);


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






//// Úloha: zeptej se uživatele na číslo a vypiš postupně tolik čísel,
//// kolik je číslo, které zadal uživatel.
//// Uživatel má na zadání více pokusů.


// Vytvořím dopředu některé proměnné. Proč je musím vytvořit teď,
// si vysvětlíme v příštích hodinách
bool success = false;
int numIterations = 0;

// Cyklus, který se uživatele ptá dokud nezadá číslo
do
{
    Console.WriteLine("Enter a number:");
    // Vstup od uživatele do konzole je vždy string
    string numIterationsString = Console.ReadLine();

    numIterations = 0;
    // Převedu string na int speciální funkcí
    // Proměnná success říká, jestli konverze proběhla úspěšně
    // Klíčové slovo 'out' zatím neznáme, zatím jenom víme, že tam musí být
    success = int.TryParse(numIterationsString, out numIterations);
    Console.WriteLine("success = " + success);

    // !proměnná - znamená negace (jako v matematice)
    // !true = false, !false = true
} while (!success);

// Převedené číslo můžu použít
for (int i = 0; i < numIterations; i++)
{
    Console.WriteLine(i);
}
