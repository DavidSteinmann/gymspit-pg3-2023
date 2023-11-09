
// Pomocí ref můžeme měnit původní proměnnou
int Sum(ref int y, int b, ref int d)
{
    y = 7;
    d = y - b;
    return y + b;
}

int a = 8;
int b = 6;
int d = 0;

Console.WriteLine(a);
Console.WriteLine(d);
int c = Sum(ref a, b, ref d);
// a má jinou hodnotu
Console.WriteLine(a);
Console.WriteLine(d);


// různé zbůsoby vytvoření pole
float[] floats = new float[10];
int[] ints = new int[] { 1, 2, 3 };
int[] intsEmpty = new int[10];


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }

    Console.WriteLine();
}

Console.WriteLine();

int[] numbers = { 1, 8, 42, 6 };
PrintArray(numbers);

Console.WriteLine();

// nemůžeme pole jen tak vypsat, je to složitější typ
Console.WriteLine(numbers);
// Prvky v poli se cisluji se cisluji od 0
Console.WriteLine(numbers[0]);
// Prvek s indexem 4 neexistuje, program spadne
Console.WriteLine(numbers[4]);



Console.WriteLine();

// Primitive typy se přiřazají hodnotou, kopírují se
int j = 4;
int q = j;
j = 6;

Console.WriteLine(j);
Console.WriteLine(q);



// Složitější typy se přiřazají referencí (odkazem / šipkou)
int[] numbers2 = numbers;
PrintArray(numbers);
PrintArray(numbers2);

// změna jednoho změní i druhý
numbers[0] = 6;
PrintArray(numbers);
PrintArray(numbers2);

// numbers2 je nyní nové pole, původní numbers se nezmění
numbers2 = new int[] { 6, 5, 4, 3, 2, 1};
PrintArray(numbers);
PrintArray(numbers2);


// Zvláštní chování polí jako argumentů
void ChangeFirst(ref int[] array, int newValue)
{
    array[0] = newValue;
    array = new int[] { 50, 40 };
}

ChangeFirst(ref numbers, 42);
PrintArray(numbers);

PrintArray(numbers2);



// Výpis libovolného polynomu
void PrintPolynomial(int[] coefficients)
{
    // 6x^5 + 4x^4 + 48x^3 + -4x^2 + 4x^1 + -1x^0 
    for (int i = 0; i < coefficients.Length; i++)
    {
        Console.Write(coefficients[i]);
        Console.Write("x^");
        Console.Write(coefficients.Length - i - 1);
        if (i < coefficients.Length - 1)
        {
            Console.Write(" + ");
        }
    }

    Console.WriteLine();
}

// Volání
int[] coefficients = new int[] { 6, 4, -1 };
PrintPolynomial(coefficients);

coefficients[1] = 444;
PrintPolynomial(coefficients);

coefficients = new int[] { 6, -18, 40, 4, -1 };
PrintPolynomial(coefficients);
