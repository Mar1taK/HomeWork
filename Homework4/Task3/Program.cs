/* Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19, 6, 7, 8 -> [1, 2, 5, 7, 19, 6, 7, 8]
0, 6, 1, 33, 4, 7, 6, 8 -> [0, 6, 1, 33, 4, 7, 6, 8]
*/

int[] array = new int[8];
Random random = new Random();

for (int i = 0; i < 8; i++)
{
    array[i] = random.Next(-100, 1000);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
