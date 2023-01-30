//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void Main()
{
    Console.Clear();
    Console.WriteLine("Введите восемь чисел (через пробел): ");
    string number = Console.ReadLine()!;
    int[] ei_array = CreateArray(number, ' ');
    PrintArray(ei_array);
}

int[] CreateArray(string list, char cut)
{
    list += cut;
    string sim = string.Empty;
    int serial = 0;
    int[] array = new int[8];
    for (int i = 0; i < list.Length; i++)
    {
        if (list[i] == cut)
        { 
            int number = int.Parse(sim);
            array[serial] = number;
            serial++; 
            sim = string.Empty;
        }
       else 
       {
            sim += list[i];
       }
    }
    return array;
}

void PrintArray(int[] imp)
{
    string print = string.Empty;
    for (int index = 0; index < imp.Length; index++)
    {
        print += imp[index];
        if (index < imp.Length-1) print += ", ";    
    }
    Console.WriteLine($"[{print}]");
}

Main();

// Не уверена, что выполнила правильно, потому что не до конца поняла условие, даже после просмотра объяснения на записи семинара



