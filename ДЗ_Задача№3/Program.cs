// // Задача 3: Задайте массив из 8 случайных чисел.
// // Напишите программу, которая определяет,
// // присутствует ли заданное число в массиве.

// // 4; массив [6, 7, 19, 345, 3] -> нет

// // 3; массив [6, 7, 19, 345, 3] -> да

// // Вариант со статичным заданым массивом
// // Для проверки что код рабочий.

// int[] array = {6, 7, 19, 345, 3, 6, 25, 67};
// int chekNum = 3;
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == chekNum)
//     {
//         sum = sum + 1;
//     }
// }
// if(sum == 0)
// {
//     Console.WriteLine("Нет");
// }
// else
// {
//      Console.WriteLine("Есть");
// }


// Вариант с рандомно генерируемым списком

Console.Write("Ведите число: ");
string str = Console.ReadLine();
int chekNum = int.Parse(str);
int[] array = new int [8];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    int randomNumber = new Random().Next(0, 100);
    array[i] = randomNumber;
    Console.Write(array[i] + ", ");

    if (array[i] == chekNum)
    {
        sum = sum + 1;
    }
}
if(sum == 0)
{
    Console.WriteLine();
    Console.WriteLine("Нет");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Есть");
}
