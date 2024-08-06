Console.Write("Insert the two numbers in the matrix: ");
string[] matrix = Console.ReadLine().Split(' ');
int n = int.Parse(matrix[0]);
int m = int.Parse(matrix[1]);

int[,] mat = new int[n, m];

Console.WriteLine("Insert the values for the matrix (separated by one space)");

for (int i=0; i<n; i++)
{
    string[] numbers = Console.ReadLine().Split(' ');
    for (int j=0; j<m; j++)
    {
        mat[i,j] = int.Parse(numbers[j]);
    }
}

Console.Write("Enter a value of the matrix, to show te current position and adjacents: ");
int x = int.Parse(Console.ReadLine());

for(int i=0; i < n; i++)
{
    for(int j=0; j < m; j++)
    {
        if (mat[i,j] == x)
        {
            Console.WriteLine($"\n Position: {i},{m}");
            if (j > 0)
            {
                Console.WriteLine($"Left: {mat[i, j-1]}");
            }
            if (i > 0)
            {
                Console.WriteLine($"Up: {mat[i-1,j]}");
            }
            if (j<m - 1)
            {
                Console.WriteLine($"Right: {mat[i,j+1]}");
            }
            if(i<n - 1)
            {
                Console.WriteLine($"Down: {mat[i+1,j]}");
            }

        }
    }
}