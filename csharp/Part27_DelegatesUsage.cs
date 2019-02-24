using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// delegates usage
class Program
{
    public static void Main()
    {
        List<Employee> empList = new List<Employee>();

        empList.Add(new Employee() { ID = 101, Name = "Mary", Salary = 6000, Experience = 6 });
        empList.Add(new Employee() { ID = 102, Name = "Bob", Salary = 4000, Experience = 4 });
        empList.Add(new Employee() { ID = 103, Name = "Forrest", Salary = 5000, Experience = 5 });
        empList.Add(new Employee() { ID = 104, Name = "Gump", Salary = 2000, Experience = 2 });

        //IsPromotable isPromotable = new IsPromotable(Promote);

        //Employee.PromoteEmployee(empList, isPromotable);
        Employee.PromoteEmployee(empList, emp => emp.Experience >= 5);

    }

    //public static bool Promote(Employee emp)
    //{

    //    if (emp.Experience >= 5)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}
}


public delegate bool IsPromotable(Employee empl);

public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
    {
        foreach (Employee e in employeeList)
        {
            if (IsEligibleToPromote(e))
            {
                Console.WriteLine("{0} promoted", e.Name);
            }
        }
    }

}