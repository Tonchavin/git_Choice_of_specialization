using static System.Console;
Clear();

string[] ArrayA = { "hi", "hello", "222", "world", ":)", "aaa" };
MinArraySearch(ArrayA);

string MinArraySearch(string[] a)
{
    string min = string.Empty;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i].Length <= 3)
            min += "\"" + a[i] + "\"" + ",";
    }
    Write($"[{min}]");
    return min;
}
