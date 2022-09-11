//Массив:

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//             0  1  2  3  4  5   6   7   8 - индексы
int[] array = { 1, 2, 3, 4, 5, 66, 89, 32, 4 };
array[0] = 12; //присвоить нулевому элементу значение 12

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(max);



//____________________________________________________________________________________________________________---
//Упорядочить данные внутри массива:

//Алгоритм сортировки методом выбора / алгоритм сортировки мин и макса / алгоритм выбора максимального и тд


int[] arr = { 1, 5, 7, 4, 8, 9, 4, 5, 6, 3 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}



void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)//Здесь ищем минимальный элемент
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];//Перемещаем по позициям. 3 переменные, что менять местами без потери данных элемента
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);

