using System.Collections;

namespace yield_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Garage : IEnumerable
    {
        Car[] cars = new Car[10];
        public Garage()
        {
            cars[0] = new Car("A");
            cars[1] = new Car("B");
            cars[2] = new Car("C");
            cars[3] = new Car("D");
            cars[4] = new Car("E");
        }
        public IEnumerator GetEnumerator()
        {
            //Ключевое слово yield применяется для указания значения
            //или значений, которые подлежат возвращению конструкцией
            //foreach вызывающему коду. При достижении оператора yield return
            //текущее местоположение в контейнере сохраняется и выполнение
            //возобновляется с этого местоположения,
            //когда итератор вызывается в следующий раз
            foreach (Car car in cars)
            {
                yield return car;
            }
        }
    }

    public class Car
    {
        public string Name { get; set; }
        public Car(string name)
        {
            Name = name;
        }
    }
}