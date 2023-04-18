// Задача 1:
// Напишите программу, которая принимает на вход число N и выдаёт сумму чисел от 1 до N.
// 7 -> 28
// 4 -> 10
// 8 -> 36


// Console.WriteLine("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int summ = 0;
// int i = 0;
// while (i <= N)
// {
//     summ = summ + i;
//     i++;
// }

// Console.WriteLine(summ);


// Задача 2:
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4  -> 24
// 5  -> 120

// Console.WriteLine("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int factorial = 1;
// int i = 1;
// while (i <= N)
// {
//     factorial = factorial * i;
//     i++;
// }

// Console.WriteLine(factorial);




// Задача 3 (общая):
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в 
// случайном порядке.
// [1,0,1,1,0,1,0,0]

// void FillArray(int[] array)
// {
//     int index = 0;
//     while (index < array.Length)
//     {
//         array[index] = new Random().Next(0, 2); // 0 и 1
//         index++;
//     }
// }

// void PrintArray(int[] array)
// {
//     int index = 0;
//     while (index < array.Length)
//     {
//         Console.Write(array[index] + " ");
//         index++;
//     }
// }


// int[] array_1 = new int[8];

// FillArray(array_1);
// PrintArray(array_1);



// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов (от -10 до 10) и выводит их на экран.

// 1, 2, 5, 7, 9 -> [1, 2, 5, 7, 9]

// 6, 1, 3 -> [6, 1, 3]