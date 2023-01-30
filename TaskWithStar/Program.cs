// Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками. (Пример см. презентацию)

Console.Clear();
Console.WriteLine("Какой высоты будет ёлочка? Введите цифру: ");
int height = int.Parse(Console.ReadLine()!);
Fir(height, ' ', '*');

void Fir(int level, char gap, char sim)
{
    int occ = 1;
    for (int i = 0; i < level; i++ )
    {
        int emp = level - 1;
        emp -= i;
        string space = string.Empty;
        string star = string.Empty;
        while (emp != 0)
        {
            space += gap;
            emp--;
        }
        for (int count = 1; count <= occ; count++)
        {
            star += sim;
        }
        Console.WriteLine($"{space}{star}");
        occ += 2;
    }
}