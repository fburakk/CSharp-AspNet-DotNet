using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// classes with overloaded constructors

namespace ns1
{
    class Customer
    {
        string _firstName, _lastName;

        public Customer()
            : this("No first name provided", "No last name provided")
        { }

        public Customer(string FirstName, string LastName)
        {
            this._firstName = FirstName;
            this._lastName = LastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine("Full Name is: {0}", this._firstName + " " + this._lastName);
        }
    }
}
class Program
{


    public static void Main()
    {
        ns1.Customer C1 = new ns1.Customer();
        ns1.Customer C2 = new ns1.Customer("ilk isim", "ikinci isim");
        C1.PrintFullName();
        C2.PrintFullName();

    }

}
