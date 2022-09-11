// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int CountDigit(int n)
{
    if (n != 0)
    {
        if (n < 0) n = n * (-1);//n = -n
        int count = default;
        while (n > 0)
        {
            n = n / 10;
            count++;
        }
        return count;
    }
    return 1;
}


int result = CountDigit(num);
Console.WriteLine(result);
