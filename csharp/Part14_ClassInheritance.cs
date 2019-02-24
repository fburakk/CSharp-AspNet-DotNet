using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// inheritance

class Employee
{
    public string FirstName;
    public string LastName;
    public string email;

    public void PrintFirstAndLastName()
    {
        Console.WriteLine(this.FirstName + " " + this.LastName);
    }
}

class FullTimeEmployee : Employee
{
    public int YearlySalary;
}

class PartTimeEmployee : Employee
{
    public int HourlyRate;
}

class Program
{
    static void Main()
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.FirstName = "FN1";
        FTE.LastName = "LN1";
        FTE.email = "email1";
        FTE.PrintFirstAndLastName();

        PartTimeEmployee PTE = new PartTimeEmployee();
        PTE.FirstName = "FN2";
        PTE.LastName = "LN2";
        PTE.email = "email2";
        PTE.PrintFirstAndLastName();
    }
}