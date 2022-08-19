// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

double[] array = { 3, 0.5, -5, 7.3, 1.1, -4.2 };
int index = 0;
double min = array[index];
double max = array[index];

for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];  
    }

Console.WriteLine($"Массив: [{String.Join("; ", array)}]");
Console.WriteLine($"Максимальный элемент: {max}, Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами: {max - min}");