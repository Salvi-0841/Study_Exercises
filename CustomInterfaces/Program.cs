namespace CustomInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CloneableType.Method2();

        }
    }
    public abstract class CloneableType
    {
        //Поддержать этот "полиморфный интерфейс"
        //могут только производные типы.
        //Классы в других иерархиях не имеют доступа
        //к данному абстрактному члену
        public abstract object Clone();

        public void Method()
        {
            Console.WriteLine(".");
        }
        public static void Method2()
        {
            Console.WriteLine(".");
        }
    }
}