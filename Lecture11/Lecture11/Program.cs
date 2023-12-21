
// Nacti vsechno najednou
string[] pokemons = File.ReadAllLines("pokedex.txt");

foreach (string pokemon in pokemons)
{
    Console.WriteLine(pokemon);
}

// Nacti postupne
// Stejny vystup
StreamReader reader = new StreamReader("pokedex.txt");
while (!reader.EndOfStream)
{
    string line = reader.ReadLine();
    Console.WriteLine(line);
}

// Dulezite zavrit reader, jinak bude soubor porad otevreny
reader.Close();


using (StreamReader using_reader = new StreamReader("pokedex.txt"))
{
    while (!using_reader.EndOfStream)
    {
        string line = using_reader.ReadLine();
        Console.WriteLine(line);
    }
}

Console.WriteLine();

if (File.Exists("favorite.txt"))
{
    string previousFavorite = File.ReadAllText("favorite.txt");
    Console.WriteLine("Your previous favorite pokemon was:");
    Console.WriteLine(previousFavorite);
}
else
{
    Console.WriteLine("You don't have a favorite pokemon");
}


// Zapis
Console.WriteLine("What's your new favorite pokemon?");
//string favorite = Console.ReadLine();
string favorite = "a";

File.WriteAllText("favorite.txt", favorite);

// Stejny zapis, ale stream
using (StreamWriter using_writer = new StreamWriter("favorite.txt"))
{
    using_writer.Write(favorite);
}


// ASCII tabulka
char myChar = (char)65;
Console.WriteLine(myChar);



string[] pokemonStats = File.ReadAllLines("pokedex.csv");
string longestName = "";

foreach (string pokemon in pokemonStats)
{
    string[] parts = pokemon.Split(',');
    Console.WriteLine($"Pokemon: {parts[1]}");
    Console.WriteLine($"  Type: {parts[2]}");
    Console.WriteLine($"  Health: {parts[5]}");

    if (parts[1].Length > longestName.Length)
    {
        longestName = parts[1];
    }
}

Console.WriteLine("Longes pokemon name is: " + longestName);
