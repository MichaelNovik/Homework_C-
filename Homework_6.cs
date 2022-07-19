// Задачи семинара!!!

// Задача 1. Задайте одмномерный массив и поставьте на последнее место первый элемент. а на первое последний.

// Варинт 1. 

// int[] RandomArray(int size)
// {
//     int [] array = new int [size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(100,1000);
//     }
//     return array;
// }

// void SwapArray (int[] array)
// {
//     int buf = 0;

//     for(int i = 0; i < array.Length/2; i++)
//     {
//         buf = array[i];
//         array [i] = array[array.Length-i-1];
//         array[array.Length-i-1] = buf;
//     }
//    ShowArray(array);
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] arr = RandomArray(size);

// ShowArray(arr);

// Console.WriteLine();

// SwapArray(arr);

// Варинт 2. 

// int[] RandomArray(int size)
// {
//     int [] array = new int [size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(100,1000);
//     }
//     return array;
// }

// void SwapArray (int[] array)
// {
//     int buf = 0;

//     for(int i = 0; i < array.Length/2; i++)
//     {
//         buf = array[i];
//         array [i] = array[array.Length-i-1];
//         array[array.Length-i-1] = buf;
//     }
//    ShowArray(array);
// }

// void SwapArray1 (int[] array)
// {
//     int [] arr = new int [array.Length];

//     for(int i = 0, j = array.Length-1; i < array.Length; i++, j--)
//     {
//         arr[i] = array[j];
//     }
//    ShowArray(arr);
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] arr = RandomArray(size);

// ShowArray(arr);

// Console.WriteLine();

// SwapArray1(arr);


// Задача 2. Напишите программу, которая будет принимать на вход 3 числа и проверять, может ли существовать треугольник со сторонами такой длины.
// Теорема о невравенстве треуголинка: любая из сторон должна быть меньше сумму двух других.

// double A = new Random().NextDouble();
// Console.WriteLine(A);

// double B = new Random().NextDouble();
// Console.WriteLine(B);

// double C = new Random().NextDouble();
// Console.WriteLine(C);

// bool NewNum(double A, double B, double C)
// {
//     if (A<B+C && B<A+C && C<B+A)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }
// if (NewNum(A,B,C))
// {
//     Console.WriteLine("Треугольник существует");
// }
// else
// {
//     Console.WriteLine("Треугольник не существует");
// }


// Домашняя работа!!!

// Задача 1. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// Например: 45 -> 101101; 3 -> 11; 2 -> 10.

// Console.WriteLine("Введите целое число: ");
// int A = Convert.ToInt32(Console.ReadLine());

// int [] numbers = {}
// int count = 0;
// while (A>=0)
// {
//     int A1 = A%2;
//     count += A%2;
// }

// Console.WriteLine(count);

// Console.WriteLine("Введите целое число: ");
// int num10 = Convert.ToInt32(Console.ReadLine());

// // int num10 = 22; // число в десятичной системе исчисления
// int a = 0; // a - остаток после % деления из которого формируется число в 
//            //    двоичной системе исчисления
// int i = 0;

// int[] b = new int[10]; // массив с помощью которого двоичное число позже 
//                        //будет выведено с конца для правильного отображения 

// while (num10 >= 1)
// {
//     a = num10 % 2;
//     b[i] = a;
//     i++;

//     num10 = num10 / 2;

//     Console.Write(a);
// };

// Console.WriteLine();

// for (i = (b.Length - 1); i >= 0; i--)
// {
//     Console.Write(b[i]);
// }

// Console.ReadKey();


// Задача 2. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.WriteLine("До какого числа считать ряд Фибоначчи?");
// int number = Convert.ToInt32(Console.ReadLine());

// int a = 0;
// Console.Write("{0} ", a);
// int b = 1;
// Console.Write("{0} ", b);
// int sum = 0;

// while (number >= sum)
// {
//     sum = a + b;

//     Console.Write("{0} ", sum);

//     a = b;
//     b = sum;
// }