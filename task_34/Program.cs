// Задача 34: 

// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

using static System.Console;
Clear();
WriteLine("Введите длину массива: ");
int len = int.Parse(ReadLine()!);
int[] NewArray = GetArray(len);
WriteLine($"[{String.Join(", ", NewArray)}]");
int EvNum =0;
foreach  (int element in NewArray)
{
    if (element%2==0)
    {
        EvNum+=1;
    }
}
WriteLine($"количество чётных чисел в массиве = {EvNum}");











// Ввод массива

int[] GetArray(int size)
{
    Random rnd = new Random();
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(100, 999+ 1);
    }
    return result;
}