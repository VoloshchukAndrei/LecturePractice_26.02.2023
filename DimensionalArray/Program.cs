Console.Clear();

// string[,] table = new string[2, 5];
// table[1, 2] = "Введите";
// table[1, 3] = "Ваше";
// table[1, 4] = "имя";

// for (int i = 0; i < 2; i++)
// {
//     for (int j = 0; j < 5; j++)
//     {
//         Console.WriteLine($"-{table [i, j]}-");
//     }
// }

int[,] matrix = new int[4, 5];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
// Console.WriteLine();
// }

void PrintArray(int[,] M)
{
    for (int i = 0; i < M.GetLength(0); i++)
    {
        for (int j = 0; j < M.GetLength(1); j++)
        {
            Console.Write($"{M[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] M)
{
    for (int i = 0; i < M.GetLength(0); i++)
    {
        for (int j = 0; j < M.GetLength(1); j++)
        {
            M[i, j] = new Random().Next(1, 20);
        }
    }
}

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);