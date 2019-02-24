using System;

// Methods
class Program
{
    static void Main(string[] args)
    {
        Program.EvenNumbers();

        Program p = new Program();
        int Sum = p.Add(235, -234);
        Console.WriteLine("Sum = {0}", Sum);
    }

    public int Add(int FN, int SN)
    {
        return FN + SN;
    }

    public static void EvenNumbers()
    {
        int Start = 0;

        while (Start <= 20)
        {
            Console.WriteLine(Start);
            Start += 2;
        }
    }
}

// Reference Parameter
class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        SimpleMethod(ref i);
        Console.WriteLine("{0}", i);
    }

    public static void SimpleMethod(ref int j)
    {
        j = 101;
    }
}

// Out Parameter
class Program
{
    public static void Main()
    {
        int Total = 0;
        int Product = 0;
        Calculate(10, 20, out Total, out Product);
        Console.WriteLine("Sum = {0} && Prod = {1}", Total, Product);
    }

    public static void Calculate(int FN, int SN, out int Sum, out int Mult)
    {
        Sum = FN + SN;
        Mult = FN * SN;
    }
}



