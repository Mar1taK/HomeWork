// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N с помощью рекурсии.

Console.Write("Введите M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма элементов в промежутке от M до N => {GetSumNumbers(M, N)}");
Console.ReadLine();

int GetSumNumbers(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;            
    else if (N == 0) return (M * (M + 1)) / 2;       
    else if (M == N) return M;                       
    else if (M < N) return N + GetSumNumbers(M, N - 1); 
    else return N + GetSumNumbers(M, N + 1);            
}

