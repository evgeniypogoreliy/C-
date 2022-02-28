Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")  //ToLower переводит все буквы в нижний ригистр(принимает и маленьике и большие)
{
   Console.WriteLine("Ура, это же МАША"); 
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}