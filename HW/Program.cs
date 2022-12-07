// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число A ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B ");
// int B = Convert.ToInt32(Console.ReadLine());
// int P = 1;
// for (int i = 1; i <= B; i++)
//     P = P*A;
// Console.WriteLine(P);

// ______________________________________________________

// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число A ");
// int A = Convert.ToInt32(Console.ReadLine());
// int S = 0;
// while(A>0)
// {
// S = S + A%10;
// A /= 10;
// }
// Console.WriteLine(S);

// ____________________________________

// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// int [] numbers = new int[8];
// Console.Write("[");

// for (int i = 0; i < numbers.Length; i++)
//  {
//     numbers [i] = new Random().Next(0, 100);
//     Console.Write(" " + Numbers (i) +  " ");
//  }
// Console.Write("]");

// int Numbers (int N)
// {
//     return numbers[N];
// }