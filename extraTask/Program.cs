﻿// Доп задача "Сбор черники".
// Кусты черники высажены по окружности. У каждого куста есть ровно 2 соседних. 
// Всего на грядке N кустов. На каждом кусте разное число ягод – на i-ом кусте 
// выросло ai ягод. При сборе собирают ягоды с куста и с 2 соседних рядом с ним.

// Напишите программу для нахождения max числа ягод, которое можно собрать 
// за 1 заход. N (3 ≤ N ≤ 1000) – количество кустов черники. ai < 1000.
// a1, a2, ..., aN – число ягод черники, растущее на соответствующем кусте. 

// Входные данные: 1). N = 4; ai = 1, 2, 3, 4. 
//                 2). N = 3; ai = 1, 2, 3.

Console.Clear();

int [] arr = {1, 2, 3, 4};

int count = arr.Length;
Console.WriteLine($"Количество кустов: {count}");

Console.Write("Количество ягод на каждом кусте соответственно: ");

void PrintArray(int[]array)
{
    int count = array.Length;

    for (int i = 0; i<count; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}
PrintArray(arr);

Console.WriteLine();
Console.Write("Максимальное число ягод, которое можно собрать за 1 заход на заданной грядке: ");

int i1 = arr[0]+arr[1]+arr[2];
int i2 = arr[1]+arr[2]+arr[3];
int i3 = arr[2]+arr[3]+arr[0];
int i4 = arr[3]+arr[0]+arr[1];

int max = i1;

if(i2>i1) max = i2;
if(i3>i2) max = i3;
if(i4>i3) max = i4;


Console.WriteLine(max);
