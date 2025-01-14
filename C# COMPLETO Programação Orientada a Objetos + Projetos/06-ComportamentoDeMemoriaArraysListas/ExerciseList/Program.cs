using ExerciseList;

Console.Write("How many employees will be registered?: ");
int n = int.Parse(Console.ReadLine());

List<Employee> employees = new List<Employee>();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Employee #{i}: ");
    
    Console.Write("ID: ");
    int id = int.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine());

    employees.Add(new Employee(id, name, salary));
}

Console.Write("Enter the employee ID that will have salary increase: ");
n = int.Parse(Console.ReadLine());

Employee emp = employees.Find(x => x.Id == n);

if (emp != null)
{
    Console.Write("Enter the percentage: ");
    double percentage = double.Parse(Console.ReadLine());
    emp.SalaryIncrease(percentage);
}
else
{
    Console.WriteLine("This ID does not exist! ");
}

Console.WriteLine();
Console.WriteLine("Updated list of employees: ");
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
}



