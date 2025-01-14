﻿ using System.Globalization;
using AluguelCarros.Entities;
using AluguelCarros.Services;


Console.WriteLine("Enter rental data:");
Console.WriteLine("Car model: ");
string model = Console.ReadLine();
Console.WriteLine("Pickup: ");
DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);
Console.WriteLine("Return: ");
DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);

Console.WriteLine("Enter price per hour: ");
double hour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine("Enter price per day: ");
double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

CarRental carRental = new CarRental(start, finish, new Vehicle(model));

RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

rentalService.ProcessInvoice(carRental);

Console.WriteLine("INVOICE: ");
Console.WriteLine(carRental.Invoice);

