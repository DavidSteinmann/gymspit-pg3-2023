
// Jednoduchý výpis textu do konzole
Console.WriteLine("Hello, World!");

// Toto je komentář
/*
 Toto je víceřádkový komentář.
 Druhý řádek.
 Třetí řádek...
*/


// Deklarace proměnné
int x;
// Přiřazení hodnoty do proměné (jedno =)
x = 2;

// Deklarace a přiřazení na jeden řádek
int y = 3;

// Proměnná s jiným typem
double procento = 0.42;

// Vypiš proměnné
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(procento);

// Proměnná typu string obsahuje text
string name = "David";

// Použitím + u string hodnoty spojí. (připojí jednu za druhou)
Console.WriteLine("Hello, " + name);
// To samé jako
Console.WriteLine("Hello, {0}", name); // Složené závorky - AltGr + B, AltGr + N




// Dvě číselné proměnné
int number1 = 42;
int number2 = 24;

Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2);
Console.WriteLine("{0} - {1} = {2}", number1, number2, number1 - number2);
Console.WriteLine("{0} * {1} = {2}", number1, number2, number1 * number2);

// Dělení celých čísel vrátí celé číslo
Console.WriteLine("{0} / {1} = {2}", number1, number2, number1 / number2);
// To samé jako
Console.WriteLine($"{number1} / {number2} = {number1 / number2}"); // $ - AltGr + ů

// Přiřaď výsledek do proměnné
int result = number1 / number2;

Console.WriteLine($"result = {result}");




// Desetinné číslo
double number3 = 42;
double number4 = 24;

// Dělení desetinných čísel vrátí desetinné číslo
Console.WriteLine($"{number3} / {number4} = {number3 / number4}");

// Přiřazení výsledku do nové proměnné
double result2 = number3 / number4;
Console.WriteLine(result2);

// Přetypování proměnné (explicitní)
int result2Int = (int)result2;
Console.WriteLine(result2Int);

// Přetypování preměnné (implicitní) - nemusím specifikovat
double result2Double = result2Int;




// Proměnné s logickou hodnotou
bool bool1 = true;
bool bool2 = false;

//  & - AltGr + c
Console.WriteLine("{0} && {1} = {2}", bool1, bool2, bool1 && bool2);
//  | - vedle levého Shift nebo nad Enter
Console.WriteLine("{0} || {1} = {2}", bool1, bool2, bool1 || bool2);
Console.WriteLine("!{0} = {1}", bool1, !bool1);

// Kombinování operací za sebou
Console.WriteLine((true && false) || true);


int cislo = 8;
// Pomocí == (dvě =) hodnoty porovnávám. Výsledek je bool
Console.WriteLine("{0} == 7 -> {1}", cislo, cislo == 7);

// Přiřazení výsledku porovnání do nové proměnné
bool isCisloCisloSeven = cislo == 7;
Console.WriteLine(isCisloCisloSeven);



Console.WriteLine("What's your name?");
// Získávání vstupu od uživatele
// Uživatel může napsat jakýkoliv text, proto typ string
string nameFromUser = Console.ReadLine();
Console.WriteLine($"Hello, {nameFromUser}!");



// Získání čísla od uživatele
Console.WriteLine("Type a number:");
// Text může být cokoliv (číslo, písmeno, věta, ...), pokud chceme s zadaným číslem počítat, musíme převést string na číslo
string cisloOdUzivatele = Console.ReadLine();

int cisloProcessed;
// Převod textu na číslo
bool success = int.TryParse(cisloOdUzivatele, out cisloProcessed);

// Pro převod na např desetinné číslo pouze změním typ
// double.TryParse(...)

Console.WriteLine($"success = {success}");
// S novým číslem můžu dělat matematické operace
Console.WriteLine(cisloProcessed + 3);


// Kód se může větvit, větev se zvolí podle podmínky
if (success) // To samé jako (success == true), protože proměnná success má sama o sobě hodnotu true/false
{
    // Tento kód proběhne, pokud byla podmínka pravda (true)
    Console.WriteLine("Vstup byl číslo");
}
else
{
    // Tento kód proběhne, pokud byla podmínka nepravda (false)
    Console.WriteLine("Toto není číslo!");
}


// Na konci souboru program skončí
