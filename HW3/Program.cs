Console.WriteLine("Проверяем, является ли число четным");
Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number%2 == 0)
    Console.Write(Number + " является четным числом");
else
    Console.Write(Number + " не является четным числом");
