
Console.Write("Insira o ID do funcionario: ");
int Id = int.Parse(Console.ReadLine());


Console.Write("Insira o numero de horas trabalhadas: ");
int hrs = int.Parse(Console.ReadLine());

Console.Write("Insira o valor por hora: ");
decimal valorHora = decimal.Parse(Console.ReadLine());

decimal salario = hrs * valorHora;

Console.WriteLine($"NUMBER = {Id} ");

Console.WriteLine($"SALARY = U$ {salario:F2} ");