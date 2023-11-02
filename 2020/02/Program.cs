
static bool IsPasswordValidV1(string password, int smallest, int biggest, char ruleChar)
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

static bool IsPasswordValidV2(string password, int smallest, int biggest, char ruleChar)
{
    return (password[smallest - 1] == ruleChar) ^ (password[biggest - 1] == ruleChar);
}

string? line;
int validCountV1 = 0;
int validCountV2 = 0;

while((line = Console.ReadLine()) != null)
{
    string[] policyPassword = line.Split(":");
    string[] countsAndChar = policyPassword[0].Split(" ");
    string[] counts = countsAndChar[0].Split("-");
    string ruleChar = countsAndChar[1];
    string password = policyPassword[1].Trim();
    int smallest = Int32.Parse(counts[0]);
    int biggest = Int32.Parse(counts[1]);
    if(IsPasswordValidV1(password, smallest, biggest, ruleChar[0]))
    {
        validCountV1++;
    }
    if(IsPasswordValidV2(password, smallest, biggest, ruleChar[0]))
    {
        validCountV2++;
    }
}
Console.WriteLine("{0}", validCountV1);
Console.WriteLine("{0}", validCountV2);
