Console.Write("Введите количество элементов: ");
int size = int.Parse(Console.ReadLine()!);
string[] array = CreatArray(size);

string[] CreatArray(int size)
{
    string[] array = new string[size];
    string[] arrayNew = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент: ");
        array[i] = Console.ReadLine()!;
        if (array[i].Length <= 3)
        {
            arrayNew[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref arrayNew, count);
    return arrayNew;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
PrintArray(array);

