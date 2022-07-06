// Разворот и сортировка массива по убыванию!

int[] masiv = { 10, 6, 3, 8, 2, 5, 4, 9, 7, 1 };
for (int i = 0; i < masiv.Length; i++)
{
    Console.Write(masiv[i] + " ");
}
Array.Sort(masiv);
Array.Reverse(masiv);
Console.WriteLine();
for (int i = 0; i < masiv.Length; i++)
{
    Console.Write(masiv[i] + " ");
}
Console.Read();



