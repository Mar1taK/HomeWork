/*Задача *: Напишите программу, которая из массива случайных чисел. 
Ищет второй максимум (число меньше максимального элемента, но больше всех остальных). 
Постарайтесь сделать одним циклом
[1, 3, 5, 6, 6, 4] -> 5*/

int[] array = new int[] { 1, 3, 5, 15, 6, 12 };

int maxNumber = 0;
int maxNumber2 = 0;

for (int i = 0; i < array.Length; ++i)
{
    int arrayItem = array[i];
    if (arrayItem > maxNumber)
    {
        maxNumber2 = maxNumber;
        maxNumber = arrayItem;
    }
    else if (arrayItem > maxNumber2 && arrayItem < maxNumber) maxNumber2 = arrayItem;
}
Console.WriteLine($"Second max number -> {maxNumber2}");
