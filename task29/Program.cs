/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Clear();
	Console.Write("Введите начальное значение массива: ");
    int start = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите конечное значение массива: ");
    int end = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();

    if (start >= end) {
      Console.WriteLine("Ошибка: начальное значение должно быть меньше конечного!");
      return;
    }

    Console.Write("Введите количество элементов в массиве: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Random rnd = new Random();
    int[] arr = new int[n];

    Console.Write("[");
    for (int i = 0; i < n; i++) {
      arr[i] = rnd.Next(start, end + 1);
      Console.Write(arr[i]);

      if (i != n - 1) {
        Console.Write(", ");
      }
    }
    Console.WriteLine("]");
  }
}
