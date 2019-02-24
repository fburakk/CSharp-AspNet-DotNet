using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// interface
interface Interface1
{
    void Print1();
}
interface Interface2
{
    void Print2();
}

interface Interface3
{
    void Print3();
}

interface Interface4 : Interface3
{
    void Print4();
}


public class Class1 : Interface1, Interface2, Interface4
{
    public void Print1()
    {
        Console.WriteLine("This is implementation of the Print1 fn. from Interface1");
    }

    public void Print2()
    {
        Console.WriteLine("This is implementation of the Print2 fn. from Interface2");
    }

    public void Print3()
    {
        Console.WriteLine("This is implementation of the Print3 fn. from Interface3");
    }

    public void Print4()
    {
        Console.WriteLine("This is implementation of the Print4 fn. from Interface4");
    }

}

class Program
{
    public static void Main()
    {
        Interface2 I2 = new Class1();
        I2.Print2();

    }
}