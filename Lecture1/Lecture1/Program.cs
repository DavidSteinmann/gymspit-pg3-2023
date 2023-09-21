// See https://aka.ms/new-console-template for more information
using System.Xml.XPath;

Console.WriteLine("Hello, World!");

// Deklarace proměnné
int x;
x = 2;

int y = 3;


double procento = 0.42;

// Vypiš proměnné

/*
 Ahoj,
 jak se máš.
 Toto je víceřádkový komentář.
*/

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(procento);


string name = "David";

Console.WriteLine("Hello, " + name);
// To samé jako
Console.WriteLine("Hello, {0}", name);
// složené závorky - AltGr + B, AltGr + N



int number1 = 42;
int number2 = 24;

Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2);
Console.WriteLine("{0} - {1} = {2}", number1, number2, number1 - number2);
Console.WriteLine("{0} * {1} = {2}", number1, number2, number1 * number2);
// Dělení celých čísel vrátí celé číslo
Console.WriteLine("{0} / {1} = {2}", number1, number2, number1 / number2);
// To samé jako
Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
// $ - AltGr + ů

// Přiřaď výsledek do proměnné
int result = number1 / number2;

Console.WriteLine($"result = {result}");



// Desetinné číslo
double number3 = 42;
double number4 = 24;

// Dělení desetinných čísel vrátí desetinné číslo
Console.WriteLine($"{number3} / {number4} = {number3 / number4}");




double result2 = number3 / number4;
Console.WriteLine(result2);
// Přetypování proměnné (explicitní)
int result2Int = (int)result2;
Console.WriteLine(result2Int);

// Přetypování preměnné (implicitní)
double result2Double = result2Int;



bool bool1 = true;
bool bool2 = false;

//  & - AltGr + c
Console.WriteLine("{0} && {1} = {2}", bool1, bool2, bool1 && bool2);
//  | - vedle levého Shift nebo nad Enter
Console.WriteLine("{0} || {1} = {2}", bool1, bool2, bool1 || bool2);
Console.WriteLine("!{0} = {1}", bool1, !bool1);

Console.WriteLine((true && false) || true);


int cislo = 8;
Console.WriteLine("{0} == 7 -> {1}", cislo, cislo == 7);
bool isCisloCisloSeven = cislo == 7;
Console.WriteLine(isCisloCisloSeven);


Console.WriteLine("What's your name?");
string jmeno = Console.ReadLine();
Console.WriteLine($"Hello, {jmeno}!");



Console.WriteLine("Type a number");
string cisloOdUzivatele = Console.ReadLine();
int cisloProcessed;
bool success = int.TryParse(cisloOdUzivatele, out cisloProcessed);

Console.WriteLine($"success = {success}");
Console.WriteLine(cisloProcessed + 3);

if (success == true)
{
    Console.WriteLine("Spravne cislo");
}
else
{
    Console.WriteLine("Toto neni cislo");
}

