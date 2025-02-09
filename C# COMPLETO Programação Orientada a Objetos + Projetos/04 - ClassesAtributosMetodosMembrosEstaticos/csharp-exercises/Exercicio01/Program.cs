using Exercicio01;

Retangulo retangulo = new Retangulo();

Console.WriteLine("Entre a Largura e Altura de um retângulo: ");
retangulo.Lado = double.Parse(Console.ReadLine());
retangulo.Altura = double.Parse(Console.ReadLine());

Console.WriteLine($"AREA: {retangulo.Area(retangulo.Lado, retangulo.Altura)}");
Console.WriteLine($"PERIMETRO: {retangulo.Perimetro(retangulo.Lado, retangulo.Altura)}");
Console.WriteLine($"DIAGONAL: {retangulo.Area(retangulo.Lado, retangulo.Altura)}");

