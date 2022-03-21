using Flyweight.Flyweight;

namespace Flyweight.ConcreteFlyweight
{
    class Circle : IShape
    {
        public void Print()
        {
            Console.WriteLine("Printing Circle");
        }
    }
}
