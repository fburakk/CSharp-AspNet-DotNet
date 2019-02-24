using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;


namespace Main
{
    // params keyword makes the parameter optional
    class Program
    {
        public static void Main()
        {
            PATA.ClassA.Print();
            PATB.ClassB.Print();
        }
    }
}

namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("This is Class A");
            }
        }
    }
}

namespace ProjectA
{
    namespace TeamB
    {
        class ClassB
        {
            public static void Print()
            {
                Console.WriteLine("This is Class B");
            }
        }
    }
}