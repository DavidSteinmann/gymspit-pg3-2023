
// deklarace funkce
float AddOne(float x)
{
    // tělo funkce
    // return -> vrací hodnotu funkce
    return x * x + 1;
}

// funkce bez výstupu
void PrintNumber(float number)
{
    // ve funkci může být cokoliv
    Console.WriteLine(number);
}

float x = 3.14f;
// volání funkce s parametrem
float y = AddOne(x);
Console.WriteLine(y);

PrintNumber(4.20f);


// funkce se složitějším tělem
float Maximum(float x, float y)
{
    if (x > y)
    {
        Console.WriteLine("x je vetsi");
        return x;
    }
    else
    {
        return y;
    }
}

// volání a výpis
Console.WriteLine(Maximum(6, 4));


// funkce s výstupem typu bool
bool AreSame(float x, float y)
{
    if (x == y)
    {
        return true;
    }
    else
    {
        return false;
    }
}

// funkce bez parametrů
int UltimateAnswer()
{
    return 42;
}

// funkce bez parametrů a výstupní hodnoty
void Hello()
{
    Console.WriteLine("Hello world!");
}

// volání
Hello();


// funkce co získává vstup od uživatele
string VstupOdUzivatele()
{
    Console.WriteLine("How do you feel?");
    string input = Console.ReadLine();
    return input;
}

string vstup = VstupOdUzivatele();


// funkce co získává vstup od uživatele
// a převede na int
int CisloOdUzivatele(string hint)
{
    // Funkce samotná se stará o převod čísel
    Console.WriteLine($"Enter number {hint}:");
    string input = Console.ReadLine();
    int x = int.Parse(input);
    return x;
}


// Při volání funkce už převod neřeším
int cislo = CisloOdUzivatele("a");
// funkci můžu zavolat kolikrát chci s jinými parametry
int cislo2 = CisloOdUzivatele("b");
int cisl3 = CisloOdUzivatele("c");
int cislo4 = CisloOdUzivatele("d");
int cislo5 = CisloOdUzivatele("e");

Console.WriteLine(cislo);
// jelikož je výstup číslo, můžu s ním počítat
Console.WriteLine(cislo * 2);


// funkce z knihovny Math pro počítání odmocniny
double result = Math.Sqrt(4);
Console.WriteLine(result);
