// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

// Console.WriteLine("Введите трехзначное число");
// int num =  Convert.ToInt32(Console.ReadLine());
// int num1 = num/100;
// int num3 = num%10;
// int num2 = num/10%10;
// Console.WriteLine(num2);



// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 100)
// {
//     Console.WriteLine("ошибка,третьей цифры нет");
//     System.Environment.Exit(1);
// }
// int count = 0;
// int i = num;
// while (i > 1000) {
//     i = i / 10;
// }
// int res = i % 10;
// Console.WriteLine(res);


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] weekends = {6, 7};
// int[] weekday = {1,2,3,4,5};
// if (num > 7 || num < 1)
// {
//     Console.WriteLine("ошибка,введите число от 1 до 7");
//     System.Environment.Exit(1);
// }

// if (weekends.Contains(num)) 
// {
// Console.WriteLine("выходной");
// }

// if (weekday.Contains(num))
// {
//     Console.WriteLine("будний");
// }


// Задача необязательная 2:

// В институте биоинформатики по офису передвигается робот. Недавно студенты из группы программистов написали для него программу, по которой робот, когда заходит в комнату, считает количество программистов в ней и произносит его вслух: "n программистов".

// Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание слова.

// Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), выводящее это число в консоль вместе с правильным образом изменённым словом "программист", для того, чтобы робот мог нормально общаться с людьми, например: 1 программист, 2 программиста, 5 программистов.

// В комнате может быть очень много программистов. Проверьте, что ваша программа правильно обработает все случаи, как минимум до 1000 человек.

// Console.WriteLine("Введите число программистов");
// int num = Convert.ToInt32(Console.ReadLine());

// int lastDigit = num % 10;

// int[] mn = {2,3,4};
// int[] excludes = {11, 12, 13, 14};

// if (lastDigit == 1 && !excludes.Contains(num))
// {
//     Console.WriteLine($" {num} программист");
// }
// else if (mn.Contains(lastDigit) && !excludes.Contains(num))
// {
//     Console.WriteLine($" {num} программиста");
// }
// else
// {
//     Console.WriteLine($" {num} программистов");
// }







// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.WriteLine("Введите координату X");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x>0 && y>0)
//     Console.WriteLine("Это четверть № 1");
// else if (x>0 && y<0)
//     Console.WriteLine("Это четверть № 4");
// else if (x<0 && y<0)
//     Console.WriteLine("Это четверть № 3");
// else if (x<0 && y>0)
//     Console.WriteLine("Это четверть № 2");
// else 
//     Console.WriteLine("Точка лежит на координатной оси");



    // Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// void CheckKoord(int x, int y)
// {
//     if (x>0 && y>0)
//         Console.WriteLine("Это четверть № 1");
//     else if (x>0 && y<0)
//         Console.WriteLine("Это четверть № 4");
//     else if (x<0 && y<0)
//         Console.WriteLine("Это четверть № 3");
//     else if (x<0 && y>0)
//         Console.WriteLine("Это четверть № 2");
//     else 
//         Console.WriteLine("Точка лежит на координатной оси");
// }




// Console.WriteLine("Введите координату X");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y");
// int y = Convert.ToInt32(Console.ReadLine());
// CheckKoord(x,y);


// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// string ReturnHello()
// {
//     return "Hello!";
// }

// ReturnHello();


// Console.WriteLine("Введите число от 1 до 4");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Koord(x));




// string CheckKoord(int num)
// {
//     string result = "";
//     if (num == 1)
//         result = "x > 0, y > 0";
//     else if (num == 2)
//         result = "x < 0, y > 0";
//     else if (num == 3)
//         result = "x < 0, y < 0";
//     else if (num == 4)
//         result = "x > 0, y < 0";
//     return result;
// }



// try
// {
//     Console.WriteLine("Введите номер четверти от 1 до 4: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     string rez = CheckKoord(num);
//     if (rez != "")
//         Console.WriteLine($"Координаты могут быть {CheckKoord(num)}");
//     else
//         Console.WriteLine("Были введены некорректные данные");
// }
// catch
// {
//     Console.WriteLine("Надо было вводить целые числа");
// }





// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
// */


// string Kvadr (int num)
// {
//     string rez = ", ";
//     int i = 1;
//     while (i<=num)
//     {
//        rez=rez+" "+ Math.Pow(i, 2);
//        i++;
//     }
//     return rez;
// }

// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine()); // 55
// Console.WriteLine(Kvadr(num));


// int Sum(int x, int y)
// {
//     int result = (x + y);
//     return result;
// }

// int x1 = 1;
// int y1 = 6;

// int x2 = 4;
// int y2 = 6;

// ///

// int z = Sum(x1, y1);
// // int z2 = Sum(x2, y2);
// int r = Sum(10, 99);



// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


// double Rast(double x1, double y1, double x2, double y2)
// {
// return Math.Sqrt((Math.Pow(x2 - x1,2)) + (Math.Pow(y2 - y1,2)));
// }


// Console.WriteLine("Введите Координату x1 для точки А");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координату y1 для точки А");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координату x2 для точки B");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координату y2 для точки B");
// double y2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Расстояние между двяму точками равно: {Math.Round(Rast(x1,y1,x2,y2),3)}");










// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.WriteLine("Введите любое число:");
// int num_max = Convert.ToInt32(Console.ReadLine());
// int num_min = 1;
// double resault = 0;
// while (num_min <= num_max)
// {
//     resault = (Math.Pow(num_min,2));
//     Console.Write($" {resault}");
//     num_min++;
// }




// ДЗ Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Console.WriteLine("Введите любое число:");
// int num = Convert.ToInt32(Console.ReadLine());
// for(int i = 1; i <= num; i++)
// {
//     Console.WriteLine($"{ Math.Pow(i, 3) }");
// }


// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// double Rast(double x1, double y1, double a1, double x2, double y2, double a2)
// {
//     return Math.Sqrt((Math.Pow(x2 - x1,2)) + (Math.Pow(y2 - y1,2)) + (Math.Pow(a2 - a1,2)));
// }


// Console.WriteLine("Введите Координату x1 для точки А");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координату y1 для точки А");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координату a1 для точки A");
// double a1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координату x2 для точки B");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координату y2 для точки B");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координату a2 для точки B");
// double a2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Расстояние между двумя точками равно: {Math.Round(Rast(x1,y1,a1,x2,y2,a2),2)}");


// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int numCopy = num;
// int reverse = 0;

// while (numCopy >0)
// {
//     int digit = numCopy % 10;

//     reverse = reverse * 10 + digit;

//     numCopy = numCopy / 10;

// }

// if (num == reverse)
// {
//     Console.WriteLine("полиндром");
// }
// else
// {
//     Console.WriteLine("не полиндром");
// }
