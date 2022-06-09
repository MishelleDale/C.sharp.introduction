Console.WriteLine("Выясняем какое из двух чисел больше"); //Задаем условие задачи
Console.WriteLine("Введите первое число");

int num1 = Convert.ToInt32(Console.ReadLine()); //Преобразуем число в систему int

Console.WriteLine("Введите второе число");

int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) // Сравниваем два числа через if-else
    Console.WriteLine(num1 + " больше " + num2);

else
   
    Console.Write(num2 + " больше " + num1);
    