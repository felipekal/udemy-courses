int input = int.Parse(Console.ReadLine());

int gasolina = 0;
int alcool = 0;
int diesel = 0;
while (input != 4)
{
    if (input == 2)
    {
        gasolina++;
    }
    if(input == 1)
    {
        alcool++;
    }
    if( input == 3) { diesel++; }
    
    input = int.Parse(Console.ReadLine());

}

Console.WriteLine("MUITO OBRIGADO");
Console.WriteLine($"Alcool: {alcool}");
Console.WriteLine($"Gasolina: {gasolina}");
Console.WriteLine($"Diesel: {diesel}");