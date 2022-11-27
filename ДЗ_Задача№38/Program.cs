// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между 
// максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


int[] array = {3, 7, 22, 2, 78};
int minNum = array[0];
int maxNum = array[0];
int diffNum = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < minNum)
    {
        minNum = array[i];
    }
    if (array[i] > maxNum)
    {
        maxNum = array[i];
    }
    diffNum = maxNum - minNum;
}
Console.WriteLine("Разница между Max/Min: "+ diffNum);
