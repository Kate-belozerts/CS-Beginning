//"чистит консоль"
// Console.SetCursorPosition(10, 4);//отступ от левого края - 10, от верхнего - 4 символа(нулевая строка,1,2,3 и на 4й будет +)
// Console.WriteLine("+");//рисуем плюсиками)
Console.Clear(); 

int xa = 40; 
int ya = 1;
int xb = 1; 
int yb = 30;
int xc = 80; 
int yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa;
int y = xb;

int count = 0;

while(count < 10000)
{
    int what = new Random().Next(0, 3); //0, 1, 2
    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1; // count = count + 1 // count +=1 //count++ 
}
