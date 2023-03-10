namespace Interfaces_shapes_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Свойство Perimeter определенно в интерфейсе и
            //не определено в классе Square, что делает его
            //недоступным экземпляру классу Square
            //Чтобы получить доступ к свойству Perimeter
            //необходимо явно привестись к типу IRegularPorinty.
            Square square = new();
            int a = ((IRegularPointy)square).Perimeter;


        }
    }
    interface IRegularPointy
    {
        int SideLength { get;set;}
        int NumberOfSides { get;set;}
        //Свойства с стандартной реализацией:
        int Perimeter { get { return SideLength * SideLength; } }
        int Perimeter2 { get { return SideLength * SideLength; } set { } }

    }
    class Square : IRegularPointy
    {
        public int SideLength { get; set; }
        public int NumberOfSides { get; set; }
    }

}