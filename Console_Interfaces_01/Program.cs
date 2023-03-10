namespace Console_Interfaces_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SomeClass some = new SomeClass();
            ((Ii)some).Method2();

        }
    }

    public abstract class Abs
    {
        public string str;
        public int a;
        public int b;
        public Abs(int a,int b)
        {
            this.a = a;
            this.b = b;
        }
    }

    public class NonAbs : Abs
    {
        public new string str;
        public NonAbs(int a, int b) : base(a, b)
        {

        }
    }

    interface Ii
    {
        public static string strIntfc = "123";
        public static void Method()
        {
            Console.WriteLine(".");
        }
        public void Method2() //Стандартная реализация
        {
            Console.WriteLine("...");
        }
        static Ii() //public only
        {
            
        }
    }

    class SomeClass : Ii
    {
        
    }
}