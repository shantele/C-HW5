﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[4];
int sumUneven = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);
}

for (int i = 1; i < array.Length; i += 2)
{
    sumUneven += array[i];
}

Console.WriteLine($"Массив: [{String.Join("; ", array)}]");
Console.WriteLine($"Сумма элементов на нечётных позициях: {sumUneven}");