using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// abstract class
public abstract class AbsClass
{
    public abstract void Print();
}

public class Program: AbsClass
{
    public override void Print()
    {
        Console.WriteLine("This is implementation of the Print fn. from AbsClass");
    }

    public static void Main()
    {
        AbsClass P1 = new Program();
        P1.Print();
    }
}