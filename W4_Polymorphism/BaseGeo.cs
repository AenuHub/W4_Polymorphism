namespace W4_Polymorphism
{
    public class BaseGeoShape
    {
        private double _height;
        private double _width;

        public double Height { get; set; }
        public double Width { get; set; }

        public virtual double Area()
        {
            return Height * Width;
        }
    }

    public class Square : BaseGeoShape
    {
        // no need to override Area()
    }

    public class Rectangle : BaseGeoShape
    {
        // no need to override Area()
    }

    public class RightTriangle : BaseGeoShape
    {
        public override double Area()
        {
            return (Height * Width) / 2;
        }
    }
}
