using System;

// Loops
class Program
{

    public static void Main()
    {
        int[] Numbers = new int[3];

        Numbers[0] = 101;
        Numbers[1] = 102;
        Numbers[2] = 103;

        foreach (int k in Numbers)
        {
            Console.WriteLine(k);
        }
        for (int j = 0; j < Numbers.Length; j++)
        {
            Console.WriteLine(Numbers[j]);
        }

        int i = 0;
        while (i < Numbers.Length)
        {
            Console.WriteLine(Numbers[i]);
            i++;
        }
    }
}