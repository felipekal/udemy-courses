int x = int.Parse(Console.ReadLine());

while (x != 101)
{

    int n = int.Parse(Console.ReadLine());
    Console.WriteLine(" ");


    int fat = 1;
    for (int i = 1; i <= n; i++)
    {
        fat = fat * i;
    }

    Console.WriteLine(fat);
}