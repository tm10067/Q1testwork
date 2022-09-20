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
    foreach (string i in array)
    {
        if (i.Length <= filterLength) newArrayLength++; 
    }
    string[] newArray = new string[newArrayLength];
    for (int j = 0, k = 0; j < array.Length; j++)
    {
        string element = array[j];
        if (element.Length <= filterLength)
        {
            newArray[k] = array[j];
            k++;
        } 
    }
    return newArray;
}