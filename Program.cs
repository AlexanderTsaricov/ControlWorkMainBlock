using System.Globalization;

string[] GetStriingArray()
{
    Console.WriteLine("Введите слова массива через запятую");
    string enterWords = Console.ReadLine();
    string[] enterArray = enterWords.Split(',');
    return enterArray;
}

void PrintStringArray(string[] arr)
{
    foreach (string str in arr)
    {
        Console.Write($"{str} ");
    }
    Console.WriteLine();
}

string[] GetStringWordLess3Symbol(string[] enterArr)
{
    int lengthEndArr = 0;
    for (int i = 0; i < enterArr.Length; i++)
    {
        if (enterArr[i].Length <= 3)
        {
            lengthEndArr++;
        }
    }
    string[] endArray = new string[lengthEndArr];
    for (int i = 0, j = 0; i < enterArr.Length; i++)
    {
        if (enterArr[i].Length <= 3)
        {
            endArray[j] = enterArr[i];
            j++;
        }
    }
    return endArray;
}

string[] enterArray = GetStriingArray();
string[] endArray = GetStringWordLess3Symbol(enterArray);
PrintStringArray(endArray);