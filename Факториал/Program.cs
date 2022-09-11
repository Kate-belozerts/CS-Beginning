// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());

int Multi(int n)
{
    if (n != 0)
    {
        if (n < 0) n = -n;
        int s = 1;
        for (int i = 1; i <= n; i++)
        {
            s *= i;// sum = sum + 1;
        }
        return s;
    }
    return 1;
}

int result = Multi(num);
Console.WriteLine($"Факториал чила {num}! = {result}");



//____________________________________________________________________________________________________________-
// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Clear();

int[] arr = new int[8];

void FillArray(int[] array)
{
    int count = array.Length;
    Random rnd = new Random();//нужно вынести за пределы цикла, тк скорость процессора очень высокая, а числа выбираются в единицу времени => все цифры будут одинаковые, например все единицы
    for (int i = 0; i < count; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");    
    for (int i = 0; i < count; i++)
    {
        if (i == count - 1) Console.Write($"{array[i]}]");
        else Console.Write($"{array[i]}, ");
    }
}

FillArray(arr);
PrintArray(arr);

