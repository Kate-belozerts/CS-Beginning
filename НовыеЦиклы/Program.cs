//Цикл FOR:

string Method444(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)//ключевое слово FOR; инициализация счетчика; проверка условия; инкремент
    {
        result = result + text;
    }
    return result;
}

string res = Method444(10, "z");
Console.WriteLine(res);


//Цикл в цикле:
//таблица умножения:


for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");//интерполяция строк
    }
    Console.WriteLine();//пустая строка - чтобы после каждого столбика переходил на новую строку
}


//Изменение текста:

//Найти символ можно так:
//qwerty  - считаем с ноля
//012345 => s[3] = r и т.д. 
string text =   "КОСМИ́ЧЕСКОЕ ПРОСТРА́НСТВО, космос (от греч. ϰόσμος – упорядоченность, красота; мироздание, включая Землю;"
                + "редко – небесный свод; в сов. терминологии синоним англ. outer space – внепланетное пространство), пространство,"
                + "простирающееся в основном за пределами атмосферы Земли.";

string Replace(string text, char old, char newV)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == old) result = result + $"{newV}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
//можно для других символов использовать этот же метод:
Console.WriteLine();//Добавим для красоты пустую строчку

newText = Replace(newText, 'k', 'K');
Console.WriteLine(newText);

