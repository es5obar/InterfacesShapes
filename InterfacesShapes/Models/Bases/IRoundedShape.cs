using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesShapes.Models.Bases
{
    interface IRoundedShape
    {
        double Radius { get; set; }

        bool IsPiThree { get; set; }

        double CalculateArea();
        double CalculateCircumference();
    }
}
