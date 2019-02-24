using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// getter and setter methods(encapsulation)

class Program
{
    public class Student
    {
        private string _name;
        private int _id;
        private int _passMark;

        public void SetId(int Id)
        {
            if (Id <= 0)
            {
                throw new Exception("Id must be greater than 0");
            }
            this._id = Id;
        }

        public int GetId()
        {
            return this._id;
        }

        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name cannot be null or empty");
            }
            this._name = Name;
        }

        public string GetName()
        {
            return string.IsNullOrEmpty(this._name) ? "No name" : this._name;
        }
    }

    public static void Main()
    {
        Student S1 = new Student();

        S1.SetId(123);
        S1.SetName("Name1");

        Console.WriteLine("Name: {0}, Id: {1}", S1.GetName(), S1.GetId());
    }

}
