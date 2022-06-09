Console.WriteLine("Выстаиваем последовательность четных чисел от 1 до N");
Console.WriteLine("Введите число N");

int NumN = Convert.ToInt32(Console.ReadLine());
if (NumN < 1) 
    Console.WriteLine("Введите число от 1");

int index = 1;

while (index <= NumN)
{
    if (index % 2 == 0)
        Console.Write(index + ", ");
    index++;
}