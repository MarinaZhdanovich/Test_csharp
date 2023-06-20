string Method( int count, string text)
{
    int i = 0;
    string result = String.Empty; // будем сюда класть результат (или "")

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method(10, "hello");
Console.WriteLine(res);
