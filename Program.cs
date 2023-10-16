
Console.Write("Введите число: ");
string stringNumber = Console.ReadLine();
int number; 
bool isNumber = int.TryParse(stringNumber, out number);
Console.WriteLine($"Длина строки(кол-во символов): {stringNumber.Length}");
if (isNumber && stringNumber.Length <= 3) // isNumber == True
{
    Console.WriteLine("Ваша строчка состоит ТОЛЬКО из цифр");
    Console.WriteLine($"{stringNumber} => {stringNumber[1]}");
}
else
{
    Console.WriteLine(" длина строки < 3 символов");
}