// Задача 36: 

// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



using static System.Console;
Clear();
WriteLine("Введите длину массива: ");
int len = int.Parse(ReadLine()!);
WriteLine("Введите минимальное значение: ");
int MinNum = int.Parse(ReadLine()!);
WriteLine("Введите максимальное значение: ");
int MaxNum = int.Parse(ReadLine()!);
int[] NewArray = GetArray(len, MinNum, MaxNum);
WriteLine($"[{String.Join(", ", NewArray)}]");

int EvNumSum = 0;

for (int i = 0; i < NewArray.Length; i++)
{
    if (i % 2!= 0)
    {
        EvNumSum = EvNumSum + NewArray[i];
    }
}
WriteLine($"Cумма элементов, стоящих на нечётных позициях = {EvNumSum}");










// Ввод массива

int[] GetArray(int size, int min, int max)
{
    Random rnd = new Random();
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(min, max + 1);
    }
    return result;
}