using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// static class members

class Circle
{
    static float _PI;
    float _Area;
    int _Radius;

    static Circle()
    {
        Console.WriteLine("Static Constructor Called");
        Circle._PI = 3.1415F;
    }

    public Circle(int Radius)
    {
        Console.WriteLine("Instance Constructor Called");
        this._Radius = Radius;
    }

    public float CalculateArea()
    {
        this._Area = Circle._PI * this._Radius * this._Radius;
        Console.WriteLine("Area of the circle is: {0}", this._Area);
        return this._Area;
    }

}

class Program
{
    public static void Main()
    {
        Circle C1 = new Circle(5);
        C1.CalculateArea();

        Circle C2 = new Circle(6);
        C2.CalculateArea();
    }
}