Console.Write("Determine o valor de x: ");
double x = double.Parse(Console.ReadLine());

Console.Write("Determine o valor de y: ");
double y = double.Parse(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Q1");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Q2");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Q4");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Q3");
}
else if (x == 0.0)
{
    Console.WriteLine("Eixo Y");
}
else if (y == 0.0)
{
    Console.WriteLine("Eixo X");
}
else
{
    Console.WriteLine("Origem");
}