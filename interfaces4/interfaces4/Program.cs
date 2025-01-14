using System.Globalization;

Console.WriteLine("Enter contract data:");
Console.Write("Number: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Date (dd/MM/yyyy): ");
DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
Console.Write("Contract value: ");
double value = double.Parse(Console.ReadLine());

