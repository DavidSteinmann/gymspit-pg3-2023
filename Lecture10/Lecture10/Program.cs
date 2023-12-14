
Random rand = new Random(123);

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



void BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            int left = array[j];
            int right = array[j + 1];

            // porovnani
            if (left > right)
            {
                // prohozeni
                array[j] = right;
                array[j + 1] = left;
            }
        }
    }
}

BubbleSort(unsorted);


Array.Sort(unsorted);

Console.WriteLine("vypis serazenyho pole");
for (int i = 0; i < unsorted.Length; i++)
{
    Console.WriteLine(unsorted[i]);
}

int cislo = 6;

switch (cislo)
{
    case 0:
        Console.WriteLine("ahoj");
        break;

    case 1:
    case 2:
        Console.WriteLine("ahojky");
        break;


    default:
        Console.WriteLine("default");
        break;
}

Console.WriteLine("continue? Y/n");


Console.WriteLine("jidelnicek:");
Console.WriteLine("1) jidlo 1");
Console.WriteLine("2) jidlo 2");





// Cteni ze souboru


string message = File.ReadAllText("soubor.txt");

Console.WriteLine("Message from file");
Console.WriteLine(message);




StreamWriter file = new StreamWriter("soubor.txt");
file.WriteLine("ahoj");
file.WriteLine("ahoj2");
file.WriteLine("ahoj3");
file.Close();



using (StreamWriter file3 = new StreamWriter("soubor.txt"))
{
    file3.WriteLine("ahoj");
    file3.WriteLine("ahoj2");
    file3.WriteLine("ahoj3");
}


StreamReader file2 = new StreamReader("soubor.txt");
string line1 = file2.ReadLine();
string line2 = file2.ReadLine();
file2.Close();

string jidla = File.ReadAllText("jidelnicek.txt");

Console.WriteLine(jidla);
