string[] vet = Console.ReadLine().Split(' ');

int A = int.Parse(vet[0]);
int B = int.Parse(vet[1]);

if (A%2 == 0 & B%2 == 0)
{
    Console.WriteLine("Sao Multiplos");
}
else { Console.WriteLine("Nao sao Multiplos"); }