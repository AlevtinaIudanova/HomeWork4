//В одномерном массиве из 123 чисел найти количество 
//элементов из отрезка [10,99]

//int[] array = new int[123];
//int Length = collection.Length;

void Print(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " | ");
    }
}

int[] numbers = new int[123];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(-10, 150);
}
Print(numbers);

int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < 99 && numbers[i] > 10)
    {
        count++;
    }
}
Console.WriteLine($"Итого: {count}");