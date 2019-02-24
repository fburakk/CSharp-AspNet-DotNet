using System;

//Instance Method
class Program
{
    static void Main(string[] args)
    {
        Program p = new Program();
        p.EvenNumbers();
    }

    public void EvenNumbers()
    {
        int Start = 0;

        while (Start <= 20)
        {
            Console.WriteLine(Start);
            Start += 2;
        }
    }
}

//Static Method
class Program
{
    static void Main(string[] args)
    {
        Program.EvenNumbers();
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
