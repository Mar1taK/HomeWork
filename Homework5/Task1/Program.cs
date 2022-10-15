// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Задайте размер массива:  ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[sizeArray];
int count = 0;

void GetArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
    Console.WriteLine("Массив сгенерирован: ");
}

void GetEvenNumber(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
        if (numbers[i] % 2 == 0)
            count++;
    Console.WriteLine($"В массиве {numbers.Length} чисел, {count} из них чётные");
}

void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}
GetArrayRandomNumbers(numbers);
PrintArray(numbers);
GetEvenNumber(numbers);
