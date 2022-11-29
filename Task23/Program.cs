//Задача 23. Программа на вход принимает число (N),
//и выдает таблицу кубов чисел от 1 до N.

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
    Console.Write($"{Math.Pow(i,3)},");