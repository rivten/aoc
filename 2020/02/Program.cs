
static bool IsPasswordValid(string password, int smallest, int biggest, char ruleChar)
{
    int count = 0;
    foreach(char c in password)
    {
        if (c == ruleChar)
        {
            count++;
        }
    }
    return count >= smallest && count <= biggest;
}

string? line;
int validCount = 0;

while((line = Console.ReadLine()) != null)
{
    string[] policyPassword = line.Split(":");
    string[] countsAndChar = policyPassword[0].Split(" ");
    string[] counts = countsAndChar[0].Split("-");
    string ruleChar = countsAndChar[1];
    string password = policyPassword[1];
    int smallest = Int32.Parse(counts[0]);
    int biggest = Int32.Parse(counts[1]);
    if(IsPasswordValid(password, smallest, biggest, ruleChar[0]))
    {
        validCount++;
    }
}
Console.WriteLine("{0}", validCount);
