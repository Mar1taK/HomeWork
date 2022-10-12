/* Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B (и в нулевую степень). 
Использовать свои функции, не использовать Math.Pow
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void GetPower(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}

int numberA = ReadNumber("Введите число A: ");
int numberB = ReadNumber("Введите число B: ");
GetPower(numberA, numberB);




