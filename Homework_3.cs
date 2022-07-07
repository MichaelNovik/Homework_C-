// Семинар 3.

// Задача 1. Напишите программу, которая принимает на вход координаты точки (X,Y), причём X не равно 0 и Y не равно 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// void Num(int x, int y){
//     if (x>0 & y>0){
//         Console.WriteLine("Данная точка находится в 1 четверти плоскости");
//     }
//     else if (x<0 & y>0){
//         Console.WriteLine("Данная точка находится в 2 четверти плоскости");
//     }
//      else if (x>0 & y<0){
//         Console.WriteLine("Данная точка находится в 4 четверти плоскости");
//     }
//      else if (x<0 & y<0){
//         Console.WriteLine("Данная точка находится в 3 четверти плоскости");
//     }
//     else{
//         Console.WriteLine("Кажется вы ввели X и/или Y равные 0. Введите координаты точки отличные от 0!");
//     }
//     }

// Console.WriteLine("Введите координаты точки x и y:");
// Num(Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()));

// Задача 2. 

// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (X и Y).

// void Num(int a){
//     if (a==1){
//         Console.WriteLine("В данной области X и Y могут принимать следующие значения: x>0 & y>0");
//     }
//     else if (a==2){
//         Console.WriteLine("В данной области X и Y могут принимать следующие значения: x<0 & y>0");
//     }
//      else if (a==4){
//         Console.WriteLine("В данной области X и Y могут принимать следующие значения: x>0 & y<0");
//     }
//      else if (a==3){
//         Console.WriteLine("В данной области X и Y могут принимать следующие значения: x<0 & y<0");
//     }
//     else{
//         Console.WriteLine("Кажется вы ввели цифру не обозначающую никакую из плоскостей. Введите цифру от 1 до 4.");
//     }
//     }

// Console.WriteLine("Введите номер четверти плоскости (1-4):");
// Num(Convert.ToInt32(Console.ReadLine()));

// Задача 3. 

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// void Num(int x1, int y1, int x2, int y2){
//     double a = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
//     Console.WriteLine(Math.Round((a), 2));
//     }

// Console.WriteLine("Введите последовательно координаты точек x1, y1, x2, y2:");
// Num(Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()));

// Задача 4.

// Написать программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// Console.Clear();

// void listsqrt(int n){
//     int count = 1;
//     Console.Write(n + " -> ");
//     if (n>0){
//         while(count <= n){
//             Console.Write(Math.Pow(count, 2) + ", ");
//             count++;
//         }
//     }
//     else{
//         count=-1;
//         while(count >= n){
//             Console.Write(Math.Pow(count, 2) + ", ");
//             count--;
//         }
//     }
// }
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// listsqrt(num);



// Домашнее задание!!!

// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.Clear();

// void Number (int a, int b, int c, int d, int e){
//     if (a == e & b == d){
//     Console.WriteLine("Число является полиномом!");
//     }
//     else{
//         Console.WriteLine("Число полиномом не является!");
//     }
// }

// Console.WriteLine("Введите последовательно 5 цифр пятизначного числа: ");
// Number(Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()));

// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Console.Clear();

// void Number (int x1, int y1, int z1, int x2, int y2, int z2){
//     Console.WriteLine(Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2)));
// }

// Console.WriteLine("Введите последовательно координаты двух точек: ");
// Number(Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()));

// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

void Number (int n){
    int count = 1;
    if(n>0){
        while(count<=n){
            Console.WriteLine(Math.Pow(count,3) + ",");
            count++;
        }
    }
    else{
        while(count>=n){
            Console.WriteLine(Math.Pow(count,3) + ",");
            count--;
        }
    }
}

Console.Write("Введите число N: ");
Number(Convert.ToInt32(Console.ReadLine()));