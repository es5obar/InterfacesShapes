using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesShapes.Models.Bases
{
    interface IShapeWithAngles
    {

        double Width { get; set; }

        double Height { get; set; }

        double CalculateArea();

        double CalculateCircumference();
    }
}
