// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write("Введите длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array= GetArray(size) ;
int count = GetOverZeroArray(array);
PrintArray(array,count);
int [] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = Convert.ToInt32(Console.ReadLine());
    }
    return res;
}
int GetOverZeroArray(int []res)
{
    int overZero = 0;
    for (int i = 0; i < size; i++)
    {  
        if (array[i]<0)
        {
            overZero++;
        }
    }
    return overZero;
 }
 
void PrintArray(int[] array, int count)
{
    Console.WriteLine($"Чисел меньше нуля в массиве: [{String.Join("; ", array)}]->{count}");
}


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Write("Введите значение b1 : ");
float b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1 : ");
float k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2 : ");
float b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2 : ");
float k2 = Convert.ToInt32(Console.ReadLine());
float x = GetX(b1,b2,k1,k2);
float y = GetY1(b1,k1,x);
PrintGetCoordinat(x,y);
float GetX(float b1 , float b2 ,float k1,float k2)
{
    x=0;
 if((k1-k2)==0)
 {
    Console.WriteLine("Ошибка: Деление на ноль");
    return x;
 }
 x = (b2-b1)/(k1-k2);

 return x;
}
float GetY1(float b1,float k1,float x)
{
    y = k1*x+b1;
   return y;
}
void PrintGetCoordinat(float x,float y)
{
 Console.WriteLine($"b1 = {b1},k1 = {k1},b2 = {b1},k2 = {k2} -> ({x};{y})");
}