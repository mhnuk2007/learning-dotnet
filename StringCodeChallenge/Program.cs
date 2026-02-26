using System;
public class StringCodeChallenge
{
    public static bool countTheType(object Arg, string TypeToCount)
    {
        string argTypeName = Arg.GetType().Name;
        return argTypeName == TypeToCount;
    
    }

    public static void Main()
    {
        Console.WriteLine(countTheType(123, "Int32"));
        Console.WriteLine(countTheType("Hello", "String"));
        Console.WriteLine(countTheType(true, "Boolean"));
    }
}
    
