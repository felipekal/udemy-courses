Console.Write("Digite o valor para calcular o raio de um circulo: ");

double _ = double.Parse(Console.ReadLine());

//const double pi = 3.14159;

var result = Math.PI * (Math.Pow(_,2));

Console.WriteLine($" {result:F4}");
