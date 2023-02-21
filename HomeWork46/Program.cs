//В Указанном массиве вещественных чисел найдите разницу между 
//максимальным и минимальным элементом

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

int max = numbers[0];
int min = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
    // если текущий элемент больше найденного на данный момент максимума
    if (numbers[i] > max)
    {
        max = numbers[i];
    }

    // если текущий элемент меньше найденного на данный момент минимума
    else if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
Console.WriteLine();
Console.WriteLine($"min: {min}");
Console.WriteLine($"max: {max}");

int difference = max - min;
Console.WriteLine($"Разница = {difference}");
