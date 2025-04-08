// See https://aka.ms/new-console-template for more information

int Fibonacci(int n, int a = 0, int b = 1)
{
    if (n == 0)
    {
        return a;
    }

    if (n == 1)
    {
        return b;
    }

    return Fibonacci(n - 1, b, a+b);
}

int n = 10;
int result = Fibonacci(n);
Console.Write(result);