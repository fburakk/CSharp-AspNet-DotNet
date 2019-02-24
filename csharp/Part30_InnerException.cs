using System;
using System.IO;

// Inner Exception
class InnerException
{
    public static void Main()
    {
        try
        {
            try
            {
                Console.WriteLine("Please enter the first number");
                int FN = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the second number");
                int SN = Convert.ToInt32(Console.ReadLine());
                int result = FN / SN;
            }
            catch (Exception ex)
            {
                string FilePath = "C:\\File1.txt";
                if (File.Exists(FilePath))
                {
                    StreamWriter sw = new StreamWriter(FilePath);
                    sw.Write(ex.GetType().Name);
                    sw.Close();
                    Console.WriteLine("There is a problem please try again!");
                }
                else
                {
                    throw new FileNotFoundException(FilePath + " is not present", ex);
                }
            }
        }
        catch (Exception exception)
        {
            Console.WriteLine("First Exception is = {0}", exception.GetType().Name);

            if (exception.InnerException != null)
            {
                Console.WriteLine("Inner Exception is = {0}", exception.InnerException.GetType().Name);
            }
        }

    }
}