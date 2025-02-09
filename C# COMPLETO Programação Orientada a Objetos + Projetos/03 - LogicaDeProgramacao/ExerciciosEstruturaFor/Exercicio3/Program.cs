using System.Globalization;

int n = int.Parse(Console.ReadLine());

double resultado = 0;
for (int i = 0; i < n; i++)
{
    string[] valores = Console.ReadLine().Split(' ');

    double a = double.Parse(valores[0]);
    double b = double.Parse(valores[1]);
    double c = double.Parse(valores[2]);

    resultado = ((a * 2) + (b * 3) + (c * 5)) / (2 + 3 + 5);

    double[] resultados = 
}
Console.WriteLine(resultado.ToString("F1"));
