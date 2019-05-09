using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialising list of figures which implements IFigure interface.
            List<IFigure> figures = new List<IFigure>()
            {
                new Rectangle(10, 15),
                new Rectangle(5, 8, "Harold"),
                new Circle(2),
                new Circle(1.3, "Arthur"),
                new Circle()
            };

            using (StreamWriter file = new StreamWriter("OutputData.txt"))
            {
                // Cycle for getting information about figures.
                foreach (var figure in figures)
                {
                    figure.GetInfo();
                    figure.GetInfoToFile(file);
                }
            }
            Console.ReadLine();
        }
    }
}
