// Задача 2: Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа. Не использовать строки для расчета.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Дано число: {number}");
int newNumber = 0;

int FoundNumber()
{
    newNumber = number / 100 * 10 + number % 10;
    return newNumber;
}

FoundNumber();
Console.WriteLine($"Если из числа {number} удалить вторую цифру, получится число {newNumber}");


