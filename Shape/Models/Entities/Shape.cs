using Shape.Models.Enums;

namespace Shape.Models.Entities
{
    internal abstract class Shape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
