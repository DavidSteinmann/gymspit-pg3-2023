
void PrintVector(float[] array)
{
    Console.Write("vector (");
    for (int i = 0; i < array.Length; i++)
    {
        float item = array[i];
        Console.Write(item);
        if (i != array.Length - 1)
        {
            Console.Write("; ");
        }
    }
    Console.WriteLine(")");
}


float[] ScaleVector(float[] vector, float scalar)
{
    float[] newVector = new float[vector.Length];

    for (int i = 0; i < vector.Length; i++)
    {
        newVector[i] = vector[i] * scalar;
    }

    return newVector;
}

float[] AddVector(float[] vector, float[] vector2)
{
    float[] newVector = new float[vector.Length];

    for (int i = 0; i < vector.Length; i++)
    {
        newVector[i] = vector[i] + vector2[i];
    }

    return newVector;
}



float[] myVector = new float[2];
myVector[0] = 10;
myVector[1] = 2;

float myScalar = -2.5f;


PrintVector(myVector);

float[] newVector = ScaleVector(myVector, myScalar);

PrintVector(newVector);





string name = "John";
name = "Adam";

Console.WriteLine(name[0]);

char[] letters = name.ToCharArray();
letters[0] = 'a';

string newName = new string(letters);


string ReplaceAWithStar(string text, char find, char replace)
{
    char[] letters = text.ToCharArray();
    for(int i = 0; i < letters.Length;i++)
    {
        if (letters[i] == find)
        {
            letters[i] = replace;
        }
    }

    string output = new string(letters);
    return output;
}

string text = "aabaHobbbbaaaaaaaabbbidiawdaaHHHHHHj9bbbbbaawda82abaa";

// 'a' -> '*'
string hiddenText = ReplaceAWithStar(text, 'a', '*');
//hiddenText = ReplaceAWithStar(hiddenText, 'b', '*');
//hiddenText = ReplaceAWithStar(hiddenText, 'H', '&');

// hiddenText = "***Hoidi*wd**j9**wd*82***"
Console.WriteLine(hiddenText);


string hidden = text.Replace("aa", "/");


Console.WriteLine(hidden);

double i = 10d/ 3d;
Console.WriteLine(i.ToString("N3"));

