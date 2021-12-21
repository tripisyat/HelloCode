System.Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    System.Console.WriteLine("Ура! Это же МАША!");
}
else
{
    System.Console.WriteLine("Привет, " + username);
}