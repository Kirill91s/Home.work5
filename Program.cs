// 34 задача
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int ReadInt(string text)
// {
//     System.Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[] FillArray(int size, int beginRange = 100, int endRange = 1000)
// {
//     int[] array = new int[size];
//     Random rand = new Random();

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(beginRange, endRange);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     System.Console.WriteLine(string.Join(", ", array));
// }

// int SumEven(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//             count += 1;
//     }
//     return count;
// }

// 

// int size = ReadInt("Задайте размер массива: ");
// int[] array = FillArray(size);
// PrintArray(array);

// System.Console.WriteLine($"Количество чётных элементов в массиве: {SumEven(array)}");

// 36 задача.
//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int ReadInt(string text)
// {
//     System.Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }


// int[] FillArray(int size, int beginRange = -99, int endRange = 100)
// {
//     int[] array = new int[size];
//     Random rand = new Random();

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(beginRange, endRange);
//     }
//     return array;
// }


// void PrintArray(int[] array)
// {
//     System.Console.WriteLine(string.Join(",  ", array));
// }

// int SumOfOddIndex(int[] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i += 2)
//     {
//         sum += array[i];
//     }
//     return sum;
// }


// int size = ReadInt("Задайте размер массива: ");
// int[] array = FillArray(size);
// PrintArray(array);
// System.Console.WriteLine($"Сумма элементов массива с нечётыми индексами равна: {SumOfOddIndex(array)}");



// 36 задача.
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// int ReadInt(string text)
// {
//     System.Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }


// double[] FillArray(int size, int beginRange = 0, int endRange = 100)
// {
//     double[] array = new double[size];
//     Random rand = new Random();
    
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Math.Round(rand.Next(beginRange, endRange) + rand.NextDouble(), 2);
//     }
//     return array;
// }


// void PrintArray(double[] array)
// {
//     System.Console.WriteLine(string.Join(",  ", array));
// }


// double MinIndex(double[] array)
// {
//     double min = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (min > array[i]) min = array[i];
//     }
//     return min;
// }


// double MaxIndex(double[] array)
// {
//     double max = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (max < array[i]) max = array[i];
//     }
//     return max;
// }

// //--------------------------------------------------------------------------

// int size = ReadInt("Задайте размер массива: ");
// double[] array = FillArray(size);
// PrintArray(array);
// System.Console.WriteLine($"Минимальный элемент массива: {MinIndex(array)}");
// System.Console.WriteLine($"Максимаоьный элемент массива: {MaxIndex(array)}");
// double diff = MaxIndex(array) - MinIndex(array);
// System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна: {Math.Round(diff, 2)}");