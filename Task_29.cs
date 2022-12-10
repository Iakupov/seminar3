int[] Randomizer(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    int index = array.Length;
    Console.Write("{");
    for (int i = 0; i < index - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[index - 1] + "}");
    Console.WriteLine();
}
Console.WriteLine("Введите число n: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число min: ");
int Min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число max: ");
int Max = int.Parse(Console.ReadLine()!);
int[] ResultArray = Randomizer(N, Min, Max);
PrintArray(ResultArray);
