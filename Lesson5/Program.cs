// // // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // // 452 -> 11
// // // 82 -> 10
// // // 9012 -> 12

// // Console.WriteLine("Введите число: ");
// // string str = Console.ReadLine();
// // int sum = 0;

// // // for (int i = 0; i < str.Length; i++)
// // // {
// // //     char currentChar = str[i];
// // //     int positionOfChar = Convert.ToInt32(currentChar);
// // //     int numberFromChar = int.Parse(currentChar.ToString());
// // //     Console.Write($"Сивол: {currentChar}, позиция: {positionOfChar}, число: {numberFromChar} \n");
// // // }

// // for (int i = 0; i < str.Length; i++)
// // {
// //     int currentNumber = int.Parse(str[i].ToString());
// //     sum += currentNumber; // sum = sum + currentNumber
// // }
// // Console.WriteLine(sum);

// // // Правила по стилю написания кода (code style)
// // // Все названия любых структур языка должны описывать то, что они делают или хранят
// // // Переменные: первое слово пишется с маленькой буквы, следующие слова с большой
// // string textFromConsole; // Текст из консоли
// // string text; // вот так не надо, это не информативно

// // // Функции (Класс, интерфейсы, структуры, перечисления): Все слова с первого пишутся с большой буквы
// // int GetRandomNumber(int from, int to) // Получение случайного числа
// // {
// //     return 0; // заглушка
// // }

// // Заполение массива:
// // int[] array = {new Random().Next(0, 10)}; // так не сработает, будет только одно число
// int[] array = new int[4]; // 4 - размер (количество)

// for (int i = 0; i < array.Length; i++) // заполнение массива
// {
//     int randomNumber = new Random().Next(0, 10); // генерируем случайное число
//     array[i] = randomNumber; // кладём в массив на место с индексом i
// }

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();

// for (int i = 0; i < array.Length; i++) // изменение массива уже после заполнения
// {
//     array[i] = array[i] + 5;
// }

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }




// Console.Write("Введите число: ");
// string str = Console.ReadLine();
// int sum = 0;
// for (int i = 0; i < str.Length; i++)
// // {
// //     sum = sum + (arr[i] - '0');
// // }    
// // Console.WriteLine(sum);
// {
//     // char currentChar = string[i];
//     // int positionofChar Convert.ToInt32(currentChar);
//     // int numberofChar = int.Parse(currentChar.ToString());
//     // Console.WriteLine($"Символ: {currentChar}, позиция: {positionofChar}, число: {numberofChar} \n");
//     int currentNumber = int.Parse(str[i].ToString());
//     sum += currentNumber; //sum = sum + currentNumber
// }
// Console.WriteLine(sum);



// Правила по стилю написания кода (Code style)
// Все названия любых структур языка должны описывать то, что они делают или хронят
// Переменные: первая пишется с маленькой, след слово с большой  Camal Style

// string textFromConsole; // текст из консоли
// string text; // не информативный 


// // Функции (Класс, интерфэйсы, структуры, перечисления)все слова с первого пишутся с большой буквы
// int GetRandomNumber(int from, int to) // // Получение случайного числа
// {
//     return 0; 
// }



// int[] array = new int[10];

// for (int i = 0; i < array.Length; i++)
// {
//     int x = new Random().Next(-9, 9);
//     array[i] = x;   
//     Console.WriteLine(array[i]);
// }



// int[] array = new int[10];
// int positivSum = 0;
// int negativSum = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     int x = new Random().Next(-9, 10);
//  // array[i] = x;  
//     Console.WriteLine(array[i] + " " );

//  // int currentNumber = int.Parse(array[i].ToString());
//     if (currentNumber >= 0)
//     {
//         positivSum += currentNumber;
//     }
//     else
//     {
//         negativSum -= currentNumber;
//     }
// }
// Console.WriteLine("Сумма положительных чисел: " + positivSum);
// Console.WriteLine("Сумма отрицательных чисел: -" + negativSum);


// int[] array = new int[10];
// int length = array.Length;

// for (int i = 0; i < length; i++)
//     int index = 0;
// while (index < lenght)
// {
//     array[index] = new Random().Next(-20, 20);
//     Console.WriteLine(array[index] + " ");
//     index++;
// }
// Console.WriteLine();
// int i = 0;


int[] array = new int[10];
int sum1 = 0;
int sum2 = 0;
for (int i = 0; i < array.Length; i++) 
{
    array [i] = new Random().Next(-9,10);
    Console.Write(array[i] + " ");
    int currentNumber = array[i];

    if (currentNumber > 0)
    {
        sum1 += currentNumber;
    }
    if (currentNumber < 0)
    {
        sum2 += currentNumber;
    }
}
Console.WriteLine("отрицательные " + sum1);
Console.WriteLine("положительные " + sum2);






