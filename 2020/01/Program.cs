
string? line;

List<int> report = new List<int>();
while ((line = Console.ReadLine()) != null)
{
    report.Add(Int32.Parse(line));
}

foreach (int x in report)
{
    foreach (int y in report)
    {
        foreach (int z in report)
        {
            if (x + y + z == 2020)
            {
                Console.WriteLine("{0} {1} {2}", x, y, z);
                Console.WriteLine("{0}", x * y * z);
            }
        }
    }
}
