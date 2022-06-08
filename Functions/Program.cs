RevershCase("ABCde");
Console.WriteLine(ReverseAndNot(123));
int[] ints = { 5, 1, 4, 3, 2 };
Console.WriteLine(ConsecutiveNumbers(ints));
Console.WriteLine(PowerRanger(3, 1, 27));


static void RevershCase(string str)
{
    string result = "";
    for (int i = 0; i < str.Length; i++)
    {
        if (char.IsUpper(str[i]))
        {
            result += char.ToLower(str[i]);
        }
        else
        {
            result += char.ToUpper(str[i]);
        }
    }
    Console.WriteLine(result);
}
static string ReverseAndNot(uint num)
{
    string str = num.ToString();
    string newStr = "";
    for (int i = str.Length - 1; i >= 0; i--)
    {
        newStr += str[i];
    }
    return newStr+str;
}
static bool ConsecutiveNumbers(int[] numbers)
{
    Array.Sort(numbers);
    return (numbers[numbers.Length - 1] - numbers[0] == numbers.Length - 1);
}
static int PowerRanger(int n,int a,int b)
{
    int counter = 0;
    for (int i = 1; i < Math.Sqrt(b); i++)
    {
        if (Math.Pow(i, n) >= a && Math.Pow(i, n) <= b)
            counter++;
    }
    return counter;
}




