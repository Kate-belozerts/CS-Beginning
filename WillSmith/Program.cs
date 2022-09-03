Console.Write("Enter your name, pls ");
string username = Console.ReadLine();

if(username.ToLower() == "will smith") //ToLower - переводит всё на маленькие буквы. => по умолчанию тоже нужно ставить всё маленькими!
{
    Console.WriteLine("Wow, that's Will !!!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}
