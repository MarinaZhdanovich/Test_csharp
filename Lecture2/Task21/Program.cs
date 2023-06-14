/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления.  
34, 5 -> не кратно, остаток 4  16, 4 -> кратно
*/

Console.Write("Enter number A: ");
int numberA = int.Parse(Console.ReadLine()!);

Console.Write("Enter number B: ");
int numberB = int.Parse(Console.ReadLine()!);


void DelDigit(int number1, int number2)
{
    if (number1 % number2 == 0)
        Console.WriteLine("Кратно");
    else
        Console.WriteLine("Не кратно");
}
DelDigit (numberA, numberB);

