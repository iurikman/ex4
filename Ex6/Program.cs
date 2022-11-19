Console.Write("Your name?");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("HI, I love you!");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}
