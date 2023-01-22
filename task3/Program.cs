// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите номер дня недели: ");
string number = Console.ReadLine();
int dayoff = Convert.ToInt32(number);
if (dayoff > 5)
{
    string[] week = new string [] {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
    System.Console.WriteLine($"Выходной");
}
else
{
    System.Console.WriteLine("рабочий день");
}
