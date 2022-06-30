// Задачи семинара

/*
// Console.WriteLine("input integer number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = num * num;
// Console.WriteLine("result is " + result);
*/

// Console.WriteLine("input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = num2 * num2;
// if (num3 == num1){
//     Console.WriteLine("first number is a square of second number");
// }
// else {
//     Console.WriteLine("first number is not a square of second number");
// }

// Console.Write("input number of a day: ");
// int day = Convert.ToInt32(Console.ReadLine());
// if (day<1 || day>7){
//     Console.WriteLine("incorrect day");
// }
// else {
//     if (day==1){
//         Console.WriteLine("Monday");
//     } 
//     if (day==2){
//         Console.WriteLine("Tuesday");
//     } 
// }


// Домашнее задание!!!

// Задача 1. Написать программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.Write("input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1>num2){
//     Console.WriteLine($"{num1} больше, чем {num2}");
// }
// else {
//     if (num1<num2){
//     Console.WriteLine($"{num1} меньше, чем {num2}");
//     }
//     if (num1 == num2){
//         Console.WriteLine($"{num1} равно {num2}");
//     }
// }

// Задача 2. Написать программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.Write("input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("input third number: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// if (num2>num1 & num2>num3){
//     Console.WriteLine($"Максимальное значение - {num2}");
//     }
// if (num3>num1 & num3>num2){
//     Console.WriteLine($"Максимальное значение - {num3}");
//     }
// // if (num1 == num2 == num3){
// //     Console.WriteLine($"Значения равны - {num1=num2=num3}");
// // } 
// // Для равных чисел не получается запустить программу. Выдает ошибку что данный оператор "==" невозможно применить к операнду типа типа "bool" и "int". 
// if (num1>num2 & num1>num3){
//     Console.WriteLine($"Максимальное значение - {num1}");
// }

// Задача 3. Написать программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.Write("iput number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num%2 == 0){
//     Console.WriteLine("Число четное");
// }
// else{
//     if (num%2 != 0){
//     Console.WriteLine ("Число нечетное");
//     }
// }

// Задача 4. Написать программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("iput number: ");
int N = Convert.ToInt32(Console.ReadLine());
int current = 2;
if (N > 1){
    if (N % 2 == 0){
        while (current <= N){
            Console.Write(current + " ");
            current = current + 2;
        }
    }
    else{
        while(current < N){
            Console.Write(current + " ");
            current = current + 2;
        }
    }
}
else {
    Console.Write("Введите число > 1: ");
    Console.Write("iput number: ");
}
// Не понимают как в случает ввода числа меньше 1, оповестить пользователя о необходимости ввести число больше 1 и принять для обработки данное значение.
// Код работает без "int N = Convert.ToInt32(Console.ReadLine());" данного выражения, которое я вводил в заключительном блоке else.
// Если добавляю данную строку, то программа не запускается. Пишет что нельзя объявить переменную "N" в данной области.