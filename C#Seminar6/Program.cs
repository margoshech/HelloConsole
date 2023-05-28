// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


// int [] CreateArray(int size)
// {
//     int[] numbers = new int[size];
//     System.Console.Write("Массив:");
//     for (int x = 0; x < numbers.Length; x++)
//             numbers[x] = new Random().Next(-15, 15);
//     return numbers;

// }

// void PrintArray(int [] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++)
//         System.Console.Write($" {numbers[i]}");
//     Console.WriteLine();
// }

// void ReversArray(int[] array)
// {
//     int temp=0;
//     for (int i = 0; i < array.Length/2; i++)
//         {
//             // temp = array[i];
//             // array[i] = array[array.Length-1-i];
//             // array[array.Length-1-i] = temp;
//             (array[i] ,array[array.Length-1-i]  ) = (array[array.Length-1-i] ,array[i] );
//         }
// }




// Console.Clear();
// System.Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(size);
// PrintArray(array);
// ReversArray(array);
// PrintArray(array);


// // Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// // Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// bool Check(int a, int b, int c)
// {
//     if (a < b + c && b < a + c && c < a + b) return true;
//     else return false;
// }

// System.Console.WriteLine("Введите сторону a: ");
// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите сторону b: ");
// int b = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите сторону c: ");
// int c = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(Check(a,b,c));


// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// string ChangeDouble(int num)
// {
//     int a = num;
//     string b = string.Empty;
//     while (a > 0)
//     {
//         b = a % 2 + b;
//         a = a / 2;
//     }
//     return b;
// }

// System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(ChangeDouble(num));




// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1Если N = 7 -> 0 1 1 2 3 5 8

// int[] Fibonachi(int num)
// {
//     int[] array = new int[num];
//     array[0] = 0;
//     array[1] = 1;
//     for (int i = 2; i < num; i++)
//     {
//         array[i] = array[i - 1] + array[i - 2];
//     }
//     return array;
// }


// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//         Console.Write($"{item} ");

// }

// System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// PrintArray(Fibonachi(num));


// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// введите количество жэлементов массива
// ввели
// int[] array = new int[m];


// цикл
// введите элемент массива

//  void FillArray(int[] array)
// {
//     for (int i = 0; i< array.Length; i++)
//     {
//         System.Console.WriteLine("Введите элемент массива");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
// }

// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//     {
//         Console.Write($"{item} ");
//     }
//     System.Console.WriteLine();
// }

// int Summa(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i< array.Length; i++)
//     {
//       if (array[i] > 0)
//       {
//         count++;
//       }
//     }
//     return count;
// }

// System.Console.WriteLine("Введите размер массива");
// int m = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[m];
// FillArray(array);
// System.Console.WriteLine("Получен такой массив");
// PrintArray(array);
// System.Console.WriteLine(Summa(array));



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int Search (int b1, int k1, int b2, int k2)

{
   
}

System.Console.WriteLine("Введите сторону a: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите сторону b: ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите сторону c: ");
int c = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Check(a,b,c));