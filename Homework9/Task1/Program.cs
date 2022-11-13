// Задайте значения M и N. Напишите программу, которая выведет все чётные 
// натуральные числа в промежутке от M до N с помощью рекурсии.

Console.Write("Введите значение M: ");
int M = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = Convert.ToInt16(Console.ReadLine());

void GetEvenNumber(int M, int N)
{
    if (N < M) return;
    if (N % 2 == 0) GetEvenNumber(M, N - 2);
    else GetEvenNumber(M, N - 1);
    if (N % 2 == 0) Console.Write(N + " ");
}

GetEvenNumber(M, N);
Console.WriteLine();


