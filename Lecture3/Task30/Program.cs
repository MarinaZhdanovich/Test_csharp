void Method (string message, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(message);
        i++;
    }
}
Method("Текст", 4);
// Method(count: 4, message: "Hello");
