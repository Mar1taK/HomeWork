// Задача 3: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет. Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

int num, count, foundNumber;

Console.WriteLine("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

int FoundNumber(int number)
{
    count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}

foundNumber = FoundNumber(num);

if (foundNumber <= 2)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    if (foundNumber > 3)
    {
        num = num / Convert.ToInt32(Math.Pow(10, foundNumber - 3)); 
    }
    num = num % 10;
    Console.WriteLine($"Третья цифра введённого числа: {num}");
}




