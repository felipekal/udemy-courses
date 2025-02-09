string path = @"c:\temp\sourcefile.csv";

try
{
    string[] lines = File.ReadAllLines(path);

    using (StreamReader sr = new StreamReader(path))
    {
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}
catch(IOException e)
{
    Console.WriteLine("An error ocurred");
    Console.WriteLine(e.Message);
}