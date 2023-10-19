

Console.WriteLine("Hello World");

// Opakování syntaxe
bool success1 = false;

if (success1)
{
    Console.WriteLine("Hello success");
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Hello for");
}

while (false)
{

}

int x = 2;
bool isseven = x == 7;

// if   else if     else
if (x == 7)
{
    Console.WriteLine("x je 7");
}
else if (x > 5)
{
    Console.WriteLine("x je vetsi nez 5");
}
else
{
    Console.WriteLine("nic");
}


string operation1 = "/";

//if (operation == "+")
//{
//    Console.WriteLine("scitani");
//}
//else if (operation == "-")
//{
//    Console.WriteLine("odcitani");
//}
//else if (operation == "*")
//{
//    Console.WriteLine("nasobeni");
//}

// příkaz switch - to samé jako několik if  else if
switch (operation1)
{
    case "+":
        Console.WriteLine("scitani");
        break;

    case "-":
        Console.WriteLine("odcitani");
        break;

    case "*":
        Console.WriteLine("nasobeni");
        break;

    case "/":
        Console.WriteLine("deleni");
        break;
}




int hledanySoucet = 100;

int soucet = 0;

// Příkazy continue, break
for (int i = 1; i <= 20; i++)
{
    Console.WriteLine($"current number is: {i}");

    if (i == 7)
    {
        Console.WriteLine($"i don't like this number");
        // continue pokračuje další iterací
        continue;
    }
    else if (i == 8)
    {
        Console.WriteLine($"i don't like this number");
        continue;
    }

    Console.WriteLine($"adding: {i} to sum");
    soucet += i;

    if (soucet >= hledanySoucet)
    {
        Console.WriteLine($"last number was: {i}");
        // break ukončí okamžitě cyklus
        break;
    }
}


Console.WriteLine(soucet);





// Možné řešení kalkulačky. Vaše řešení bude určitě jiné

while (true)
{
    bool success = false;

    Console.WriteLine("enter first");
    string userInput1 = Console.ReadLine();
    int firstNum;
    success = int.TryParse(userInput1, out firstNum);

    if (userInput1 == "exit")
    {
        break;
    }

    if (success == false)
    {
        continue;
    }

    int secondNum = 0;
    string userInput2;
    do
    {
        Console.WriteLine("enter second");
        userInput2 = Console.ReadLine();
        if (userInput2 == "exit")
        {
            break;
        }    

        success = int.TryParse(userInput2, out secondNum);
    } while (success == false);

    if (userInput2 == "exit")
    {
        break;
    }

    Console.WriteLine("Enter operation");
    string operation = Console.ReadLine();

    // Kód se nezeptá na operaci několikrát.
    // Dělalo by cyklem se podobně jako s čísly

    if (operation != "+" &&  operation != "-" && operation != "*" && operation != "/" && operation != "^")
    {
        continue;
    }


    switch (operation)
    {
        case "+":
            Console.WriteLine($"{firstNum} + {secondNum} = {firstNum + secondNum}");
            break;
        case "-":
            Console.WriteLine($"{firstNum} - {secondNum} = {firstNum - secondNum}");
            break;
        case "*":
            Console.WriteLine($"{firstNum} * {secondNum} = {firstNum * secondNum}");
            break;
        case "/":
            Console.WriteLine($"{firstNum} / {secondNum} = {firstNum / secondNum}");
            break;
        case "^":
            Console.WriteLine($"{firstNum} ^ {secondNum} = {Math.Pow(firstNum, secondNum)}");
            break;
    }

    Console.WriteLine("Do you want to exit? type 'yes'");
    string shouldExit = Console.ReadLine();
    if (shouldExit == "yes")
    {
        break;
    }

}


