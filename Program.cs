// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"



// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// // M = 1; N = 5
// string PrintNumbers (int start, int end)
// {
//    if(start>end)return start.ToString();
//     if (start == end) return start.ToString();
    
//     return (start + "\t" + PrintNumbers(start+1 , end));
// }

// Console.WriteLine(PrintNumbers(M, N));


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите M: ");
// int M = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// // n = 2, p = 3
// //
// int Sum(int number, int secondumber)
// {
//     if (secondumber == number) return number; // number^1 = number 
//     if (secondumber == 0) return 1; // Любое число в 0 степени = 1
//     return number + Sum(number+1, secondumber );
// }

// Console.WriteLine($"Сумма натуральных элементов от {M} до {N} = {Sum(M,N)}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akerman(int x,int y)
{
  if(x<0||y<0)return 0;

 if (x == 0)
    return y + 1;
  else
    if ((x != 0) && (y == 0))
      return Akerman(x - 1, 1);
    else
      return Akerman(x - 1, Akerman(x, y - 1));
  }


Console.WriteLine($"Сумма натуральных элементов от {m} до {n} = {Akerman(m,n)}");
