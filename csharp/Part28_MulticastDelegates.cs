using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Multicast Delegates

public delegate void SampleDelegate();

class Program
{
    static void Main()
    {
        //Single Instance
            //SampleDelegate del = new SampleDelegate(SampleMethodOne);
            
            //del += SampleMethodThree;
            //del += SampleMethodTwo;
            //del();

        // Multiple Instances
            //SampleDelegate del, del1, del2, del3;

            //del1 = new SampleDelegate(SampleMethodOne);
            //del2 = new SampleDelegate(SampleMethodTwo);
            //del3 = new SampleDelegate(SampleMethodThree);

            //del = del1 + del2 + del3 - del2;
            //del();

    }

    public static void SampleMethodOne()
    {
        Console.WriteLine("SampleMethodOne is Invoked");
    }

    public static void SampleMethodTwo()
    {
        Console.WriteLine("SampleMethodTwo is Invoked");
    }

    public static void SampleMethodThree()
    {
        Console.WriteLine("SampleMethodThree is Invoked");

    }

}

