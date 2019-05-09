using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingWork
{
    // Interface which contains information about figures.
    interface IFigure
    {
        void GetInfo();
        void GetInfoToFile(StreamWriter someFile);
        double GetPerimeter();
        double GetSquare();
    }
}
