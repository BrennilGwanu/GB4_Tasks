//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void Main()
{
    Console.Clear();
    Console.WriteLine("Введите число: ");
    int number = int.Parse(Console.ReadLine()!);
    int result = Sum(number);
    Console.WriteLine(result);
}


int Sum(int N)
{
    int x = 0;
    for (int i = 1; N / i != 0; i *= 10)
    {
        x += N / i % 10;
    }
    return x;
}

Main();