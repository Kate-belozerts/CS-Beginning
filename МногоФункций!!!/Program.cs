void FillArray(int[] collection)//метод, чтобы заполнить массив случайными числами
//FillArray - название метода, collection - название аргумента
{
    int length = collection.Length;//получаем длину массива
    int index = 0;
    while (index < length) //while TRUE
    {
        
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)//аргументы называть разными именами
//этот метод будет печатать массив
{
    int count = col.Length;
    int position = 0;//index
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int IndexOf(int[] collection, int find)//метод с возвратом целочисленного элемента - int (index)
{
    int count = collection.Length;//Определяем кол-во элементов
    int index = 0;
    int position = -1; //0 - не общее решение; а если -1, то все элементы, которые выходят за пределы будут иметь индекс -1(а любой массив начинается с 0)

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;//чтобы показывал индекс первого элемента       
        }
        index++;
    }
    return position;
}

int [] array = new int[10]; // new int - создай новый массив, в котором будет 10 элементов.
// по умолчанию он будет заполнен нулями

//void - не возвращает элементы! Соотв. нельзя тут использовать return

FillArray(array);
array[4] = 4;//принудительно добавим в массив пару четверок, чтобы их найти))
array[7] = 4;

PrintArray(array);
Console.WriteLine();//пустая строчка, чтобы быть уверенным,  что не является частью вывода массива

int pos = IndexOf(array, 4);//например ищем 4
Console.WriteLine(pos);

