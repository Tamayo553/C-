Console.Write("Введите ваше имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "nikita")
{
    Console.Write("Увуф вы вернулись госпадин ");
    Console.Write(username);
}
else
{
    Console.Write("Ну привет ");
    Console.Write(username);
}