// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());

double count = 1;

for (int i = 0; i <= b; i++)
{
    count = Math.Pow(a, b);
}
Console.WriteLine($"Число A в степени B: {count}");