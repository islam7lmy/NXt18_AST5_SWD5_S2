using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    //not fully implmented class => so you can't create object from it

    internal abstract class Shape
    {
        ///property implementation => property with implementation
        public double Dim01 { get; set; }
        public double Dim02 { get; set; }

        //not implmented property just signture
        public abstract double Perimeter { get; }
        public abstract double Area { get; }

        /// abstract method => a method that is declared in an abstract class but 
        /// does not have an implementation.
        /// virtual method => a method that is declared in a base class and can be overridden in a derived class.
        //public abstract double CalcArea();

        public void test()
        {
            Console.WriteLine("Hello i am  default implment method");
        }

        //public abstract void test()
        //{
        //    Console.WriteLine("Hello i am  default implment method");
        //}

    }

    class Squere : Shape
    {
        //public double Dim01 { get; set; }

        public override double Perimeter { get { return Dim01 * 4; } }

        public override double Area { get { return Dim01 * Dim01; } }

        //public double CalcArea()
        //{
        //    return Dim01 * Dim01;
        //}
    }

    class Rectangle : Shape
    {
        //public double Dim01 { get; set; }
        //public double Dim02 { get; set; }
        public override double Perimeter { get { return 2 * (Dim01 + Dim02); } }

        public override double Area { get { return Dim01 * Dim01; } }

    }
}

namespace OOP.Abstraction02
{
    public interface IShape
    {
        double Perimeter { get; }
        double Area { get; }
    }
    internal abstract class Shape : IShape
    {
        public abstract double Perimeter { get; }
        public abstract double Area { get; }
        protected static double EnsurePostive(double value,string parmname)
        {
            if(value <= 0)
                throw new ArgumentException($"{parmname} must be greater than zero");
            return value;
        }
    }

    class Squere : Shape
    {
        public double Side { get; }
        public Squere(double _side)
        {
            //if (_side <= 0)
            //    throw new ArgumentException($"side must be greater than zero");
            //Side = _side;

            Side = EnsurePostive(_side, nameof(Side));
        }

        public override double Perimeter { get { return Side * 4; } }

        public override double Area { get { return Side * Side; } }
    }

    class Rectangle : Shape
    {
        public double Width { get; private set; }
        public double Height { get; private set; }
        public Rectangle(double _width, double _height)
        {
            if (_width <= 0)
                throw new ArgumentException($"width must be greater than zero");
            if (_height <= 0)
                throw new ArgumentException($"height must be greater than zero");
            Width = _width;
            Height = _height;
        }
        public override double Perimeter { get { return 2 * (Width + Height); } }

        public override double Area { get { return Width * Height; } }

    }
}
