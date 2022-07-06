// Поиск для любого колличества элементов!

int[] array = { 11, 12, 13, 4, 84, 51, 62, 73, 84 };

int n = array.Length;
int find = 84;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index++;
}

