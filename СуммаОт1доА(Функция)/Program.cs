// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


Console.WriteLine("Enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());

int Summ (int n)
{
    int s = default;
    for(int i = 1; i <= n; i++)
    {
        s = s + i;//s += i;
    }
    return s;
}

int result = Summ(num);
Console.WriteLine($"Сумма чисел от 1 до {num} = {result}");

