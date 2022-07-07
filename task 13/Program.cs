// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int n;
n = Convert.ToInt32(Console.ReadLine());
if (n % 100 == n)
    Console.WriteLine("Число меньше 100");
else
{
    Console.WriteLine(Convert.ToString(n)[2]);
}

