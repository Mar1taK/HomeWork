// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Задайте размер массива:  ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[sizeArray];
int sum = 0;

void GetArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-100, 1000);
    }
    Console.WriteLine("Массив сгенерирован: ");
}

void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}

void GetOddNumberPosition(int[] numbers)
{
    for (int i = 1; i < numbers.Length; i += 1)
    {
        if (i % 2 != 0)
            sum += numbers[i];
    }
    Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях равна {sum}");
}

GetArrayRandomNumbers(numbers);
PrintArray(numbers);
GetOddNumberPosition(numbers);
