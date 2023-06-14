/* Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
7 и 23.

14 -> нет 
46 -> нет 
161 -> да
*/

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

string Multiplicity(int number)
{
    string result = "нет";
    if (number % 7 == 0 && number % 23 == 0)
    {
        result = "да";
    }
    return result;
}


int num = InputNum("Enter a number: ");
string result = Multiplicity(num);

Console.WriteLine(result);

