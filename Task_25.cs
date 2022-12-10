int Power(int FirstNumber, int SecondNumber)
{
    int Result = FirstNumber;
    for (int i = 1; i < SecondNumber; i++)
    {
        Result = Result * FirstNumber;
    }
    return Result;
}
Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine(A + " в степени " + B + " = " + Power(A, B));
