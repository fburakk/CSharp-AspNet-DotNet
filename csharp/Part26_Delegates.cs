using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// delegates
public delegate void HelloFunctionDelegate(string StrMessage);

public class Program
{
    public static void Main()
    {
        HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
        del("Hello");
    }
    public static void Hello(string message)
    {
        Console.WriteLine(message);
    }

}