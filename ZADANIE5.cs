// using System;
// using System.Linq;

// Console.Write("Введите 9 чисел через пробел: ");

// int[] arr = (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

// Console.WriteLine("\nБыло:");
// for (int i = 0; i < 9; i++) 
//     Console.Write(arr[i] + (i % 3 == 2 ? "\n" : " "));

// Console.WriteLine("\nСтало:");
// for (int i = 0; i < 3; i++)
//     Console.WriteLine($"{arr[i]} {arr[i + 3]} {arr[i + 6]}");
