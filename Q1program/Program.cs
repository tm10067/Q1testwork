string[] array = CreateArray();
Console.WriteLine("Исходный массив:");
Console.WriteLine(String.Join(", ", array));
int filterLength = 3;
string[] newArray = FilterArray(array, filterLength);
Console.WriteLine($"Выходной массив при выборке элементов длиной не более {filterLength} знаков:");
Console.WriteLine(String.Join(", ", newArray));

string[] CreateArray()
{
    Console.Write("Введите длину исходного массива: ");
    int arrayLength = int.Parse(Console.ReadLine());
    string[] array = new string[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        array[i] = Console.ReadLine();
    } 
    return array;
}

string[] FilterArray(string[] array, int filterLength)
{
    int newArrayLength = 0;
    string[] newArray = new string[array.Length];
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= filterLength)
        {
            newArray[newArrayLength] = array[j];
            newArrayLength++;
        } 
    }
    Array.Resize(ref newArray, newArrayLength);
    return newArray;
}