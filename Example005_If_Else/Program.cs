Console. WriteLine("Введите Ваше имя:");
string username = Console.ReadLine();

if(username.ToLower() == "ksenia")
{
    Console.WriteLine("Ура! Это же Ксюша!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}