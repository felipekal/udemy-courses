﻿using System.Globalization;

Console.WriteLine("Enter contract data:");

Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Date (dd/MM/yyyy): ");
DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

Console.Write("Contract value: ");
double value = double.Parse(Console.ReadLine());

Console.Write("Enter the number of installments: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Installments: ");

Console.WriteLine();

