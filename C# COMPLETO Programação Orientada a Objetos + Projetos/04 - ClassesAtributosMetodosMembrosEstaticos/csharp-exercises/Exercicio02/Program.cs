using Exercicio02;

Funcionario func = new Funcionario();
double percent = 0;

Console.Write("Nome: ");
func.Nome = Console.ReadLine();
Console.Write("Salário bruto: ");
func.SalarioBruto = double.Parse(Console.ReadLine());
Console.Write("Imposto: ");
func.Imposto = double.Parse(Console.ReadLine());

Console.WriteLine($"Funcionário: {func}");
Console.Write("Digite a porcentagem para aumentar o salário: ");
percent = double.Parse(Console.ReadLine());
func.AumentarSalario(percent);

Console.WriteLine($"Dados atualizados: {func}");