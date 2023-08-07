// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
string number = Console.ReadLine();
bool isNumeric = int.TryParse(number, out int n);

int i = 100;
int a = 0;
int b = 0;
int c = 0;

if (isNumeric)
{
    if (Math.Abs(n / 100) >= 1)
    {
        while (Math.Abs(n / i) >= 1)
        {
            c = i;
            i = i * 10;
        }
        a = Math.Abs(n) / (c / 100);
        b = a % 10;
        Console.WriteLine($"Третья цифра введенного Вами числа: {b}");
    }
    else
    {
        Console.WriteLine("В данном числе нет третьей цифры.");
    }
}
else
{
    Console.WriteLine("Введите число!");
}