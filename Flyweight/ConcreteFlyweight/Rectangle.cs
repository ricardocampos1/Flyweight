using Flyweight.Flyweight;

namespace Flyweight.ConcreteFlyweight
{
    class Rectangle : IShape
    {
        public void Print()
        {
            Console.WriteLine("Printing Rectangle");
        }
    }
}
