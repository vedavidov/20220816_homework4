// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];

Console.WriteLine("Вывод массива из 8 элементов: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 11);
    Console.Write(array[i]);
    Console.Write(", ");
}