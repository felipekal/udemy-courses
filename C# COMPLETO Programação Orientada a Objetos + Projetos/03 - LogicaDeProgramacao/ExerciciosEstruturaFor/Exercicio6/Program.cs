﻿int n = int.Parse(Console.ReadLine());

int div = 0;
for (int i = 1; i < n; i++)
{
    if (n % i == 0)
    {
        Console.WriteLine(i);
    }
}