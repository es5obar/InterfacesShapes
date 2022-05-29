using InterfacesShapes.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesShapes.Models
{
    public class RightTriangle : IShapeWithAngles
    {
        public double Width { get; set; }
        public double Height { get; set; }

        double _hypotenuse;

        public double CalculateArea()
        {
            return (Height * Width) / 2;
        }

        public double CalculateCircumference()
        {
            _hypotenuse = Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Width, 2));
            return _hypotenuse + Width + Height;
        }
    }
}
