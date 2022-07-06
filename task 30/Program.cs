/* Задача 30: Напишите программу, которая выводит массив из 8 элементов,
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */

void FillArray(int[] any_array)
{
    for (int i = 0; i < any_array.Length; i++)
    {
        any_array[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] any_array)
{
    Console.Write("[");
    for (int i = 0; i < any_array.Length; i++)
    {
        Console.Write($"{any_array[i]}");
        if (i < any_array.Length - 1)
        {

            Console.Write(", ");

        }
    }

    Console.Write("]");
}
int[] array = new int[8];
FillArray(array);
PrintArray(array);
