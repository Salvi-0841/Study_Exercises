namespace ICloneable_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static void CleneableExample()
        {
            //Все эти классы поддерживают интерфейс ICloneable
            string myStr = "Hello";
            OperatingSystem unixOS = new(PlatformID.Unix, new Version());
            //Следовательно, все они могут быть переданы методу,
            //принимающему параметр типа ICloneable
            CloneMe(myStr);
            CloneMe(unixOS);
            
        }

        static void CloneMe(ICloneable c)
        {
            object theClone = c.Clone();
            Console.WriteLine("Your clone is a: {0}",theClone.GetType().Name);
        }
    }
}