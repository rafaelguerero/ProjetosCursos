

using PjAbstract.Model.Enums;

namespace PjAbstract.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}
