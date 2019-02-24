    // params keyword makes the parameter optional
    class Program
    {
        public static void Main()
        {
            int[] Numbers = new int[3];
            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;

            ParamsMethod();
            ParamsMethod(Numbers);
            ParamsMethod(1,2,3,4,56,7);
        }

        public static void ParamsMethod(params int[] Numbers)
        {
            Console.WriteLine("Length of the array is: {0}", Numbers.Length);
            foreach(int i in Numbers)
            {
                Console.WriteLine("{0}", i);
            }
        }
    }
