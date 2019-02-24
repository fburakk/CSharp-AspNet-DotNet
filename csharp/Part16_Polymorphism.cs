using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// polymorphism

class Employee
{
    public string FirstName;
    public string LastName;
    
    public virtual void PrintFirstAndLastName()
    {
        Console.WriteLine(this.FirstName + " " + this.LastName + " - Employee");
    }
}

class FullTimeEmployee : Employee
{
    public override void PrintFirstAndLastName()
    {
        Console.WriteLine(this.FirstName + " " + this.LastName + " - Full Time");
    }
}

class PartTimeEmployee : Employee
{
    public override void PrintFirstAndLastName()
    {
        Console.WriteLine(this.FirstName + " " + this.LastName + " - Part Time");
    }
}
class TemporaryEmployee : Employee
{
    public override void PrintFirstAndLastName()
    {
        Console.WriteLine(this.FirstName + " " + this.LastName + " - Temporary");
    }
}

class Program
{
    static void Main()
    {
        Employee[] Employees = new Employee[4];

        Employees[0] = new Employee();
        Employees[1] = new FullTimeEmployee();
        Employees[2] = new PartTimeEmployee();
        Employees[3] = new TemporaryEmployee();

        foreach (Employee e in Employees)
        {
            e.PrintFirstAndLastName();
        }

    }
}