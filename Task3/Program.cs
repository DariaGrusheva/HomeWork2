// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число от 1 до 7: ");
string number = Console.ReadLine();
bool isNumeric = int.TryParse(number, out int weekday);

if (isNumeric)
{
    if (weekday == 6 || weekday == 7)
    {
        Console.WriteLine("Этот день недели - выходной!");
    }
    else if (weekday > 0 && weekday < 6)
    {
        Console.WriteLine("Этот день недели НЕ является выходным!");
    }
    else
    {
        Console.WriteLine("Вы ввели число не принадлежащее отрезку от 1 до 7");
    }
}
else
{
    Console.WriteLine("Введите число от 1 до 7.");
}