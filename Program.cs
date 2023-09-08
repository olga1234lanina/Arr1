﻿// задача 29. написать программу, которая задает массив из 8 элементов и выводит их на экран 
// 1,2,5,7,19 -> [1,2,5,7,19]
// 6,1,33     -> [6,1,33]

Console.Clear();
Console.WriteLine("Какое количество будет элементов?");
Console.Write("Вероятность");
int size = int.Parse(Console.ReadLine()!);
int[] array = GetArray(size);
PrintArray(array);

int[] GetArray (int size)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next (1,100);
    }
    return array;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}");
    Console.WriteLine("]");
}