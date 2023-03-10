namespace Interfaces_ctors_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{IRegularPointy.ExampleProperty}");    
        }
    }
    interface IRegularPointy
    {
        int SideLenght { get; set; }
        int NumberOfSides { get; set; }
        int Perimeter => SideLenght * NumberOfSides;

        //Статические члены: статическое свойство и статический конструктор
        static string ExampleProperty { get; set; }
        static IRegularPointy() => ExampleProperty = "Foo";
        //Статические конструкторы не должны иметь параметры и могут получать
        //доступ только к статическим свойствам и методам.
    }

}