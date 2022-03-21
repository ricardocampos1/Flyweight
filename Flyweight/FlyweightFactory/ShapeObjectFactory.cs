using Flyweight.ConcreteFlyweight;
using Flyweight.Flyweight;

namespace Flyweight.FlyweightFactory
{
    class ShapeObjectFactory
    {
        readonly Dictionary<string, IShape> shapes = new();

        public int TotalObjectsCreated
        {
            get { return shapes.Count; }
        }

        public IShape GetShape(string ShapeName)
        {
            IShape shape;
            if (shapes.ContainsKey(ShapeName))
            {
                shape = shapes[ShapeName];
            }
            else
            {
                switch (ShapeName)
                {
                    case "Rectangle":
                        shape = new Rectangle();
                        shapes.Add("Rectangle", shape);
                        break;
                    case "Circle":
                        shape = new Circle();
                        shapes.Add("Circle", shape);
                        break;
                    default:
                        throw new Exception("Factory cannot create the object specified");
                }
            }
            return shape;
        }
    }
}
