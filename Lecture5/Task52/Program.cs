// 5! = 5*4*3*2*1
// 5*4!
// 4*3!
// 3*2!

int Factorial(int n)
{
    if (n == 1)
        return 1; //0! = 1, 1! = 1
    else
        return n * Factorial(n - 1);
}

Console.WriteLine(Factorial(3)); //1*2*3