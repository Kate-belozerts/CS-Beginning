﻿//Написать программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//Например: a = 25, b = 5 -> да
//a = 2, b = 10 -> нет

Console.Clear();

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

int square = num2 * num2;
if(square == num1)
{
    Console.Write($"Число {num1} является квадратом {num2}");
}
else 
{
    Console.Write($"Число {num1} не является квадратом {num2}");
}


// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

// Console.Clear();
// Console.WriteLine("Enter the number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int square = num * num;
// Console.WriteLine($"квадрат числа {num} = {square}");
