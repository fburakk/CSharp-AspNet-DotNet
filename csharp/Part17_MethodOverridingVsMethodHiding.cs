using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// method overriding vs method hiding

class Base
{
    public virtual void Print()
    {
        Console.WriteLine("This is the base class");
    }
}

class MethodOverridedClass : Base
{
    public override void Print()
    {
        Console.WriteLine("This is method overrided class");
    }
}

class MethodHiddenClass: Base
{
    public new void Print()
    {
        Console.WriteLine("This is method hidden class");
    }
}

class Program
{
    static void Main()
    {
        Base[] BaseArray = new Base[3];
        BaseArray[0] = new Base();
        BaseArray[1] = new MethodOverridedClass();
        BaseArray[2] = new MethodHiddenClass();


        foreach(Base b in BaseArray)
        {
            b.Print();
        }
    }
}