/*
int CountingNumber3Elements(string[] arrayCounting)
{
    int counter3Elements = 0;

    for (int i = 0; i < arrayCounting.Length; i++)
    {
        if (arrayCounting[i].Length <= 3) counter3Elements++;
    }

    return counter3Elements;
}

string[] CreateOneDimensionalArray(string[] arrayInitial)
{
    string[] array3Elements = new string[CountingNumber3Elements(arrayInitial)];

    int j = 0;

    for (int i = 0; i < arrayInitial.Length; i++)
    {
        if (arrayInitial[i].Length <= 3) array3Elements[j++] = arrayInitial[i];
    }

    return array3Elements;
}

string[][] CreateJaggedArray(string[] arrayNum0, string[] arrayNum1, string[] arrayNum2, int countRows)
{
    string[][] elements3JaggedArray = new string[countRows][];

    elements3JaggedArray[0] = CreateOneDimensionalArray(arrayNum0);
    elements3JaggedArray[1] = CreateOneDimensionalArray(arrayNum1);
    elements3JaggedArray[2] = CreateOneDimensionalArray(arrayNum2);

    return elements3JaggedArray;
}

void PrintJaggedArray(string[][] elements3PrintJaggedArray)
{
    for (int i = 0; i < elements3PrintJaggedArray.Length; i++)
    {
        if (elements3PrintJaggedArray[i].Length == 0) Console.Write("[]");

        for (int j = 0; j < elements3PrintJaggedArray[i].Length; j++)
        {
            if (elements3PrintJaggedArray[i].Length == 1) Console.Write($"[\"{elements3PrintJaggedArray[i][j]}\"]");
            else if (j == 0) Console.Write($"[\"{elements3PrintJaggedArray[i][j]}\",");
            else if (j == elements3PrintJaggedArray[i].Length - 1) Console.Write($"\"{elements3PrintJaggedArray[i][j]}\"]");
            else Console.Write($"{elements3PrintJaggedArray[i][j]},");
        }

        Console.WriteLine();
    }
}

int numberArrays = 3;

string[] array1 = { "hello", "2", "world", ":-)" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };

PrintJaggedArray(CreateJaggedArray(array1, array2, array3, numberArrays));
*/