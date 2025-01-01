using System;

public class Program
{
    static string MyFunction(string i)
    {
        return i;
    }
    static char MyFunction(char i)
    {
        return i;
    }
    static void Main()
    {
        Console.WriteLine(MyFunction("Antoreep"));
         Console.WriteLine(MyFunction('A'));
    }
}

