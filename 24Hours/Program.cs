
string str = "12:45:54PM";

int h1 = (int)str[1] - '0';
int h2 = (int)str[0] - '0';
int hh = (h2 * 10 + h1 % 10);
string result = "";

if (str[8] == 'A')
{
    if (hh == 12)
    {
        result = hh.ToString();
        for (int i = 2; i <= 7; i++)
            result = result + str[i];
    }
    else
    {
        for (int i = 0; i <= 7; i++)
            result = result + str[i];
    }
}
else
{
    if (hh == 12)
    {
        result = hh.ToString();
        for (int i = 2; i <= 7; i++)
            result = result + str[i];
    }
    else
    {
        hh = hh + 12;
        result = hh.ToString();
        for (int i = 2; i <= 7; i++)
            result = result + str[i];
    }
}

Console.WriteLine($"{result}");
Console.ReadKey();