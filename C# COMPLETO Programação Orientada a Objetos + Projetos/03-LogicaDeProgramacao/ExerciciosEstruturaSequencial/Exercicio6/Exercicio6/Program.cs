Console.Write("Insira os Lados do triangulo, sendo A B C: ");
string[] vet = Console.ReadLine().Split(' ');

double A = double.Parse(vet[0]);
double B = double.Parse(vet[1]);
double C = double.Parse(vet[2]);


var trianguloRetangulo = (A * C) / 2;
var areaCirculo = Math.PI * (Math.Pow(C, 2));
var areaTrapezio = (A + B) * C / 2;
var areaQuadrado = Math.Pow(B, 2);
var areaRetangulo = A * B;

Console.WriteLine($"TRIANGULO: {trianguloRetangulo:F3}");
Console.WriteLine($"CIRCULO: {areaCirculo:F3}");
Console.WriteLine($"TRAPEZIO: {areaTrapezio:F3}");
Console.WriteLine($"QUADRADO: {areaQuadrado:F3}");
Console.WriteLine($"RETANGULO: {areaRetangulo:F3}");

