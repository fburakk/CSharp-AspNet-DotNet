using System;
using System.IO;

// Exception Handling
class Program
{
    public static void Main()
    {
        StreamReader streamReader = null;
        try
        {
            streamReader = new StreamReader(@"C:\File.txt");
            Console.WriteLine(streamReader.ReadLine());
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Please check if the file {0} exists", ex.FileName);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (streamReader != null)
            {
                Console.WriteLine("Finally Block!");
                streamReader.Close();
            }
        }


    }
}