/* Задача 2: Напишите программу, которая принимает на вход число и выдаёт
 сумму цифр в числе. Функция должна на вход принимать число, а выдавать сумму его цифр
452 -> 11
82 -> 10
9012 -> 12 */

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int number = ReadNumber("Введите любое число: ");
int sum = 0;

while (number > 0)
{
    sum = sum + number % 10;
    number /= 10;
}
Console.WriteLine("Сумма цифр введенного числа -> " + sum);