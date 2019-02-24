using System;
using System.IO;
using System.Runtime.Serialization;

// Exception Abuse Solution

public class ExceptionHandlingAbuse
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Please enter numerator");
            int Numerator;
            bool IsNumeratorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out Numerator);
            if (IsNumeratorConversionSuccessful)
            {
                Console.WriteLine("Please enter denominator");
                int Denominator;
                bool IsDenominatorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out Denominator);
                if (IsDenominatorConversionSuccessful && Denominator != 0)
                {
                    int Result = Numerator / Denominator;
                    Console.WriteLine("Result = {0}", Result);
                }
                else
                {
                    if (Denominator == 0)
                    {
                        Console.WriteLine("Denominator can not be 0");
                    }
                    else
                    {
                        Console.WriteLine("Denominator should be between {0} and {1}", Int32.MinValue, Int32.MaxValue);
                    }
                }

            }
            else
            {
                Console.WriteLine("Numerator should be between {0} and {1}", Int32.MinValue, Int32.MaxValue);
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}