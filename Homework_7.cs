// Домашнее задание!!1

// Задача 1. Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.

double [,] CreateRandomArray(double m, double n, double min, double max)
{
    double [,] array = new double [m,n];
    for (double i = 0; i < m; i++)
    {
        for (double) j = 0; j < m; j++)
        {
            array[i, j] = new Random().NextDouble (min, max + 1);
        }
    }
    return array;
}

// void GetArray(double[] array)
// {
//     double count = 0;
//     for (double i = 0; i < array.Length; i++)
//     {
//         if (array[i]>=10 && array[i]<=99){
//         count += 1;
//         }
//     }
//     Console.WriteLine("-> " + count);
// }

void ShowArray (double[,] array)
{
    for (double i = 0; i < array.GetLength(0); i++)
    {
        for (double j = 0; j < array.GetLength(0); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }
}

Console.WriteLine("Enter number of rows: ");
double row = Convert.Todouble32(Console.ReadLine());
Console.WriteLine("Enter number of columns: ");
double columns = Convert.Todouble32(Console.ReadLine());
Console.WriteLine("Enter min number: ");
double min = Convert.Todouble32(Console.ReadLine());
Console.WriteLine("Enter max number: ");
double max = Convert.Todouble32(Console.ReadLine());


double [,] myArray = CreateRandomArray(row,columns,min, max);
// double [,] myArray = CreateRandomArray (3, 4, 1, 10);

ShowArray(myArray);





______________________________________

double [,] CreateRandomArray(double m, double n, double min, double max)
{
    double [,] array = new double [m,n];
    for (double i = 0; i < m; i++)
    {
        for (double j = 0; j < m; j++)
        {
            array[i, j] = new Random().Next (min, max + 1);
        }
    }
    return array;
}

// void GetArray(double[] array)
// {
//     double count = 0;
//     for (double i = 0; i < array.Length; i++)
//     {
//         if (array[i]>=10 && array[i]<=99){
//         count += 1;
//         }
//     }
//     Console.WriteLine("-> " + count);
// }

void ShowArray (double[,] array)
{
    for (double i = 0; i < array.GetLength(0); i++)
    {
        for (double j = 0; j < array.GetLength(0); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }
}

Console.WriteLine("Enter number of rows: ");
double row = Convert.Todouble32(Console.ReadLine());
Console.WriteLine("Enter number of columns: ");
double columns = Convert.Todouble32(Console.ReadLine());
Console.WriteLine("Enter min number: ");
double min = Convert.Todouble32(Console.ReadLine());
Console.WriteLine("Enter max number: ");
double max = Convert.Todouble32(Console.ReadLine());


// double [,] myArray = CreateRandomArray(row,columns,min, max);
double [,] myArray = CreateRandomArray (3, 4, 1, 10);

ShowArray(myArray);