// Домашние задачи!

// Задача 1. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// string PrintNumbers(int start,int end)
// {
//     if (start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start + 1, end));
// }

// Console.Clear();
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine());

// Console.Write("Введите M: ");
// int m = int.Parse(Console.ReadLine());

// Console.WriteLine(PrintNumbers(n,m));

// int sum = 0;

// for(int i = n; i <=m; i++)
// {
//     sum = sum + i;
// }
// Console.WriteLine(sum);

// Задача 2. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 

// int A(int n, int m)
// {
//     if (n == 0)
//         return m + 1;
//     else
//       if ((n != 0) && (m == 0))
//         return A(n - 1, 1);
//     else
//         return A(n - 1, A(n, m - 1));
// }

// Console.Clear();
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine());

// Console.Write("Введите M: ");
// int m = int.Parse(Console.ReadLine());

// Console.WriteLine(A(n, m));


Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
A(n, m);

static int A(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return A(n - 1, 1);
    if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
    return A(n, m);
}
Console.WriteLine(A(n,m));