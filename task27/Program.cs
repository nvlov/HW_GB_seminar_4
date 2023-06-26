/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Clear();
	Console.Write("Введите число: ");
    string numString = Console.ReadLine();

    int sum = 0;

    for (int i = 0; i < numString.Length; i++) {
      sum += int.Parse(numString[i].ToString());
    }

    Console.WriteLine("Сумма цифр в числе: " + sum);
  }
}
