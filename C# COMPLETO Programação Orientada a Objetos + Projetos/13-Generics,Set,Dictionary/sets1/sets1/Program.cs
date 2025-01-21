using sets1.Entities;

HashSet<LogRecord> set = new HashSet<LogRecord>();


Console.Write("enter file path ");
string path = Console.ReadLine();

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine().Split(' ');
            string name = line[0];
            DateTime instant = DateTime.Parse(line[1]);

            set.Add(new LogRecord(name, instant));
        }
        Console.WriteLine("Total users:" + set.Count);
    }
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}