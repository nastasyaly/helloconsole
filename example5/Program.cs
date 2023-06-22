Console.Write("Введите имя пользователя");
string username = Console.ReadLine ();

if(username.ToLower() == "Настасья")
{
    Console.WriteLine("Ура, Настасья!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}