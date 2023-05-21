// string Metod4(int count, string text)
// {
// int i = 0;
// string result = String.Empty;
// while (i<count)
// {
// result = result + text;
// i++;
// }
// return result;
// }
// string res = Metod4(10, "asdf");
// Console.WriteLine(res);



// string Metod4(int count, string text)
// {
// string result = String.Empty;
// for (int i = 0; i<count; i++) 
// // - вначале ключевое слово, затем инициализация
// // счётчика, после проверка условия и инкремент (увеличение счётчика).
// {
// result = result + text;
// }
// return result;
// }
// string res = Metod4(10, "asdf");
// Console.WriteLine(res);



// string Replase(string text, char oldValue, char newValue)
// {
// string result = String.Empty;
// int length = text.Length;
// for (int i = 0; i < length; i++);
// {
// if(text[i] ==oldValue) result + $"{NewValue}"
// else result + $"{str[i]}";
// }
// return result;
// }
// string newText = replace(text, "", " | ");
// Console.WriteLine(newText);

// string Replase(string text, char oldValue, char newValue)
// {
// string result = String.Empty;
// int length = text.Length;
// for (int i = 0; i < length; i++)
// {
// if(text[i] == oldValue) result = result + ($"{NewValue}");
// else result + result $"{text[i]} " ";
// }
// return result;
// }

// string newText = Replace(text, "", " | ");
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, "к ", " К ");
// Console.WriteLine(newText);


// int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
// void PtintArray(int[] array)
// {
// int count = array.Length;
// for (int i = 0; i < count; i++)
// {
// Console.Write($"{array[i]}");
// }
// Console.WriteLine();
// }
// PrintArray(arr);




// int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
// void PtintArray(int[] array)
// {
// int count = array.Length
// for (int i = 0; i < count; i++)
// {
// Console.Write($”{array[i]}”);
// }
// Console.WriteLine();
// }
// void selectionSort(int[] array)
// {
// for (int i = 0; i < array.Length - 1; i++)
// {
// int minPosition = i;
// for (int j = i+1; j < array.Length; j++)
// {
// if(array[j] < array[minPosition]) minPosition = j;
// {
// minPosition = j
// }
// }
// int temporary = array[i]
// array[i] = array[minPosition];
// array[minPosition] = temporary;
// }
// }
// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);