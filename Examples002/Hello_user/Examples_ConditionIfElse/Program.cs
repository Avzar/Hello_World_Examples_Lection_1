Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "avzar")
{
    Console.WriteLine("!!! Hello Avzar!!!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}