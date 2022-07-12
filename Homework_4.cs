// Задачи семинара

// Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// int sumToNum(int num)
// {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }

// Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Sum of elements is " + sumToNum(number));

// Задача 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// int countnumbers(int num){
//     int count  = 0;
//     while (num > 0)
//     {
//         num = num / 10;
//         count++;
//     }
//     return (count);
// }
// Console.WriteLine("Input number: ");
// int numbers = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(countnumbers(numbers));

// Задача 3. Напишите программу, которая принимает на вход число N и выдает произведение всех чисел от 1 до N.

// int Number (int num){
//     int work = 1;
//     for (int i = 1; i <= num; i++){
//         work *= i;
//     }
//     return work;
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Work of elements is " + Number(number));



// Домашняя работа.

// Задача 1. Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.

// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// for ( ; ; )
// {
//     Console.WriteLine(Math.Pow(a,b));
//     break;
// }


// Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int Number(int num)
// {
//     int i = 0;
//     int sum = 0;
//     while (num <= 0)
//     {
//         i = num%10;
//         sum = sum + i;
//         num = num/10;
//         Console.WriteLine("Sum of numbers is " + sum);
//     }
//     return sum;
// }

// Console.WriteLine("Введите число: ");
// int result = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Sum of numbers is " + Number(result));


// Задача 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateRandomArray(int size)
{
    int [] array = new int [size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(0,2);
    }
    return array;
}

int[] CreateArray(int size)
{
    int [] array = new int [size];
    for(int i = 0; i < size; i++)
    {
        Console.Write("Input " + i + " element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
}
int [] myRandomArray = CreateRandomArray(8);
ShowArray(myRandomArray);