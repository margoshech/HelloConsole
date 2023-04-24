// Напишите программу, которая выводит случайное число из отрезка [10, 99] и 
// показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// int num = new Random().Next(10,100);
// Console.WriteLine($"Было сгенерировано число {num}");
// // Console.WriteLine("Было сгенерировано число "+num);
// int num1 = num/10;
// int num2 = num % 10;
// if (num1>num2) 
//     Console.WriteLine($"Наибольшая цифра это {num1}");
// else if (num1<num2)
//     Console.WriteLine($"Наибольшая цифра это {num2}");
// else
//     Console.WriteLine("Обе цифры этого числа равны");

// for (int i=1; i<=num; i=i+3)
//     Console.Write($"{i} ");




// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// int num = new Random().Next(100,1000);
// int num1 = num/100;
// int num3 = num%10;
// int num2 = num/10%10;
// int result = num1*10+num3;
// Console.WriteLine(num);
// Console.WriteLine(result);
// Console.WriteLine($"Из числа {num} удалили цифру {num2} и получили число {result}");


// Console.Write("Введите первое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num_krat = Convert.ToInt32(Console.ReadLine());
// if (num%num_krat == 0)
// {
//     Console.WriteLine("кратно");
// }
// else
// {
//     Console.WriteLine($"Не кратно, остаток {num%num_krat}");
// }




// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Console.Write("Введите первое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 7 == 0 && num % 23 == 0)
// {
//     Console.WriteLine("кратно");
// }
// else
// {
//     Console.WriteLine($"{num} Не кратно 7 и 23");
// }




// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// Console.Write("Введите первое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num * num == num2 || num2 * num2 == num)
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }


// На входе от пользователя целое число любой разрядности, надо удалить вторую слева цифру этого числа

// Console.WriteLine("Введите число :");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// int i = num;
// while (i > 0) {    
//    i = i / 10;
//    count ++;
// }
// int res = num / Convert.ToInt32(Math.Pow(10, count -1)) * Convert.ToInt32(Math.Pow(10, count - 2)) + num % (Convert.ToInt32(Math.Pow(10, count - 2)));
// //256 / 100

// Console.WriteLine(res);
