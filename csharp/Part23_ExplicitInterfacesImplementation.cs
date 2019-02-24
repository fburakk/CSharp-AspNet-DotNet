using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// explicit interfaces implementation
interface I1
{
    void Print();
}
interface I2
{
    void Print();
}

interface I3
{
    void Print();
}

public class Class1 : I1, I2, I3
{
    void I1.Print()
    {
        Console.WriteLine("This is implementation of the Print fn. from I1");
    }

    void I2.Print()
    {
        Console.WriteLine("This is implementation of the Print fn. from I2");
    }

    void I3.Print()
    {
        Console.WriteLine("This is implementation of the Print fn. from I3");
    }

}

class Program
{
    public static void Main()
    {
        I1 C1 = new Class1();
        C1.Print();

        I2 C2 = new Class1();
        C2.Print();

        I3 C3 = new Class1();
        C3.Print();

    }
}