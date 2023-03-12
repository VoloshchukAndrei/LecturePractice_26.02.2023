Console.Clear();

// f(1) = 1 
// f(2) = 1 
// f(n) = f(n-1) + f(n-2) 

// int Fibonacci(int n)
// { 
//     if(n == 1 || n == 2) return 1; 
//     else return Fibonacci(n-1) + Fibonacci(n-2); 
// }
// for (int i = 1; i < 30; i++) 
// {
//      Console.WriteLine($"{i} - {Fibonacci(i)}"); 
// }

decimal FibonacciRec = 0;
decimal FibonacciIte = 0;

decimal FibonacciRecursion(int n)
{
    FibonacciRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
}

decimal FibonacciIteration(int n)
{
    FibonacciIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;

        f0 = f1;
        f1 = result;
        FibonacciIte++;
    }
    return result;
}

Console.ReadLine();

DateTime dt = DateTime.Now;
for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} FibonacciIte = {FibonacciIte.ToString("### ### ###"), - 15}");
    FibonacciIte = 0;
}
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

Console.WriteLine();
Console.ReadLine();

dt = DateTime.Now;
for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} FibonacciRec = {FibonacciRec.ToString("### ### ###"), - 15}");
    FibonacciRec = 0;
}

Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
Console.ReadLine();