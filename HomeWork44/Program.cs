// Найти сумму чисел одномерного массива стоящих на нечетной позиции

void Print(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " | ");
    }
}

int[] numbers = new int[6];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(-10, 15);
}
Print(numbers);

int sum = 0;
int sum1 = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 == 0)
    {
        sum = sum + numbers[i];
    }
    else
    {
        sum1 = sum1 + numbers[i];
    }
}
Console.WriteLine();
Console.WriteLine($"Sum чисел,стоящих на нечетной позиции: {sum1}");