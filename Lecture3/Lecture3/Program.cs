
// Operátor modulo (zbytek po dělení)
Console.WriteLine(5 % 3);
Console.WriteLine(6 % 2);
Console.WriteLine(9 % 8);


// Výpis modulo
for (int i = 0; i <= 20; i++)
{
    // Metoda (funkce) Console.Write(...) neodřádkuje výstup
    Console.Write(i);
    Console.Write(" ");
    Console.WriteLine(i % 3);
}

// Jiný způsob s použitím jiného cyklu
int max = 20;
int number = 0;
do
{
    Console.Write(number);
    Console.Write(" ");
    Console.WriteLine(number % 3);

    number++;

} while (number < max);



// Jiný způsob s použitím jiného cyklu bez modulo
int num1 = 0;
int num2 = 0;
do
{
    Console.Write(num1);
    Console.Write(" ");
    Console.WriteLine(num2);

    num1++;
    if (num2 != 2) num2++;
    else num2 = 0;

} while (num1 < 20);




// Úloha: Fizz Buzz
// Program vypisuje postupně čísla od 1 do x (např. do 20)
// Pokud je číslo dělitelné bezezbytku 3, vypíše Fizz.
// Pokud je číslo dělitelné bezezbytku 5, vypíše Buzz.
// Pokud je ale dělitelné bezezbztku 3 a 5 zároveň, vypíše FizzBuzz.

for (int i = 1; i <= 50; i++)
{
    // Složená podmínka
    if ((i % 3 == 0) && (i % 5 == 0))
    {
        int n = 0;
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        double n = 0;
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        string n = "";
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}


// Existence proměnných
// Proměnná existuje ve své úrovni a ve všemi úrovněmi pod ní,
// ale ne nad ní.
// Úroveň se určuje podle složených závorek.
// Všimněte si odřádkování, napovídá o existenci

int x = 0;
if (true)
{
    // x zde existuje
    Console.WriteLine(x);

    int y = 2;

    if (true)
    {
        // x zde existuje
        Console.WriteLine(x);
        //y zde existuje
        Console.WriteLine(y);

        int z = 0;
    }

    // z zde neexistuje
    // Console.WriteLine(z);

    if (true)
    {
        // z zde neexistuje, mohu udělat nové
        double z = 0;
    }

    if (true)
    {
        // z zde neexistuje, mohu udělat nové
        string z = "";
    }

    if (true)
    {
        // z zde neexistuje, mohu udělat nové
        bool z = false;
    }

    // z zde neexistuje
}

// x zde existuje
Console.WriteLine(x);

// y zde neexistuje, její platnost zkončila
// Console.WriteLine(y);

// z zde neexistuje






// Úloha: Jednoduchá kalkulačka
// Program se zeptá postupně na dvě čísla a operaci (+, -, *, /, ^, %)
// Vypíše výsledek operace na zadaných číslech
//
// Zlepšení 1: Uživatel má více pokusů na zadání čísel.
// Zlepšení 2: Uživatel má více pokusů na zadání operace.



