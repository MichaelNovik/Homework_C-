// Домашнее задание!!1

// Задача 1. Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.

// Вариант 1.

// double [,] CreateRandomArray(double m, double n, double min, double max)
// {
//     double [,] array = new double[m,n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//             array[i, j] = Random().NextDouble (min, max + 1);
//         }
//     }
//     return array;
// }

// // void GetArray(double[] array)
// // {
// //     double count = 0;
// //     for (double i = 0; i < array.Length; i++)
// //     {
// //         if (array[i]>=10 && array[i]<=99){
// //         count += 1;
// //         }
// //     }
// //     Console.WriteLine("-> " + count);
// // }

// void ShowArray (double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//     Console.WriteLine();
//     }
// }

// Console.WriteLine("Enter number of rows: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min number: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max number: ");
// int max = Convert.ToInt32(Console.ReadLine());


// // double [,] myArray = CreateRandomArray(row,columns,min, max);
// double [,] myArray = CreateRandomArray (3, 4, 1, 10);

// ShowArray(myArray);

// Вариант 2.

// double[,] a = new double[5, 10];

// Random random = new Random();
// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 10; j++)
//     {
//         a[i, j] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
//         Console.Write("{0,6:F2}", a[i, j]);
//     }
//     Console.WriteLine();
// }

// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет

int [,] CreateRandomArray(int m, int n, int min, int max)
{
    int[,] array = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
    Console.WriteLine();
    }
}

Console.Write("Enter number's index of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter  number's index of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int i = 0;
int j = 0;
int[,] array = new int [3,4];
if (rows <= 3 && columns <= 4)
{
    array [i,j] = array [rows,columns];
    Console.WriteLine($"На данной позиции стоит число -> {array[rows, columns]}");
}
else
{
    Console.Write($"{rows}, {columns} -> такого числа в массиве нет");
}

int[,] myArray = CreateRandomArray(3, 4, 1, 10);
ShowArray(myArray);