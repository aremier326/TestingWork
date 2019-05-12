using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingWork
{
    class Rectangle : IFigure
    {
        // Private fields for storing data.
        private double x;
        private double y;
        
        // Custom X property.
        public double X
        {
            get => x;
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("X should be more than 0! Now X is 1.\n");
                    x = 1;
                }

                else x = value;
            }
        }

        // Custom Y property.
        public double Y
        {
            get => y;
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Y should be more than 0!!! Now Y is 1.\n");
                    y = 1;
                }

                else y = value;
            }
        }

        // Automatic property for name of Rectangle.
        public string RectangleName { get; private set; }


        // Default constructor.
        public Rectangle(){}

        // Custom constructor for sides of Rectangle.
        public Rectangle(int x, int y)
        : this(x, y, "NONAME") { }

        // Custom constructor for both sides and name.
        public Rectangle(int x, int y, string name)
        {
            X = x;
            Y = y;
            RectangleName = name;
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
        public double GetPerimeter() => 2 * (X + Y);

        // Implicit implementation of IFigure GetSquare.
        public double GetSquare() => X * Y;

        // Overriden method ToString() for showing info about Rectangle.
        public override string ToString()
        {
            return string.Format($"Rectangle: X = {X:f2}, Y = {Y:f2}, Name = {RectangleName}");
        }
    }
}
