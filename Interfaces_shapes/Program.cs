namespace Interfaces_shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class Hexagon : Shape, IPointy
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine($"Drawing {Name}");
        }
        public byte Points => 6;
    }

    class Triangle : Shape, IPointy
    {
        public Triangle() { }
        public Triangle(string name) : base(name) { }

        public byte Points => 3;

        public override void Draw()
        {
            Console.WriteLine($"Drawing {Name} the Triangle");
        }

    }

    abstract class Shape
    {
        public string Name { get; set; }
        public abstract void Draw();
        public Shape() { }
        public Shape(string name)
        {
            Name = name;
        }
    }

    interface IPointy
    {
        public byte Points { get; }
    }
}