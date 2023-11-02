
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
        if (x + y == 2020)
        {
            Console.WriteLine("{0} {1}", x, y);
            Console.WriteLine("{0}", x * y);
        }
    }
}
