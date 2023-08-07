// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
string number = Console.ReadLine();
bool isNumeric = int.TryParse(number, out int n);

int hundreds = Math.Abs(n % 100);
int dozens = Math.Abs(hundreds / 10);

if (isNumeric)
{
    if (n / 100 == 0 || n / 100 > 9 || n / 100 < -9)
    {
        Console.WriteLine("Вы ввели не трехзначное число.");
    }
    else
    {
        Console.WriteLine($"Вторая цифра введенного Вами числа: {dozens}");
    }
}
else
{
    Console.WriteLine("Введите число!");
}