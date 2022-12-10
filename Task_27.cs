int Sum(int num)
{
    int count = 0;
    int ostatok = 1;
    int sum = 0;
    while (ostatok > 0)
    {
        ostatok = num / ((int)Math.Pow(10, count));
        sum = sum + (num / (int)Math.Pow(10, count)) - (num / ((int)Math.Pow(10, count + 1)) * 10);
        count++;
    }
    return sum;
}
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Сумма цифр числа равна: " + Sum(number));
