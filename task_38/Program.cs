// Задача 38:
// Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементами массива.

// [3 7 22 2 78] -> 76

using static System.Console;
Clear();
WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(ReadLine());
int[] array = GetArray(size);
WriteLine($"[{String.Join(", ", array)}]");









// Ввод массива

int[] GetArray(int Length)
{
    Random rnd = new Random();
    int[] result = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        result[i] = rnd.Next(-99, 100);
    }
    int min = result[0];
    int max = result[0];
    int sum = 0;
    for (int j = 0; j < Length; j++)
    {
        if (result[j] < min)
        {
            min = result[j];
        }
        else
        {
            if (result[j] > max)
            {
                max = result[j];
            }
        }
    }
    WriteLine();
    WriteLine($"разница между {max} и {min} элементами массива = {max - min}");
    WriteLine();
    return result;
}

