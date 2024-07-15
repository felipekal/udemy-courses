Console.WriteLine("Insira o primeiro produto como o que segue: COD UNIT VAL");
string[] vet1 = Console.ReadLine().Split(' ');
Console.WriteLine("Insira o segundo produto como o que segue: COD UNIT VAL");
string[] vet2 = Console.ReadLine().Split(' ');

int cod1 = int.Parse(vet1[0]);
int unit1 = int.Parse(vet1[1]);
decimal valor = decimal.Parse(vet1[2]);

int cod2 = int.Parse(vet2[0]);
int unit2 = int.Parse(vet2[1]);
decimal valor2 = decimal.Parse(vet2[2]);

var result = (unit1 * valor) + (unit2 * valor2);

Console.WriteLine($"VALOR A PAGAR: R$ {result:F2}");