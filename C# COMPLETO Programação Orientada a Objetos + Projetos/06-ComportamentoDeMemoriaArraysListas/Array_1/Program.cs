//1. Write a C# Sharp program that stores elements in an array and prints them.
//using System.Xml.Linq;
//using static System.Net.Mime.MediaTypeNames;

//Test Data:
//Input 10 elements in the array:
//element - 0 : 1
//element - 1 : 1
//element - 2 : 2
//.......
//Expected Output :
//Elements in array are: 1 1 2 3 4 5 6 7 8 9

Console.WriteLine("Input 10 elements in the array: ");

int[] vet = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.Write($"Element - {i} : ");
    int n = int.Parse(Console.ReadLine());
    vet[i] = n;
}

Console.Write($"Elements in array are: ");
for (int i = 0;i < 10; i++)
{
    Console.Write($" {vet[i]} ");
}

