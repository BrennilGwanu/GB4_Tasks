// Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать библиотеку Math!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



int Involute(int n, int count)
{
    int res = 1;
    for (int i = 1; i <= count; i++)
    {
        res *= n;
    }
    return res;
}

void Main()
{
    Console.Clear();
    Console.WriteLine("Введите число: ");
    int A = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите степень: ");
    int B = int.Parse(Console.ReadLine()!);
    int x = Involute(A, B);
    Console.WriteLine($"{x}");
}

Main();