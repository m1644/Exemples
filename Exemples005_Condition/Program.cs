Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "max")
{
    Console.WriteLine("Ура, это же Max!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}