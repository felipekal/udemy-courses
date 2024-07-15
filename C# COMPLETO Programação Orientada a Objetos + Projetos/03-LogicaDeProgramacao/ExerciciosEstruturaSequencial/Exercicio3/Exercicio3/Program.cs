Console.Write("Insira um valor inteiro A: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Insira um valor inteiro B: ");
int B = int.Parse(Console.ReadLine());

Console.Write("Insira um valor inteiro C: ");
int C = int.Parse(Console.ReadLine());

Console.Write("Insira um valor inteiro D: ");
int D = int.Parse(Console.ReadLine());

var resultado = (A * B) - (C * D);

Console.WriteLine($"DIFERENCA = {resultado}");