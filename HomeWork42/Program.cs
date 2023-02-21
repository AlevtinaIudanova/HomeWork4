//Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел

void Print(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " | ");
    }
}

int[] numbers = new int[10];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(100, 1000);
}
Print(numbers);

int curentValue = 0;
uint oddNumbersCount = 0; //нечетные числа
uint evenNumbersCount = 0; // четные числа

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        evenNumbersCount++;
    }
    else
    {
        oddNumbersCount++;
    }
    curentValue++;
}
Console.WriteLine();
Console.WriteLine($"Количество нечетных чисел: {oddNumbersCount}");
Console.WriteLine($"Количество четных чисел:  {evenNumbersCount}");







/*int[] array = new int[5];
void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " | ");
    }
}

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 6);
}
Print(array);


uint oddNumbersCount = 0; //нечетные числа
uint evenNumbersCount = 0; // четные числа

int curentValue = 1;
int limit = 5;
for (int i = 0; i <= limit; i++)
{
    if (array[i] % 2 == 0)
    {
        evenNumbersCount++;
    }
    else
    {
        oddNumbersCount++;
    }
    curentValue++;
}*/
/*uint oddNumbersCount = 0; //нечетные числа
uint evenNumbersCount = 0; // четные числа
Console.WriteLine();*/

/*int curentValue = 1;
int limit = 5;
while (curentValue <= limit)
{
    if (curentValue % 2 == 0)
    {
        evenNumbersCount++;
    }
    else
    {
        oddNumbersCount++;
    }
    curentValue++;
}*/
//Console.WriteLine($"Количество нечетных чисел: {oddNumbersCount}");
//Console.WriteLine($"Количество четных чисел:  {evenNumbersCount}");
