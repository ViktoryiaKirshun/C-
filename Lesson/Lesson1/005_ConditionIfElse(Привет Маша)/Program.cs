


Console.WriteLine("Ведите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() =="маша") //ToLower  переводит все символы в единый регистр
{
    Console.WriteLine("Ура! Это же Маша!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}