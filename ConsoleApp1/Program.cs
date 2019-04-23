using System;

namespace ConsoleApp1
{
    public interface IMeasurable
    {
        double Perimeter();
        double Area();
    }
    public interface ICircumcircleIncircle
    {
        double R { get; } // радіус описаного кола
        double r { get; } // радіус вписаного кола
    }

    class Square: IMeasurable,ICircumcircleIncircle
    {
        private double r1;
        private double R1;
        Square(double r1, double R1)
        {
            this.r1 = r1;
            this.R1 = R1;
        }
        private double Side
        {
            get { return Side; }
            set { Side = value; }
        }
        
        
        public double r
        {
            get { return r1; }
        }
        
        public double R
        {
            get { return R1; }
        }
        
        public double Perimeter()
        {
            return 4 * Math.Pow(2, 1.0 / 2.0) * R1;
        }
        
        public double Area()
        {
            return 4 * R1 * R1;
        }
        
        
        static void Main(string[] args)
        {
            Square square = new Square(5, 7);
            Console.WriteLine(square.Area());
            Console.WriteLine(square.Perimeter());
            
        }
    }
}