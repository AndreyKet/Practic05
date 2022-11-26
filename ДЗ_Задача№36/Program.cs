// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] array = new int[4];
int amountNum = 0;

for (int i = 0; i < array.Length; i++)
{
    int list = new Random().Next(-100, 100);
    array[i] = list;
    Console.Write(array[i] + ", ");
    
    if (i % 2 == 1)
    {
        amountNum += array[i];
    }
}
Console.WriteLine();
Console.WriteLine("Сумма элементов: " + amountNum);

