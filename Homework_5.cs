// Примеры форматирования

// string name = "Имя";
// int age = 99;
// Console.WriteLine("Имя: {0}   Возраст: {1}", name,age);

// int number = 23;
// string result = string.Format("{0:f}", number);

// Console.WriteLine(result);

// double number2 = 45.08;
// string result2 = string.Format("{0:f2}", number2);
// Console.WriteLine(result2);

// string name = "Имя";
// int age = 99;
// Console.WriteLine($"Имя: {name}  Возраст {age}");

// int x = 8;
// int y = 7;
// string result = $"{x} + {y} = {x + y}";
// Console.WriteLine(result);

// string name = "Имя";
// int age = 99;

// Console.WriteLine($"Имя: {name,-10}  Возраст {age}"); // пробелы после
// Console.WriteLine($"Имя: {name,15}  Возраст {age}"); // пробелы до


// Задачи семинара!!!

// Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int [] CreateRandomArray(int size, int min, int max){
//     int [] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(min,max+1);
//     }
//     return array;
// }
// void ShowArray(int[] array){
//     for (int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int [] MyArray = CreateRandomArray(12,-9,9);
// ShowArray(MyArray);

// int sum_pos = 0;
// int sum_neg = 0;

// for (int i = 0; i < MyArray.Length; i++)
// {
//     if (MyArray[i] > 0)
//         sum_pos += MyArray[i];
//     else
//         sum_neg += MyArray[i];
// }
// Console.WriteLine($"Сумма положительных: {sum_pos}. Сумма отрицательных: {sum_neg}");

// Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4,-8,8,2] -> [4,8,-8,-2]

// int [] CreateRandomArray(int size, int min, int max){
//     int [] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(min,max+1);
//     }
//     return array;
// }

// void ShowArray(int[] array){
//     for (int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int [] GetArray (int[]array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = array[i] * (-1);
//     }
//     return array;
// }

// int [] array = CreateRandomArray(10,-10,10);
// ShowArray(array);
// ShowArray(GetArray(array));


// Задача 3. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6,7,19,345,3] -> нет
// -3; массив [6,7,19,345,3] -> да

// int [] CreateRandomArray(int size){
//     int [] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(0,10);
//     }
//     return array;
// }

// int [] MyArray = CreateRandomArray(8);

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
// }

// ShowArray(MyArray);

// int ArrayCheck(int[] array){
//     for (int i = 0; i < MyArray.Length; i++){
//         if(MyArray[i] == 4){
//             return 1;
//         }
//     }
//     return 0;
// }


// if (ArrayCheck(MyArray) == 1)
// {
//     Console.WriteLine(" 4 is present");
// }
// else{
//     Console.WriteLine (" 4 is absent");
// }

// Домашняя работа!!!

// Задача 1. Задайте массив заполненный случайными положительными числами. Напишите программу, которая покажет количиство чётных чисел в массиве.

// int [] CreateRandomArray(int size){
//     int [] array = new int [size];
//     for (int i = 0; i < size; i++){
//         array[i] = new Random().Next(100,1000);
//     }
//     return array;
// }

// void GetArray(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             count += 1;
//         }
//     }
//     Console.WriteLine("-> " + count);
// }

// void ShowArray (int[]array){
//     for (int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
// }

// int [] array = CreateRandomArray(5);
// ShowArray(array);
// GetArray(array);


// Задача 2. Задайте одноименный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int [] CreateRandomArray(int size){
//     int [] array = new int [size];
//     for (int i = 0; i < size; i++){
//         array[i] = new Random().Next(0,101);
//     }
//     return array;
// }

// void GetArray(int[] array)
// {
//     int count = 0;
//     for (int i = 1; i < array.Length; i = i + 2)
//     {
//         count += array[i];
//     }
//     Console.WriteLine("-> " + count);
// }

// void ShowArray (int[]array){
//     for (int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
// }

// int [] array = CreateRandomArray(5);
// ShowArray(array);
// GetArray(array);


// Задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// Вариант 1.

// int [] CreateRandomArray(int size){
//     int [] array = new int [size];
//     for (int i = 0; i < size; i++){
//         array[i] = new Random().Next(0,101);
//     }
//     return array;
// }

// void ShowArray (int[]array){
//     for (int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
// }

// int [] array = CreateRandomArray(5);
// ShowArray(array);
// int max = array.Max();
// int min = array.Min();
// Console.WriteLine($"-> {max} - {min} = {max - min}");

// Вариант 2.

// int [] CreateRandomArray(int size){
//     int [] array = new int [size];
//     for (int i = 0; i < size; i++){
//         array[i] = new Random().Next(0,101);
//     }
//     return array;
// }

// void ShowArray (int[]array){
//     for (int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
// }

// int [] array = CreateRandomArray(5);
// ShowArray(array);

// int max = 0;
// int min = 0;
// max = array[0];
// min = array[0];
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > max){
//         max = array[i];
//     }
//     if (array[i] < min){
//         min = array[i];
//     }
// }
// Console.WriteLine($"-> {max} - {min} = {max - min}");


// Задача 4. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов масссива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5 элементов: [5,18,123,6,2] -> 1; [1,2,3,6,2] -> 0; [10,11,12,13,14] -> 5

// int [] CreateRandomArray(int size){
//     int [] array = new int [size];
//     for (int i = 0; i < size; i++){
//         array[i] = new Random().Next(0,124);
//     }
//     return array;
// }

// void GetArray(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i]>=10 && array[i]<=99){
//         count += 1;
//         }
//     }
//     Console.WriteLine("-> " + count);
// }

// void ShowArray (int[]array){
//     for (int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
// }

// int [] array = CreateRandomArray(123);
// ShowArray(array);
// GetArray(array);