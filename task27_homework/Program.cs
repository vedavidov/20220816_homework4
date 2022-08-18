// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
string num = Convert.ToString(number);

int sum = 0;

while (number != 0)
{
    int num2 = number % 10;
    number = number / 10;
    sum = sum + num2;
}
Console.WriteLine($"Сумма цифр числа {num} равна {Math.Abs(sum)} ");