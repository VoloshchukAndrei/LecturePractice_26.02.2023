Console.Clear();

// ____________________________________________________________
// СТРОКА ОТ МЕНЬШЕГО К БОЛЬШЕМУ ИЛИ ОТ БОЛЬШЕГО К МЕНЬШЕМУ

// Console.Write("Введите число старта: ");
// int numberStart = int.Parse(Console.ReadLine());

// Console.Write("Введите число финиша: ");
// int numberFinis = int.Parse(Console.ReadLine());

// Console.WriteLine(NumbersFor(numberStart, numberFinis));
// Console.WriteLine(NumbersRecursion(numberStart, numberFinis));

// Console.WriteLine(NumbersFor(1, 10));
// Console.WriteLine(NumbersRecursion(1, 10));

// string NumbersFor(int a, int b)
// {
//     string result = String.Empty;
//     for (int i = b; i >= a; i--)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// string NumbersRecursion(int a, int b)
// {
//     if (a <= b) return NumbersRecursion(a + 1, b) + $"{a} ";
//     else return String.Empty;
// }


// _____________________________________________
// СТРОКА СУММА ЧИСЕЛ ОТ 1 ДО N

// int SumFor(int n)
// {
//     int result = 0;
//     for (int i = 1; i <= n; i++) result += i;
//     return result;
// }

// int SumRecursion(int n)
// {
//     if (n == 0) return 0;
//     else return n + SumRecursion(n - 1);
// }

// Console.WriteLine(SumFor(10));
// Console.WriteLine(SumRecursion(10));

// _____________________________________
// ФАКТОРИАЛ ЧИСЛА

// int FactorialFor(int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= i;
//     return result;
// }

// int FactorialRecursion(int n)
// {
//     if (n == 1) return 1;
//     else return n * FactorialRecursion(n - 1);
// }

// Console.WriteLine(FactorialFor(10));
// Console.WriteLine(FactorialRecursion(10)); 


// _____________________________________________
// ВЫЧИСЛИТЬ A в СТЕПЕНИ N

// int PowerFor(int a, int n)
// { 
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= a;
//     return result;
// }

// int PowerRecursion(int a, int n)
// {   return n == 0 ? 1 : PowerRecursion(a, n - 1) * a;
//     if (n == 0) return 1;
//     else return PowerRecursion(a, n - 1) * a;
// }

// int PowerRecursionMath(int a, int n)
// {
//     if (n == 0) return 1;
//     else if (n % 2 == 0) return PowerRecursionMath(a * a, n / 2);
//     else return PowerRecursionMath(a, n - 1) * a;
// }

// Console.WriteLine(PowerFor(2, 10));
// Console.WriteLine(PowerRecursion(2, 10)); 
// Console.WriteLine(PowerRecursionMath(2, 10)); 

// _________________________________________________
// ПЕРЕБОР СЛОВ

// char[] s = { 'а', 'и', 'с','в'};
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//     for (int j = 0; j < count; j++)
//     {
//         for (int k = 0; k < count; k++)
//         {
//             Console.WriteLine($"{n++,-3}{s[i]}{s[j]}{s[k]}");
//         }
//     }
// }

int n = 0;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("аисв", new char[5]);

