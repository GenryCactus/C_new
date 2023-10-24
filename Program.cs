
// Console.Write("Введите число: ");
// string stringNumber = Console.ReadLine();
// int number; 
// bool isNumber = int.TryParse(stringNumber, out number);
// if (isNumber && stringNumber.Length >= 6) 
// {
//     Console.WriteLine("Число не пятизначное");
//     if ( stringNumber.Length <= 4) 
//     {
//      Console.WriteLine("Число не пятизначное");
//     }
// }
// else if (stringNumber [0] == stringNumber[4] && stringNumber [1] == stringNumber[3])
// {    
//      Console.WriteLine($"{stringNumber} -> True");
// }  
// else
// {
//  Console.WriteLine($"{stringNumber} -> False");
// }


// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Введите число А: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int Degreed = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{number} в натуральной степени {Degreed} = {GetDegree(number, Degreed)}");
// double GetDegree (int number,int Degreed)
// { 
//     int degree = Degreed ;
//     int chapt = number;
//     double pow = Math.Pow(chapt,degree );
//     return pow ;
// }

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Введите число : ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма всех чисел {number} -> {SumAllDigit(number)} ");
// int SumAllDigit(int number)
// {
//  int result = 0 ;
//  while (number> 0)
//  {
//   result+= number %10;
//   number = number/10; 
//  }
//  return result;
// }

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] result = GetBinaryArray(8); 
//  Console.WriteLine($"[{String.Join("; ", result)}]");

// int[] GetBinaryArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++) // array.Length = size
//     {
//         array[i] = new Random().Next(0,100); 
//     }
//     return array;
// }