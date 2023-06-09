Console.Write("Enter your name: ");
string username = Console.ReadLine()!;
if (username.ToLower() == "Marina")
{
    Console.WriteLine("This is Marina!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}