// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void PrintArray(int[,] matr)
{
    for (int i = 0; i == 0; i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 2);

        }
    }
}
int[,] matrix = new int[1, 8];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);