/* Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.

Теорема о неравенстве треугольника, 
каждая сторона треугольника меньше суммы двух других сторон.
AB < AC + CB, AC < AB + BC, BC < BA + AC.
*/


int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

bool Cheak (int a, int b, int c)
{
    if (a + b > c && a + c > b && b + c > a) return true;
    return false;
}
int a1 = InputNum("Введите первую сторону: ");
int b1 = InputNum("Введите вторую сторону: ");
int c1 = InputNum ("Введите третью сторону: ");

bool result = Cheak(a1, b1, c1);
Console.WriteLine(result);