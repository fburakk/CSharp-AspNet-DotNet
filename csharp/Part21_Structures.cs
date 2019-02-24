using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// structures
public struct Customer
{
    private string _name;
    private int _id;
    private string _city;

    public string Name
    {
        get
        {
            return _name;
        }

        set
        {
            _name = value;
        }
    }

    public int Id
    {
        get
        {
            return _id;
        }

        set
        {
            _id = value;
        }
    }

    public string City
    {
        get
        {
            return _city;
        }

        set
        {
            _city = value;
        }
    }

    public void PrintInfo()
    {
        Console.WriteLine("Name: {0}, Id: {1}, City: {2}", Name, Id, City);
    }

    public Customer(int Id, string Name, string City)
    {
        this._id = Id;
        this._name = Name;
        this._city = City;
    }
}

public class Program
{
    public static void Main()
    {
        Customer C1 = new Customer();

        C1.Id = 1111;
        C1.Name = "Name1";
        C1.City = "City1";
        C1.PrintInfo();

        Customer C2 = new Customer
        {
            Id = 2222,
            Name = "Name2",
            City = "City2"
        };
        C2.PrintInfo();

        Customer C3 = new Customer(3333, "Name3", "City3");
        C3.PrintInfo();

    }

}
