using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// properties

class Program
{
    public class Student
    {
        private string _name;
        private int _id;
        private int _passMark = 35;


        public string City { get; set; } // Auto implemented property
        public int PassMark // Read Only property
        {
            get
            {
                return this._passMark;
            }
        }
        public int Id // Read Write property
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Id must be greater than 0");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }

        }

        public string Name // Read Write property
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null or empty");
                }
                this._name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._name) ? "No name" : this._name;
            }
        }
    }

    public static void Main()
    {
        Student S1 = new Student();

        S1.Id = 123;
        S1.Name = "Name1";
        S1.City = "City1";

        Console.WriteLine("Name: {0}, Id: {1}, PassMark: {2}, City: {3}", S1.Name, S1.Id, S1.PassMark, S1.City);
    }

}
