﻿// 1
// int summa(int num)
// {
//     int res=0;
//     for (int i=1; i<=num; i++) {
//     res = res + i;
//     }
//     return res;
// }

// try
// {
// System.Console.WriteLine("Введите натуральное число");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Сумма всех чисел от 1 до {num} равна {summa(num)}");
// }
// catch
// {
//     System.Console.WriteLine("Надо вводить именно целое число!!!");
// }


//2
// int Result(int x)
// {
//     int count = 0;
//     while (x > 0)
//     {
//         x = x / 10;
//         count++;
//     }
//     return count;
// }

// System.Console.WriteLine("Введите любое число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Колличество цифр в числе: {Result(num)}");



//3

// int Resault(int num)
// {
//     int result = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         result *= i;
//     }
//     return result;
// }

// System.Console.WriteLine("Введите любое число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Факториал числа: {Resault(num)}");


// 4
// int[] CreateArray(int n)
// {
//     Random random = new Random();
//     int[] numbers = new int[n];
//     System.Console.Write("Массив:");
//     for (int x = 0; x < numbers.Length; x++)
//     {
//         numbers[x] = random.Next(0, 2);
//     }
//     return numbers;
// }

// void PrintArray(int [] numbers)
// {
//     for (int x = 0; x < numbers.Length; x++)
//     System.Console.Write($" {numbers[x]}");
//     Console.WriteLine();
// }

// double Result(int [] numbers)
// {
//     double summ = 0;
//     for (int x = 0; x < numbers.Length; x++)
//     {
//         summ += numbers[x];
//     }
//     return summ / numbers.Length;
// } 

// int [] numbers = CreateArray(8);
// PrintArray(numbers);
// Console.WriteLine($"Среднне врифмитическое массива: {Result(numbers)}");
