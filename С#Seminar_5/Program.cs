// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из 
// промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел 
// равна 29, сумма отрицательных равна -20.

// void FillArray(int[] array)
// {
//     for (int i =0; i<array.Length;i++)
//         array[i] = new Random().Next(-9,10);
// }

// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//         Console.Write($"{item} ");
//     System.Console.WriteLine();
// }

// int[] FindSums(int[] array)
// {
//     int sum_p=0;
//     int sum_n=0;
//     foreach (int item in array)
//         if (item>0)
//             sum_p+=item;
//         else    
//             sum_n+=item;
//     int[] result = {sum_p,sum_n};
//     return result;
// }


// Console.Clear();
// int [] array = new int[12];
// FillArray(array);
// System.Console.WriteLine("Сгенерировался такой массив");
// PrintArray(array);
// int [] rez = FindSums(array);
// //PrintArray(FindSums(array));
// System.Console.WriteLine($"Сумма положительных элементов равна {rez[0]}");
// System.Console.WriteLine($"Сумма отрицательных элементов равна {rez[1]}");



// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// void FillArray(int [] array)
// {
//     for (int i = 0; i< array.Length; i++)
//     {
//         array[i] = new Random().Next(-9,10);
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

// void ConvertArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             array[i] *= -1;
//         }
//         else 
//         {
//             array[i] = Math.Abs(array[i]);
//         }
//     }
// }

// int[] array = new int[4];
// FillArray(array);
// System.Console.WriteLine("Сгенерирован такой массив");
// PrintArray(array);
// System.Console.WriteLine("Массив изменен на");
// ConvertArray(array);
// PrintArray(array);


// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

//  void FillArray(int [] array)
// {
//     for (int i = 0; i< array.Length; i++)
//     {
//         array[i] = new Random().Next(-345,345);
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

// void SearchNum(int[] array, int num)
// {
//     bool isExist = false;

//     foreach (int item in array)
//     {
//         if (item == num)
//         {
//             isExist = true;
//         }
//     }

//     if (isExist == true)
//     {
//         System.Console.WriteLine("Да");
//     }
//     else
//     {
//         System.Console.WriteLine("Нет");
//     }
// }

// int[] array = new int[8];
// FillArray(array);
// System.Console.WriteLine("Сгенерирован такой массив");
// PrintArray(array);
// System.Console.WriteLine("Введите искомое число");
// int num = Convert.ToInt32(Console.ReadLine());
// SearchNum(array, num);




// void FillArray(int[] array)                       /////// без bool
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10);
// }

// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//         Console.Write($"{item} ");
//     System.Console.WriteLine();
// }

// void Search(int[] array, int num)
// {
//     foreach (int item in array)
//         if (item == num)
//         {
//             System.Console.WriteLine("да");
//             return;
//         }
//         else
//             System.Console.WriteLine("нет");
// }

// int [] array = new int[4];
// FillArray(array);
// System.Console.WriteLine("Сгенерировался такой массив");
// PrintArray(array);

// System.Console.WriteLine("введите проверяемое число");
// int num = Convert.ToInt32(Console.ReadLine());

// Search(array,num);



// Задача 35: Задайте одномерный массив из 15 случайных чисел в диапазоне от -100 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 15 элементов. В своём решении сделайте для 15
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5



// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-100, 100);
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

// int SearchCount(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 10 && array[i] <= 99)
//         {
//             count += 1;
//         }
//     }
//     return count;
// }


// int[] array = new int[15];
// FillArray(array);
// System.Console.WriteLine("Сгенерировался такой массив");
// PrintArray(array);
// System.Console.WriteLine($"В диапазоне от 10 до 99 найдено {SearchCount(array)} чисел");




// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 999);
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

// int SearchCount(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i]  % 2 == 0)
//         {
//             count += 1;
//         }
//     }
//     return count;
// }


// int[] array = new int[4];
// FillArray(array);
// System.Console.WriteLine("Сгенерировался такой массив");
// PrintArray(array);
// System.Console.WriteLine($"Найдено {SearchCount(array)} четных чисел");


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-100, 100);
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
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0)
//         {
//             sum += array[i];
//         }
//     }
//     return sum;
// }


// int[] array = new int[4];
// FillArray(array);
// System.Console.WriteLine("Сгенерировался такой массив");
// PrintArray(array);
// System.Console.WriteLine($"Сумма нечетных чисел в массиве - {Summa(array)}");



// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// void FillArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-100, 100);
//     }
// }

// void PrintArray(double[] array)
// {
//     foreach (double item in array)
//     {
//         Console.Write($"{item} ");
//     }
//     System.Console.WriteLine();
// }

// double Summa(double[] array)
// {
//     double sum = 0;
//     double max = 0;
//     double min = 0;
//     for (int i = 0; i < array.Length; i++)
//     {  

//         if (array[i] > max)
//         {
//             max = array[i];
//         }
        
//         if (array[i] < min)
//         {
//             min = array[i];
//         }
//     }

//     sum = max + min;
//     return sum;
// }


// double[] array = new double[4];
// FillArray(array);
// System.Console.WriteLine("Сгенерировался такой массив");
// PrintArray(array);
// System.Console.WriteLine($"Сумма нечетных чисел в массиве: {Summa(array)}");
