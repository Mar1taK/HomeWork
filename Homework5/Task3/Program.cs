// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
int min = Int32.MaxValue;
int max = Int32.MinValue;

void GetArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToInt32(new Random().Next(1, 1000));
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
void GetDifNumber(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
}
GetArrayRandomNumbers(numbers);
PrintArray(numbers);
GetDifNumber(numbers);
Console.WriteLine($"Всего {numbers.Length} чисел. Максимальное значение -> {max}, минимальное значение -> {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением -> {max - min}");


