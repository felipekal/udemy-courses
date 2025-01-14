using System.Globalization;

DateTime d1 = DateTime.Now;
Console.WriteLine(d1);
Console.WriteLine(d1.Ticks);

DateTime d2 = new DateTime(2018, 11, 25);

Console.WriteLine(d2);

DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 03);


Console.WriteLine(d3);

DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 03, 500);

Console.WriteLine(d4);

DateTime d5 = DateTime.Today;

Console.WriteLine(d1);
Console.WriteLine(d5);

DateTime d6 = DateTime.UtcNow;

Console.WriteLine(d6);

//Parse

DateTime d7 = DateTime.Parse("2000-08-15");

Console.WriteLine(d7);

DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");

Console.WriteLine(d8);

DateTime d9 = DateTime.Parse("15/08/2000");

Console.WriteLine(d9);

DateTime d10 = DateTime.Parse("15/08/2000 13:05:08");

Console.WriteLine(d10);

//Parse Exact

DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);

Console.WriteLine(d11);

DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

Console.WriteLine(d12);

