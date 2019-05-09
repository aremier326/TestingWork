using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingWork
{
    class Circle : IFigure
    {
        // Private field for storing radius.
        private double r;

        // Custom property for radius of the circle;
        public double Radius
        {
            get => r;
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Radius should be more than 0");
                    r = 1;
                }
                else r = value;
            }
        }

        // Automatic property for the name of Circle;
        public string CircleName { get; private set; }

        // Default constructor.
        public Circle() { }

        // Custom constructor for radius only.
        public Circle(double r) : this(r, "NONAME") { }

        // Custom constructor for name and radius.
        public Circle(double r, string name)
        {
            Radius = r;
            CircleName = name;
        }

        // Implicit implementation of IFigure GetInfo.
        public void GetInfo()
        {
            Console.WriteLine(this.ToString());
            Console.WriteLine($"The perimeter is: {GetPerimeter():f2}");
            Console.WriteLine($"The square is: {GetSquare():f2}");
            Console.WriteLine();
        }

        // Implicit implementation of IFigure GetInfoToFile.
        public void GetInfoToFile(StreamWriter someFile)
        {
            someFile.WriteLine(this.ToString());
            someFile.WriteLine($"The perimeter is: {GetPerimeter():f2}");
            someFile.WriteLine($"The square is: {GetSquare():f2}");
            Console.WriteLine();
        }

        // Implicit implementation of IFigure GetPerimeter.
        public double GetPerimeter() => 2 * Math.PI * Radius;

        // Implicit implementation of IFigure GetSquare.
        public double GetSquare() => 2 * Math.PI * Math.Pow(Radius, 2);

        // Overriden method ToString() for showing info about Circle.
        public override string ToString()
        {
            return string.Format($"Circle: Radius = {Radius:f2}, Name = {CircleName}");
        }


    }
}
