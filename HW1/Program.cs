Console.WriteLine("Выясняем какое из двух чисел больше"); //Задаем условие задачи
Console.WriteLine("Введите первое число");

int num1 = Convert.ToInt32(Console.ReadLine()); //Преобразуем число в систему int

Console.WriteLine("Введите второе число");

int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) // Сравниваем два числа через if-else
    {
    Console.Write(num1);
    Console.Write(" больше ");
    Console.WriteLine(num2);
    }
else
   { 
    Console.Write(num2);
    Console.Write(" больше ");
    Console.WriteLine(num1);
    }