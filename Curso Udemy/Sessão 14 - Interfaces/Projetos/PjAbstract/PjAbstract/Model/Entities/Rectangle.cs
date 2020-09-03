

using System.Globalization;

namespace PjAbstract.Model.Entities
{
    class Rectangle: AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Rectangle color = " + Color + ", Width = " + Width + ", Height = " + Height + ", Area = " + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
