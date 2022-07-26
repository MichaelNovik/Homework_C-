// Задачи семинара!!!

// Задача 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// int [,] CreateRandomArray (int m, int n, int min, int max)
// {
//     int [,] array = new int [m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array [i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return array;
// }

// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void SwapArray(int [,] array)
// {
//     int buf = 0;
//     int lastRow = array.GetLength(0) - 1;
//     for (int column = 0;column < array.GetLength(1); column++)
//     {
//         buf = array[0, column];
//         array[0, column] = array[lastRow, column];
//         array[lastRow, column] = buf;
//     }
// }

// Console.WriteLine("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min number: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max number: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int [,] myArray = CreateRandomArray(rows, columns, min, max);
// ShowArray(myArray);
// Console.WriteLine();
// SwapArray(myArray);
// ShowArray(myArray);

// Задача 2. Задайте двумерный массив. Поменяйте местами стрки со столбцами.

// int[,] CreateRandomArray(int m, int n, int min, int max)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return array;
// }

// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] SwapArray(int[,] array)
// {
//     int[,] ArrayNew = new int[array.GetLength(0), array.GetLength(1)];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             ArrayNew[j, i] = array[i, j];
//         }
//     }
//     return ArrayNew;
// }

// Console.WriteLine("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min number: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max number: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandomArray(rows, columns, min, max);
// ShowArray(myArray);
// Console.WriteLine();
// ShowArray(SwapArray(myArray));

// Задача 3. Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Набор данных: 
// {1,9,9,0,2,8,0,9}
// Частотный массив 
// {
//     0 встречается 2 раза;
//     1 встречается 1 раз;
//     2 встречается 1 раз;
//     8 встречается 1 раз;
//     9 встречается 3 раза;
// }

// Набор данных:
// {
//     1,2,3
//     4,6,1
//     2,1,6
// }

// Частотный массив
// {
//     1 встречается 3 раза;
//     2 встречается 2 раза;
//     3 встречается 1 раз;
//     4 встречается 1 раз;
//     6 встречается 2 раза;
// }

int[,] CreateRandomArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void ShowArrayTwo(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowArrayOne(int[] array)
{
    // Console.WriteLine();
    // for (int i = 0; i < array.Length; i++)
    // {
    //     Console.Write(array[i, j] + " ");
    // }
    // Console.WriteLine();
    Console.WriteLine(String.Join(" ",array));
}

int [] GetOneArray (int [,] arrayTwo)
{
    int [] arrayOne = new int[arrayTwo.GetLength(0)*arrayTwo.GetLength(1)];
    int index = 0;

    for (int i = 0; i < arrayTwo.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTwo.GetLength(1); j++)
        {
            arrayOne[index] = arrayTwo[i,j];
            index++;
        }
    }
    return arrayOne;
}

void SortArray(int [] array)
{
    int buf = 0;

    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[i] > array[j])
            {
                buf = array[i];
                array[i] = array[j];
                array[j] = buf;
            }
        }
    }
}

void ShowQuanElem(int [] array)
{
    int count = 1;
    int temp = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] != temp)
        {
            Console.WriteLine($"{temp} встречается {count} раз");
            temp = array[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    Console.WriteLine($"{temp} встречается {count} раз");
}

Console.Clear();

Console.WriteLine("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max number: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandomArray(rows, columns, min, max);

ShowArrayTwo(myArray);
int [] arrayOne = GetOneArray(myArray);
// Console.WriteLine(String.Join(" ",GetOneArray(myArray)));
// SortArray(GetOneArray(myArray));
Console.WriteLine(String.Join(" ",arrayOne));
SortArray(arrayOne);
Console.WriteLine(String.Join(" ",arrayOne));
Console.WriteLine();
ShowQuanElem(arrayOne);
