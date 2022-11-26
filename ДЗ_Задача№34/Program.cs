// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами.
// Напишите программу, которая покажет количество
// чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = new int[4];
int positivSum = 0;

for (int i = 0; i < array.Length; i++)
{
    int x = new Random().Next(100, 1000);
    array[i] = x;
    Console.Write(array[i] + ", ");     
    
    if (array[i] % 2 == 0)
    {
    positivSum = positivSum + 1;
    }
}
Console.WriteLine("Четных чисел в списке: " + positivSum);