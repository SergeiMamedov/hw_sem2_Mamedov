// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int InputInt(string msg)
{
    Console.WriteLine(msg);
    int g = Convert.ToInt32(Console.ReadLine());
    return g;
}
int a = InputInt("Введите число: ");
if (a < 99)
{
    System.Console.WriteLine("В числе нет третьей цифры");
}
else 
{
    while (a > 1000)
    {
        a = a / 10;
    }
    System.Console.WriteLine($"Третья цифра числа равна: {a % 10} "); 
}
