using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// calling base class constructor from derived class

class Base
{
    public Base()
    {
        Console.WriteLine("Base class static constructor");
    }

    public Base(string Message)
    {
        Console.WriteLine("{0}", Message);
    }
}

class Derived : Base
{
    public Derived() : base("derived class controls the base class")
    {
        Console.WriteLine("Derived class constructor");
    }
}


class Program
{
    static void Main()
    {
        Derived D1 = new Derived();
    }
}