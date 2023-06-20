string Method( int count, string text)
{
    string result = String.Empty; // будем сюда класть результат (или "")
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method(7, "mya");
Console.WriteLine(res);